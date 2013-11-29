/******************************************************
*                    STORE PROCEDURES                 *
*******************************************************/
use [GD2C2013]
GO

-----------------------------------------------------------------
-- PROCEDURE ROL
-----------------------------------------------------------------
CREATE PROCEDURE NN_NN.sp_add_rol
	@nombre VARCHAR(255),
	@habilitado bit = 1,
	@funcionalidad XML
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DECLARE @ID NUMERIC(18,0)
			INSERT INTO NN_NN.ROL (NOMBRE, HABILITADO)VALUES (@nombre, @habilitado)
			SET @ID = SCOPE_IDENTITY();
			INSERT INTO NN_NN.ROL_FUNCIONALIDAD (ID_ROL, ID_FUNCIONALIDAD)
			SELECT @ID, FUN.ID FROM NN_NN.FUNCIONALIDAD AS FUN
				WHERE  EXISTS (SELECT	ParamValues.Names.value('.','VARCHAR(255)')  
				FROM @funcionalidad.nodes('/DocumentElement/Funcionalidad/Name') as ParamValues(Names) WHERE ParamValues.Names.value('.','VARCHAR(255)') = FUN.NOMBRE)
			COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			DECLARE @errorMessage NVARCHAR(4000);
			DECLARE @errorSeverity INT;
			DECLARE @errorState INT;
			
			ROLLBACK TRANSACTION
			
			SELECT 
				@errorMessage = ERROR_MESSAGE(),
				@errorSeverity = ERROR_SEVERITY(),
				@errorState = ERROR_STATE();
				
			SET @errorMessage = 'Nombre: Ya existe un rol con ese nombre';
			RAISERROR (@errorMessage, 
				@errorSeverity, 
				@errorState
			);
		END CATCH
END
GO
CREATE PROCEDURE NN_NN.sp_modificar_rol
	@nombre VARCHAR(255),
	@Id VARCHAR(255),
	@habilitado bit = 1,
	@funcionalidad XML
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
	
		UPDATE NN_NN.ROL SET NOMBRE = @nombre, HABILITADO = @habilitado WHERE ID = @Id
		DELETE FROM NN_NN.ROL_FUNCIONALIDAD WHERE ID_ROL = @Id
		INSERT INTO NN_NN.ROL_FUNCIONALIDAD (ID_ROL, ID_FUNCIONALIDAD)
			SELECT @Id, FUN.ID FROM NN_NN.FUNCIONALIDAD AS FUN
				WHERE  EXISTS (SELECT	ParamValues.Names.value('.','VARCHAR(255)')  
				FROM @funcionalidad.nodes('/DocumentElement/Funcionalidad/Name') as ParamValues(Names) WHERE ParamValues.Names.value('.','VARCHAR(255)') = FUN.NOMBRE)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		DECLARE @errorMessage NVARCHAR(4000);
		DECLARE @errorSeverity INT;
		DECLARE @errorState INT;
			
		ROLLBACK TRANSACTION
			
		SELECT 
			@errorMessage = ERROR_MESSAGE(),
			@errorSeverity = ERROR_SEVERITY(),
			@errorState = ERROR_STATE();
				
		SET @errorMessage = 'Nombre: Ya existe un rol con ese nombre';
		RAISERROR (@errorMessage, 
			@errorSeverity, 
			@errorState
		);
	END CATCH
END
GO
CREATE PROCEDURE NN_NN.sp_listar_rol_funcionalidad
	@nombre VARCHAR(255) = NULL,
	@funcionalidad VARCHAR(255) = NULL
AS 
BEGIN
	SET NOCOUNT ON
	Declare @chvQuery nvarchar(max), @chvWhere nvarchar(max);
	Select @chvQuery = 'SET QUOTED_IDENTIFIER OFF SELECT R.ID AS ROL, R.NOMBRE AS NOMBRE, F.NOMBRE AS FUNCIONALIDAD, R.HABILITADO AS HABILITADO FROM NN_NN.FUNCIONALIDAD AS F, NN_NN.ROL AS R, NN_NN.ROL_FUNCIONALIDAD AS RF WHERE R.ID = RF.ID_ROL AND F.ID = RF.ID_FUNCIONALIDAD',
	@chvWhere = ''
	If @nombre is not null 
		Set @chvWhere = @chvWhere + ' R.NOMBRE LIKE "%' + @nombre + '%" AND'
	If @funcionalidad is not null 
		Set @chvWhere = @chvWhere + ' F.NOMBRE LIKE "%' + @funcionalidad + '%" AND'
	begin try
		If Substring(@chvWhere, Len(@chvWhere) - 3, 4) = ' AND'
			set @chvWhere = Substring(@chvWhere, 1, Len(@chvWhere) - 3)
	end try
	begin Catch
		Raiserror ('Error Interno.', 16, 1)
        return
    end catch
	
	begin try	
		If Len(@chvWhere) > 0
			set @chvQuery = @chvQuery + ' AND' + @chvWhere
		exec (@chvQuery)
	end try
    begin Catch
		declare @s varchar(max)
		set @s = 'No pudo realizar la consulta: ' + @chvQuery
		Raiserror (@s, 16, 2)
		return
     end catch
END
GO
-----------------------------------------------------------------
-- PROCEDURE PLANES
-----------------------------------------------------------------
CREATE PROCEDURE [NN_NN].[sp_listar_plan]
	@descripcion VARCHAR(255) = NULL,
	@codigo INT = 0
AS 
BEGIN
	SET NOCOUNT ON
	Declare @chvQuery nvarchar(max), @chvWhere nvarchar(max);
	Select @chvQuery = 'SET QUOTED_IDENTIFIER OFF SELECT codigo, descripcion, precio_bono_consulta, precio_bono_farmacia FROM [NN_NN].[PLAN_MEDICO]',
		   @chvWhere = ''
	If (@descripcion is not null AND @descripcion != '') 
		Set @chvWhere = @chvWhere + ' descripcion LIKE "%' + @descripcion + '%" AND'
	If (@codigo > 0)
		Set @chvWhere = @chvWhere + ' codigo = '+ CONVERT (VARCHAR,@codigo) +' AND'

	begin try
		If Substring(@chvWhere, Len(@chvWhere) - 3, 4) = ' AND'
			set @chvWhere = Substring(@chvWhere, 1, Len(@chvWhere) - 3)
	end try
	begin Catch
		Raiserror ('Error Interno.', 16, 1)
        return
    end catch
	
	begin try
		If Len(@chvWhere) > 0
			set @chvQuery = @chvQuery + ' WHERE ' + @chvWhere
		exec (@chvQuery)
	end try
    begin Catch
		declare @s varchar(max)
		set @s = 'No pudo realizar la consulta: ' + @chvQuery
		Raiserror (@s, 16, 2)
		return
     end catch
END
GO
-----------------------------------------------------------------
-- PROCEDURE ESPECIALIDAD_MEDICA
-----------------------------------------------------------------
CREATE PROCEDURE [NN_NN].[sp_listar_especialidad]
	@descripcion VARCHAR(255) = NULL,
	@codigoTipo INT = 0,
	@codigo INT = 0
AS 
BEGIN
	SET NOCOUNT ON
	Declare @chvQuery nvarchar(max), @chvWhere nvarchar(max);
	Select @chvQuery = 'SELECT P.codigo AS codigo, P.descripcion AS descripcion, T.codigo As codigo_tipo, T.descripcion AS descripcion_tipo FROM [NN_NN].[ESPECIALIDAD] AS P LEFT JOIN [NN_NN].[TIPO_ESPECIALIDAD] AS T ON P.cod_tipo_especialidad = T.codigo',
		   @chvWhere = ''
	If (@descripcion is not null AND @descripcion != '') 
		Set @chvWhere = @chvWhere + ' P.descripcion LIKE "%' + @descripcion + '%" AND'
	If (@codigo > 0)
		Set @chvWhere = @chvWhere + ' P.codigo = '+ CONVERT (VARCHAR,@codigo) +' AND'
	If (@codigoTipo > 0)
		Set @chvWhere = @chvWhere + ' T.codigo = '+ CONVERT (VARCHAR,@codigoTipo) +' AND'

	begin try
		If Substring(@chvWhere, Len(@chvWhere) - 3, 4) = ' AND'
			set @chvWhere = Substring(@chvWhere, 1, Len(@chvWhere) - 3)
	end try
	begin Catch
		Raiserror ('Error Interno.', 16, 1)
        return
    end catch
	
	begin try
		If Len(@chvWhere) > 0
			set @chvQuery = @chvQuery + ' WHERE ' + @chvWhere
		exec (@chvQuery)
	end try
    begin Catch
		declare @s varchar(max)
		set @s = 'No pudo realizar la consulta: ' + @chvQuery
		Raiserror (@s, 16, 2)
		return
     end catch
END
GO

/******************************************************
*                    ADD AFILIADO                     *
*******************************************************/
CREATE PROCEDURE [NN_NN].[sp_listar_profesional](
	@apellido VARCHAR(255) = NULL,
	@nombre VARCHAR(255) = NULL,
	@matricula INT = 0,
	@cod_tipo INT = 0,
	@cod_especialidad INT = 0,
	@enable CHAR = '1'
)
AS 
BEGIN
	SET NOCOUNT ON
	Declare @chvQuery nvarchar(max), 
			@chvWhere nvarchar(max), 
			@chvSubQuery nvarchar(max),
			@chvSubWhere nvarchar(max);
	Select @chvQuery = 'SELECT numero, apellido, nombre, matricula, fecha_nac, enable ',
		@chvWhere = ''
	set @chvQuery += 'FROM [NN_NN].[PROFESIONAL] ';
	
	If (@apellido is not null AND @apellido != '') 
		Set @chvWhere = @chvWhere + ' apellido LIKE ''%' + @apellido + '%'' AND'
	If (@nombre is not null AND @nombre != '') 
		Set @chvWhere = @chvWhere + ' nombre LIKE ''%' + @nombre + '%'' AND'
	If (@matricula > 0)
		Set @chvWhere = @chvWhere + ' matricula = '+ CONVERT (VARCHAR, @matricula) +' AND'
	PRINT @chvWhere
	Set @chvWhere = @chvWhere + ' enable = '+ CONVERT (VARCHAR, @enable) +' AND'
	PRINT @chvWhere
	
	If (@cod_tipo > 0 OR @cod_especialidad > 0)
	BEGIN
		SELECT @chvSubQuery = 'SELECT p.numero FROM [NN_NN].[PROFESIONAL] ',
			   @chvSubWhere = '';
		SET @chvSubQuery += 'AS P LEFT JOIN [NN_NN].[PROFESIONAL_ESPECIALIDAD] AS PE ';
		SET @chvSubQuery += 'ON P.numero = PE.nro_profesional  LEFT JOIN [NN_NN].[ESPECIALIDAD] '
		SET @chvSubQuery += 'AS E ON PE.cod_especialidad =  E.codigo LEFT JOIN [NN_NN].[TIPO_ESPECIALIDAD] '
		SET @chvSubQuery += 'AS TE ON E.cod_tipo_especialidad = TE.codigo'
		if (@cod_especialidad > 0)
			Set @chvSubWhere = @chvSubWhere + ' E.codigo = '+ CONVERT (VARCHAR, @cod_especialidad) +' AND'
		if (@cod_tipo > 0)
			Set @chvSubWhere = @chvSubWhere + ' TE.codigo = '+ CONVERT (VARCHAR, @cod_tipo) +' AND'
		begin try
			If Substring(@chvSubWhere, Len(@chvSubWhere) - 3, 4) = ' AND'
				set @chvSubWhere = Substring(@chvSubWhere, 1, Len(@chvSubWhere) - 3)
		end try
		begin Catch
			Raiserror ('Error Interno.', 16, 1)
			return
		end catch
		
		If Len(@chvSubWhere) > 0
			set @chvSubQuery = @chvSubQuery + ' WHERE ' + @chvSubWhere
		Set @chvWhere += ' numero IN (' + @chvSubQuery + ') AND' 
	END
	begin try
		If Substring(@chvWhere, Len(@chvWhere) - 3, 4) = ' AND'
			set @chvWhere = Substring(@chvWhere, 1, Len(@chvWhere) - 3)
	end try
	begin Catch
		Raiserror ('Error Interno.', 16, 1)
        return
    end catch
	
	begin try
		If Len(@chvWhere) > 0
			set @chvQuery = @chvQuery + ' WHERE ' + @chvWhere
		print @chvQuery
		print @chvWhere
		exec (@chvQuery)
	end try
    begin Catch
		declare @s varchar(max)
		set @s = 'No pudo realizar la consulta: ' + @chvQuery
		Raiserror (@s, 16, 2)
		return
     end catch
END
GO
/******************************************************
*                    ADD AFILIADO                     *
*******************************************************/

CREATE FUNCTION [NN_NN].FN_RETURN_ID_AFILIADO (
)
RETURNS INT
AS 
BEGIN
	DECLARE @id INT;
	SET @id = 0;
	SELECT @id = MAX(numero) FROM [NN_NN].AFILIADO;
	RETURN @id; 
	 
END
GO
CREATE PROCEDURE NN_NN.SP_ADD_AFILIADO (
	@apellido VARCHAR(255), 
	@nombre VARCHAR(255),
	@estadoCivil INT,
	@plan INT,
	@tipoDocumento INT,
	@documento INT,
	@telefono INT,
	@direccion VARCHAR(255), 
	@fecha VARCHAR(255),
	@email VARCHAR(255),
	@sexo CHAR,
	@discriminador INT,
	@numero INT
)
AS
BEGIN 
	INSERT INTO [NN_NN].[AFILIADO]
		(apellido, nombre, cod_estado_Civil, cod_plan, codigo_documento, documento,
		telefono, direccion, fecha_nac, mail, sexo, numero_tipo_afiliado, numero)
	VALUES 
		(@apellido, @nombre, @estadoCivil, @plan, @tipo_documento, @documento,
		@telefono, @direccion, @fecha_nac, @mail, @sexo, @discriminador, @numero);
END
GO

/******************************************************
*                    ADD PROFESIONAL                  *
*******************************************************/
CREATE PROCEDURE NN_NN.SP_ADD_PROFESIONAL (
	@apellido varchar(255), 
	@nombre varchar(255), 
	@codigo_documento NUMERIC(18,0),
	@dni NUMERIC(18,0),
	@direccion varchar(255),
	@fecha_nac DATETIME,
	@telefono NUMERIC(18,0),
	@mail varchar(255),
	@sexo CHAR,
	@matricula NUMERIC(18,0)
)
AS
BEGIN
	DECLARE @ID NUMERIC(18,0);
	INSERT INTO NN_NN.PROFESIONAL (apellido, nombre, codigo_documento, dni, direccion, fecha_nac, telefono, mail, sexo, matricula)
	VALUES 
		(@nombre, @apellido, @codigo_documento, @dni, @direccion, @fecha_nac, @telefono, @mail, @sexo, @matricula)
	SET @ID = SCOPE_IDENTITY();
	return @ID;
END
GO
/******************************************************
*                    ADD ESPECIALIDAD TO PROFESIONAL  *
*******************************************************/
CREATE PROCEDURE NN_NN.SP_ADD_ESPECIALIDAD (
	@codigo int, 
	@cod_especialidad int
)
AS
BEGIN 
	INSERT INTO NN_NN.PROFESIONAL_ESPECIALIDAD(nro_profesional, cod_especialidad)
	VALUES 
		(@codigo, @cod_especialidad)
END
GO
/******************************************************
*                    AGENDA PROFESIONAL               *
*******************************************************/
CREATE PROCEDURE NN_NN.SP_ADD_AGENDA (
	@nro_profesional int, 
	@fecha_inicio VARCHAR(255),  
	@fecha_fin VARCHAR(255)
)
AS
BEGIN 
	DECLARE @AuxTable table( nro_agenda int);
	
	DECLARE @FECHA_F0 DATETIME;
	DECLARE @FECHA_F1 DATETIME;
	
	SELECT @FECHA_F0 = convert(datetime, @fecha_inicio, 120);
	SELECT @FECHA_F1 = convert(datetime, @fecha_fin, 120);
	
	
	INSERT  INTO NN_NN.AGENDA (nro_profesional, fecha_inicio, fecha_fin)
		OUTPUT INSERTED.numero INTO @AuxTable
	VALUES 
		(@nro_profesional, @FECHA_F0, @FECHA_F1)	
	DECLARE @nro int = (SELECT T.nro_agenda FROM @AuxTable T)
	RETURN @nro
END
GO

CREATE PROCEDURE NN_NN.SP_ADD_DIA_ATENCION (
	@nro_agenda int, 
	@codigo_dia int, 
	@hora_fin VARCHAR(255), 
	@hora_inicio VARCHAR(255)
)
AS
BEGIN 
	DECLARE @HORA_F0 DATETIME;
	DECLARE @HORA_F1 DATETIME;
	
	SELECT @HORA_F0 = convert(datetime, @hora_inicio, 120);
	SELECT @HORA_F1 = convert(datetime, @hora_fin, 120);
	
	INSERT INTO NN_NN.DIA_ATENCION (nro_agenda, codigo_dia, hora_fin, hora_inicio)
	VALUES (@nro_agenda, @codigo_dia, @HORA_F1, @HORA_F0)
END
GO
CREATE PROCEDURE [NN_NN].[sp_generar_agenda](
	@nro_agenda INT,
	@duracionTurno INT,
	@nro_profesional INT
)
AS
BEGIN  
  DECLARE @codigo_dia INT;
  DECLARE @rango INT;
  DECLARE @fecha_f0_agenda DATETIME;
  DECLARE @fecha_f1_agenda DATETIME;
  DECLARE @i INT
  
  SET @i = 0;
  
  SELECT @fecha_f0_agenda = fecha_inicio, @fecha_f1_agenda = fecha_fin FROM
	[NN_NN].[AGENDA]WHERE numero = @nro_agenda

  SET @rango = DATEDIFF(dd, @fecha_f0_agenda, @fecha_f1_agenda)
  WHILE (@i < @rango)
  BEGIN
 	DECLARE @fechaCurrent DATETIME;
	DECLARE @dayOfWeek INT;
	DECLARE @hora_fin DATETIME;
	DECLARE @hora_inicio DATETIME;
	
	SET @fechaCurrent = DATEADD (dy , @i, @fecha_f0_agenda);
	SET @dayOfWeek = DATEPART(dw , @fechaCurrent)
	SET @hora_fin = null;
	SET @hora_inicio = null;
	SELECT @hora_fin = hora_fin, @hora_inicio = hora_inicio FROM [NN_NN].[DIA_ATENCION] 
		WHERE nro_agenda = @nro_agenda AND codigo_dia = @dayOfWeek;
	
	if @hora_fin is not null
	BEGIN
	
		DECLARE @turnos INT;
		SET @turnos = DATEDIFF(mi, @hora_inicio, @hora_fin)
		DECLARE @j INT;
		SET @j = 0;
		-- A la @fechaCurrent tengo que agregarle la hora y los minutos del turno
		DECLARE @now DATETIME;
		-- Primero las horas
		SET @now = DATEADD (
			hh, 
			DATEPART(
				hh, 
				@hora_inicio
			), 
			@fechaCurrent
		);
		-- Segundo los minutos
		SET @now = DATEADD (
			mi, 
			DATEPART(
				mi, 
				@hora_inicio
			), 
			@now
		);
	
		WHILE @j < @turnos
		BEGIN
			DECLARE @numero INT;
			SELECT @numero = MAX(numero) + 1 FROM [NN_NN].[TURNO];
			
			INSERT INTO [NN_NN].[TURNO]([numero],
				[fecha],
				[nro_profesional],
				[nro_day]
			)
			VALUES (
				@numero,
				@now,
				@nro_profesional,
				@dayOfWeek
			)
			SET @now = DATEADD (mi , @duracionTurno, @now);
			SET @j += @duracionTurno;
		END
	END
	SET @i += 1;
  END
END 
GO
--
CREATE PROCEDURE NN_NN.SP_LISTAR_AGENDA_DIAS(
	@fecha VARCHAR(255),
	@nroProfesional INT
)
AS 
BEGIN
	SELECT CONVERT(DATE, c.fecha) AS fecha, c.nro_day AS DIA, 
		CASE (
			SELECT COUNT (*)
				FROM [NN_NN].[TURNO] AS P 
				WHERE P.nro_profesional = c.nro_profesional 
				AND CONVERT(DATE, p.fecha) = CONVERT(DATE, c.fecha) AND p.nro_afiliado is null
		) WHEN 0 THEN 'NO DISPONIBLE'
		ELSE 'DISPONIBLE' END AS ESTADO, 
		a.fecha_fin AS fechaFin, a.fecha_inicio AS fechaInicio
	FROM [NN_NN].[TURNO] AS c LEFT JOIN [NN_NN].[AGENDA] AS a 
		ON (CONVERT(DATE, c.fecha) BETWEEN (CONVERT(DATE, a.fecha_inicio)) AND (CONVERT(DATE, a.fecha_fin))) 
	WHERE c.nro_profesional = @nroProfesional AND CONVERT(DATE, c.fecha) >= CONVERT(DATE, @fecha,105)
	GROUP BY CONVERT(DATE, c.fecha), c.nro_profesional,[nro_day], a.fecha_fin, a.fecha_inicio
	ORDER BY CONVERT(DATE, c.fecha)
END
GO

/******************************************************
*                    TURNOS                           *
*******************************************************/
CREATE PROCEDURE [NN_NN].[SP_LISTA_TURNOS_LIBRE] (
	@nro_profesional INT,
	@fecha VARCHAR(255)
)
AS
BEGIN
	SELECT  T.fecha, T.nro_day, T.numero, CT.motivo
	FROM [NN_NN].[TURNO] AS T LEFT JOIN [NN_NN].[CANCELACION_TURNO] AS CT
		ON (T.numero = CT.nro_turno)
	WHERE CT.motivo IS NULL AND T.nro_tipo_afiliado IS NULL 
		AND T.nro_profesional = @nro_profesional 
		AND CONVERT(DATE, T.fecha) = CONVERT(DATE, @fecha, 105)
END
GO
CREATE PROCEDURE [NN_NN].[SP_RESERVAR_TURNO]
	@nro_afiliado INT,
	@nro_tipo_afiliado INT,
	@numero INT
AS
BEGIN
	UPDATE [NN_NN].[TURNO]
		SET [nro_afiliado] = @nro_afiliado,
			[nro_tipo_afiliado] = @nro_tipo_afiliado 
		WHERE numero = @numero;
END
GO
/******************************************************
*                    TURNOS                           *
*******************************************************/
CREATE PROCEDURE [NN_NN].[SP_LISTA_TURNOS_LIBRE] (
	@nro_profesional INT,
	@fecha VARCHAR(255)
)
AS
BEGIN
	SELECT  T.fecha, T.nro_day, T.numero, CT.motivo
	FROM [NN_NN].[TURNO] AS T LEFT JOIN [NN_NN].[CANCELACION_TURNO] AS CT
		ON (T.numero = CT.nro_turno)
	WHERE CT.motivo IS NULL AND T.nro_tipo_afiliado IS NULL 
		AND T.nro_profesional = @nro_profesional 
		AND CONVERT(DATE, T.fecha) = CONVERT(DATE, @fecha, 105)
END
GO
CREATE PROCEDURE [NN_NN].[SP_RESERVAR_TURNO]
	@nro_afiliado INT,
	@nro_tipo_afiliado INT,
	@numero INT
AS
BEGIN
	UPDATE [NN_NN].[TURNO]
		SET [nro_afiliado] = @nro_afiliado,
			[nro_tipo_afiliado] = @nro_tipo_afiliado 
		WHERE numero = @numero;
END
GO
/******************************************************
*                    BONOS                            *
*******************************************************/


CREATE PROCEDURE 
	NN_NN.SP_BUY_CANT_BONO_FARMACIA (@cant int, @nro_afiliado int, @nro_tipo_afiliado int) AS
BEGIN
	DECLARE @max_nro int = ( 
		SELECT 
			MAX(B.numero)
		FROM
			NN_NN.BONO_FARMACIA B
	)
	IF (@max_nro is null)
	begin
		set @max_nro = 0
	end 
	DECLARE @i int = 1
	WHILE @i <= @cant 
	BEGIN	
		--SET @max_nro = @max_nro + @i
		INSERT INTO 
			NN_NN.BONO_FARMACIA (numero, fecha_impresion, fecha_compra, nro_afiliado, nro_tipo_afiliado, fecha_vencimiento)
		VALUES 
			(@max_nro + @i, GETDATE(), GETDATE(), @nro_afiliado, @nro_tipo_afiliado, DATEADD(day, 60, GETDATE()))
		SET @i = @i + 1
	END
END
GO

CREATE PROCEDURE 
	NN_NN.SP_BUY_CANT_BONO_CONSULTA (@cant int, @nro_afiliado int, @nro_tipo_afiliado int) AS
BEGIN
	DECLARE @max_nro int = ( 
		SELECT 
			MAX(B.numero)
		FROM
			NN_NN.BONO_CONSULTA B
	)
	IF (@max_nro is null)
	begin
		set @max_nro = 0
	end 
	DECLARE @i int = 1
	WHILE @i <= @cant 
	BEGIN	
		INSERT INTO 
			NN_NN.BONO_CONSULTA (numero, fecha_impresion, fecha_compra, nro_afiliado, nro_tipo_afiliado)
		VALUES 
			(@max_nro + @i, GETDATE(), GETDATE(), @nro_afiliado, @nro_tipo_afiliado)
		SET @i = @i + 1
	END
END
GO

/******************************************************
*                    LOGIN                            *
*******************************************************/
CREATE PROCEDURE 
	NN_NN.SP_LOGIN (@username VARCHAR(255), @password VARCHAR(255)) AS
BEGIN
	SELECT TOP 1 
		U.ID, U.ID_AFILIADO, U.ID_AFILIADO_DISCRIMINADOR, U.ID_PROFESIONAL
	FROM 
		NN_NN.USUARIO U
    WHERE USER_NAME = @username AND PASSWORD = @password
END
GO

CREATE PROCEDURE 
	NN_NN.SP_ROLES (@id_usuario int) AS
BEGIN
	SELECT  
		R.ID, R.NOMBRE 
    FROM 
		NN_NN.USUARIO_ROL UR 
    JOIN 
		NN_NN.ROL R 
    ON 
		UR.ID_ROL = R.ID 
    WHERE 
		UR.ID_USUARIO = @id_usuario
END
GO
/******************************************************
*                    RECETA                           *
*******************************************************/
CREATE PROCEDURE 
	NN_NN.SP_CHEQUEAR_EXISTENCIA_BONO_FARMACIA (@nro_bono int) AS
BEGIN

	SELECT  
		B.numero
    FROM 
		NN_NN.BONO_FARMACIA B
    WHERE 
		B.numero = @nro_bono
END
GO



CREATE PROCEDURE 
	NN_NN.SP_CHEQUEAR_PERTENENCIA_BONO_FARMACIA (@nro_bono int, @nro_usuario int) AS
BEGIN

	SELECT  
		B.numero
    FROM 
		NN_NN.AFILIADO A
    JOIN 
		NN_NN.BONO_FARMACIA B
    ON 
		B.nro_afiliado = A.numero 
    WHERE 
		B.numero = @nro_bono
END
GO

CREATE PROCEDURE 
	NN_NN.SP_CHEQUEAR_VENCIMIENTO_BONO_FARMACIA (@nro_bono int) AS
BEGIN
	SELECT  
		B.numero
    FROM 
		NN_NN.BONO_FARMACIA B
    WHERE 
		B.numero = @nro_bono 
	AND
		B.fecha_vencimiento < GETDATE ()		
END



/******************************************************
*                    AGENDA                           *
*******************************************************/
