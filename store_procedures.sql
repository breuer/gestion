/******************************************************
*                    STORE PROCEDURES                 *
*******************************************************/
use [GD2C2013]
GO
-----------------------------------------------------------------
-- PROCEDURE ROL
-----------------------------------------------------------------
CREATE PROCEDURE NN_NN.sp_login
	@userName VARCHAR(255),
	@passWordHash VARCHAR(255)
AS
BEGIN
	DECLARE @passHashPersistido VARCHAR(255),
			@id INT,
			@cantFail INT,
			@habilitado bit,
			@errorMsg varchar(max)

	SELECT @passHashPersistido = USUARIO.PASSWORD, @id =  USUARIO.ID, @cantFail  = USUARIO.INTENTOS_FALLIDOS,
			@habilitado = USUARIO.HABILITADO
		FROM [NN_NN].USUARIO AS USUARIO
			WHERE USUARIO.USER_NAME = @userName AND USUARIO.HABILITADO = '1'
	IF(@id IS NULL OR @id = 0)
		BEGIN	
			--NO EXISTE EL USUARIO
			SET @errorMsg = 'NO EXISTE EL USUARIO: ' + @userName
			RAISERROR (@errorMsg, 16, 2)
		END
	ELSE IF(@passWordHash = @passHashPersistido AND @cantFail >= 3)
		BEGIN
			--PASSWORD Y USERNAME OK PERO FALLO 3 O MAS VECES
			SET @errorMsg = 'USUARIO BLOQUEADO: ' + @userName + ' COMUNIQUESE CON EL ADMINISTRADOR';
			RAISERROR (@errorMsg, 16, 2)
		END
	ELSE IF(@passWordHash != @passHashPersistido) 
		BEGIN
			-- PASSWORD INCORRETO
			UPDATE [NN_NN].USUARIO SET INTENTOS_FALLIDOS = @cantFail + 1
				WHERE ID = @ID
			DECLARE @restan INT;
			SET @restan = 3 - @cantFail + 1;
			IF (@restan = 0)
			BEGIN
				SET @errorMsg = 'PASSWORD INCORRECTO. A LOS 3 FALLOS EL USUARIO SERA BLOQUEADO.'
				SET @errorMsg += ' RESTAN ' + CONVERT(VARCHAR, @restan) + ' INTENTOS. SU CUAENTA A SIDO BLOQUEDA COMUNIQUESE CON EL ADMINITRADOR';
			END
			ELSE
			BEGIN
				SET @errorMsg = 'PASSWORD INCORRECTO. A LOS 3 FALLOS EL USUARIO SERA BLOQUEADO.'
				SET @errorMsg += ' RESTAN ' + CONVERT(VARCHAR, @restan) + ' INTENTOS. ';
			END
			
			RAISERROR (@errorMsg, 16, 2)
		END
	ELSE IF(@habilitado = 0)
		BEGIN
			SET @errorMsg = 'EL USUARIO NO ESTA HABILITADO'
			RAISERROR (@errorMsg, 16, 2)
		END
	ELSE
		BEGIN
			UPDATE [NN_NN].USUARIO SET INTENTOS_FALLIDOS = 0
				WHERE ID = @ID
			SELECT TOP 1  U.ID, U.ID_AFILIADO, U.ID_AFILIADO_DISCRIMINADOR, U.ID_PROFESIONAL
				FROM NN_NN.USUARIO U WHERE U.ID = @ID
		END
		
END
GO
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
	Select @chvQuery = 'SELECT numero, apellido, nombre, matricula, fecha_nac, habilitado ',
		@chvWhere = ''
	set @chvQuery += 'FROM [NN_NN].[PROFESIONAL] ';
	
	If (@apellido is not null AND @apellido != '') 
		Set @chvWhere = @chvWhere + ' apellido LIKE ''%' + @apellido + '%'' AND'
	If (@nombre is not null AND @nombre != '') 
		Set @chvWhere = @chvWhere + ' nombre LIKE ''%' + @nombre + '%'' AND'
	If (@matricula > 0)
		Set @chvWhere = @chvWhere + ' matricula = '+ CONVERT (VARCHAR, @matricula) +' AND'
	PRINT @chvWhere
	Set @chvWhere = @chvWhere + ' habilitado = '+ CONVERT (VARCHAR, @enable) +' AND'
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
	@fecha VARCHAR(255) = null,
	@email VARCHAR(255),
	@sexo CHAR,
	@discriminador INT = 0,
	@numero INT
)
AS
BEGIN 
	INSERT INTO [NN_NN].[AFILIADO]
		(apellido, nombre, cod_estado_Civil, cod_plan, codigo_documento, documento,
		telefono, direccion, fecha_nac, mail, sexo, numero_tipo_afiliado, numero)
	VALUES 
		(@apellido, @nombre, @estadoCivil, @plan, @tipoDocumento, @documento,
		@telefono, @direccion, @fecha, @email, @sexo, @discriminador, @numero);
END
GO
CREATE PROCEDURE [NN_NN].[sp_listar_afiliado](
	@apellido VARCHAR(255) = NULL,
	@nombre VARCHAR(255) = NULL,
	@plan INT = 0,
	@tipo INT = 0,
	@documento INT = 0,
	@numero INT = 0,
	@discriminador INT = 0,
	@enable CHAR = '1'
)
AS 
BEGIN
	SET NOCOUNT ON
	
	Declare @chvQuery nvarchar(max), 
			@chvWhere nvarchar(max), 
			@chvSubQuery nvarchar(max),
			@chvSubWhere nvarchar(max);
	Select @chvQuery = 'SELECT A.numero As numero, A.numero_tipo_afiliado As discriminador, A.apellido As apellido, ',
		@chvWhere = ''
	set @chvQuery += 'A.nombre AS nombre, TD.descripcion As tipoDocumento, A.documento As documento, ';
	set @chvQuery += 'A.direccion As direccion, EC.descripcion As estadoCivil, A.fecha_nac, A.telefono, A.mail, A.cantidad_hijos, ';
	set @chvQuery += 'A.fecha_baja, PM.descripcion, A.habilitado ';
	set @chvQuery += 'FROM [NN_NN].[AFILIADO] AS A ';
	set @chvQuery += 'LEFT JOIN [NN_NN].[TIPO_DOCUMENTO] AS TD ON (A.codigo_documento = TD.codigo) ';
	set @chvQuery += 'LEFT JOIN [NN_NN].[ESTADO_CIVIL] AS EC ON (A.cod_estado_civil = EC.codigo) ';
	set @chvQuery += 'LEFT JOIN [NN_NN].[PLAN_MEDICO] AS PM ON (A.cod_plan = PM.codigo) ';
	
	
	If (@apellido is not null AND @apellido != '') 
		Set @chvWhere = @chvWhere + ' A.apellido LIKE ''%' + @apellido + '%'' AND'
	If (@nombre is not null AND @nombre != '') 
		Set @chvWhere = @chvWhere + ' A.nombre LIKE ''%' + @nombre + '%'' AND'
	If (@plan > 0)
		Set @chvWhere = @chvWhere + ' A.cod_plan = '+ CONVERT (VARCHAR, @plan) +' AND'
	If (@tipo  > 0)
		Set @chvWhere = @chvWhere + ' A.codigo_documento = '+ CONVERT (VARCHAR, @tipo) +' AND'
	If (@documento  > 0)
		Set @chvWhere = @chvWhere + ' A.documento = '+ CONVERT (VARCHAR, @documento) +' AND'
	If (@numero  > 0)
		Set @chvWhere = @chvWhere + ' A.numero = '+ CONVERT (VARCHAR, @numero) +' AND'
	If (@discriminador  > 0)
		Set @chvWhere = @chvWhere + ' A.numero_tipo_afiliado = '+ CONVERT (VARCHAR, @discriminador) +' AND'
	

	Set @chvWhere = @chvWhere + ' A.habilitado = ' + @enable +' AND'
	
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

CREATE PROCEDURE NN_NN.SP_RETURN_AFILIADO (
	@discriminador INT = 0,
	@numero INT
)
AS
BEGIN 
	SELECT apellido, nombre, cod_estado_Civil, cod_plan, codigo_documento, documento,
		telefono, direccion, fecha_nac, mail, sexo, numero_tipo_afiliado, numero
	FROM [NN_NN].[AFILIADO]
		WHERE numero_tipo_afiliado = @discriminador AND numero= @numero AND habilitado = '1'; 
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

CREATE PROCEDURE NN_NN.SP_RETURN_PROFESIONAL (
	@numero NUMERIC(18,0)
)
AS
BEGIN
	SELECT apellido, nombre, codigo_documento, dni, direccion, fecha_nac, telefono, mail, sexo, matricula, numero
		FROM [NN_NN].[PROFESIONAL]
		WHERE numero = @numero AND habilitado = '1';
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
	VALUES (@nro_profesional, @FECHA_F0, @FECHA_F1)	
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
	@nroProfesional DECIMAL(18,0)

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

CREATE PROCEDURE [NN_NN].[SP_RESERVAR_TURNO]
	@nro_afiliado INT,
	@nro_tipo_afiliado INT,
	@numero INT
AS
BEGIN
	SELECT numero, fecha_fin AS fechaFin, fecha_inicio AS fechaInicio
		FROM [NN_NN].[AGENDA] 
		WHERE nro_profesional = @nroProfesional AND habilitado = '1'
		ORDER BY fechaFin DESC;
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
	@nro_afiliado DECIMAL(18,0),
	@nro_tipo_afiliado DECIMAL(18,0),
	@numero DECIMAL(18,0)
AS
BEGIN
	UPDATE [NN_NN].[TURNO]
		SET [nro_afiliado] = @nro_afiliado,
			[nro_tipo_afiliado] = @nro_tipo_afiliado 
		WHERE numero = @numero;
END
GO
CREATE PROCEDURE [NN_NN].[SP_MIS_TURNOS_AFILIADO] (
	@nroTipoAfiliado DECIMAL(18,0)= 0,
	@nroAfiliado DECIMAL(18,0),
	@dateF0 VARCHAR(255) = null,
	@dateF1 VARCHAR(255) = null,
	@dateNow VARCHAR(255)
)
AS
BEGIN
	DECLARE  @fechaNOW DATETIME;
	SELECT @fechaNOW = convert(datetime, @hora_inicio, 120);
	-- Si no tiene fecha de llega quiere decir que todabia no se ha cumplido el Turno
	-- Si tiene fecha de llegada es que el turno ya se uso.
	-- Si tiene cancelacion es que se cancelo
	-- Si no tiene fecha de llegada y la fecha del turno es menos a la del presente se muestra como Perdido.
	-- Si no tiene fecha de llegada y la fecha del turno es menos a 24 hs no se puede cancelar

	IF @dateF0 is null || @dateF1 is null
	BEGIN
		SELECT T.numero, T.fecha, T.fecha_llegada, D.descripcion, P.apellido, P.nombre, CT.motivo
			FROM [NN_NN].[TURNO] AS T LEFT JOIN [NN_NN].[DIA] AS D ON (T.nro_day = D.codigo)
				LEFT JOIN [NN_NN].[CANCELACION_TURNO] AS CT ON (T.numero = CT.nro_turno)
				LEFT JOIN [NN_NN].[PROFESIONAL] AS P ON (T.nro_profesional = P.numero)
			WHERE T.nro_tipo_afiliado = @nroTipoAfiliado AND t.nro_afiliado = @nroAfiliado
			AND fecha <= @fechaNOW
			ORDER BY fecha DESC
	END
	ELSE
	BEGIN
		DECLARE @fecha0 DATETIME,
				@fecha1 DATETIME
			
		SELECT @fecha0 = convert(datetime, @hora_inicio, 120);
		SELECT @fecha1 = convert(datetime, @hora_fin, 120);	
		
		SELECT T.numero, T.fecha, T.fecha_llegada, D.descripcion, P.apellido, P.nombre, CT.motivo
			FROM [NN_NN].[TURNO] AS T LEFT JOIN [NN_NN].[DIA] AS D ON (T.nro_day = D.codigo)
				LEFT JOIN [NN_NN].[CANCELACION_TURNO] AS CT ON (T.numero = CT.nro_turno)
				LEFT JOIN [NN_NN].[PROFESIONAL] AS P ON (T.nro_profesional = P.numero)
				WHERE T.nro_tipo_afiliado = @nroTipoAfiliado AND t.nro_afiliado = @nroAfiliado
					AND fecha <= @fechaNOW
					AND T.fecha BETWEEN @fecha0 AND @fecha1
					ORDER BY fecha DESC
	END			
END
GO
CREATE PROCEDURE [NN_NN].[SP_MIS_TURNOS_AFILIADO_CANCELADOS] (
	@nroTipoAfiliado DECIMAL(18,0)= 0,
	@nroAfiliado DECIMAL(18,0),
	@dateF0 VARCHAR(255) = null,
	@dateF1 VARCHAR(255) = null
	@dateNow VARCHAR(255)
)
AS
BEGIN
	-- Si no tiene fecha de llega quiere decir que todabia no se ha cumplido el Turno
	-- Si tiene fecha de llegada es que el turno ya se uso.
	-- Si tiene cancelacion es que se cancelo
	-- Si no tiene fecha de llegada y la fecha del turno es menos a la del presente se muestra como Perdido.
	-- Si no tiene fecha de llegada y la fecha del turno es menos a 24 hs no se puede cancelar
	DECLARE  @fechaNOW DATETIME;
	SELECT @fechaNOW = convert(datetime, @hora_inicio, 120);
	
	IF @dateF0 is null || @dateF1 is null
	BEGIN
		SELECT T.numero, T.fecha, T.fecha_llegada, D.descripcion, P.apellido, P.nombre, CT.motivo
			FROM [NN_NN].[TURNO] AS T LEFT JOIN [NN_NN].[DIA] AS D ON (T.nro_day = D.codigo)
				LEFT JOIN [NN_NN].[CANCELACION_TURNO] AS CT ON (T.numero = CT.nro_turno)
				LEFT JOIN [NN_NN].[PROFESIONAL] AS P ON (T.nro_profesional = P.numero)
				WHERE T.nro_tipo_afiliado = @nroTipoAfiliado AND t.nro_afiliado = @nroAfiliado
					AND CT.nro_turno IS NOT NULL AND fecha <= @fechaNOW
					ORDER BY fecha DESC
	END
	ELSE
	BEGIN
		DECLARE @fecha0 DATETIME,
				@fecha1 DATETIME
			
		SELECT @fecha0 = convert(datetime, @hora_inicio, 120);
		SELECT @fecha1 = convert(datetime, @hora_fin, 120);	
		
		SELECT T.numero, T.fecha, T.fecha_llegada, D.descripcion, P.apellido, P.nombre, CT.motivo
			FROM [NN_NN].[TURNO] AS T LEFT JOIN [NN_NN].[DIA] AS D ON (T.nro_day = D.codigo)
				LEFT JOIN [NN_NN].[CANCELACION_TURNO] AS CT ON (T.numero = CT.nro_turno)
				LEFT JOIN [NN_NN].[PROFESIONAL] AS P ON (T.nro_profesional = P.numero)
				WHERE T.nro_tipo_afiliado = @nroTipoAfiliado AND t.nro_afiliado = @nroAfiliado
					AND fecha <= @fechaNOW
					AND CT.nro_turno IS NOT NULL AND @fecha BETWEEN @fecha0 AND @fecha1 
					ORDER BY fecha DESC
	END
END
GO
CREATE PROCEDURE [NN_NN].[SP_MIS_TURNOS_AFILIADO_ASISTIDOS] (
	@nroTipoAfiliado DECIMAL(18,0)= 0,
	@nroAfiliado DECIMAL(18,0),
	@dateF0 VARCHAR(255) = null,
	@dateF1 VARCHAR(255) = null
	@dateNow VARCHAR(255)
)
AS
BEGIN
	-- Si no tiene fecha de llega quiere decir que todabia no se ha cumplido el Turno
	-- Si tiene fecha de llegada es que el turno ya se uso.
	-- Si tiene cancelacion es que se cancelo
	-- Si no tiene fecha de llegada y la fecha del turno es menos a la del presente se muestra como Perdido.
	-- Si no tiene fecha de llegada y la fecha del turno es menos a 24 hs no se puede cancelar
	DECLARE  @fechaNOW DATETIME;
	SELECT @fechaNOW = convert(datetime, @hora_inicio, 120);
	IF @dateF0 is null || @dateF1 is null
	BEGIN
		SELECT T.numero, T.fecha, T.fecha_llegada, D.descripcion, P.apellido, P.nombre, CT.motivo
			FROM [NN_NN].[TURNO] AS T LEFT JOIN [NN_NN].[DIA] AS D ON (T.nro_day = D.codigo)
			LEFT JOIN [NN_NN].[CANCELACION_TURNO] AS CT ON (T.numero = CT.nro_turno)
			LEFT JOIN [NN_NN].[PROFESIONAL] AS P ON (T.nro_profesional = P.numero)
				WHERE T.nro_tipo_afiliado = @nroTipoAfiliado AND t.nro_afiliado = @nroAfiliado
				AND CT.nro_turno IS NULL AND t.fecha_llegada IS NOT NULL AND fecha <= @fechaNOW
				ORDER BY fecha DESC
	END
	ELSE
	BEGIN
		DECLARE @fecha0 DATETIME,
				@fecha1 DATETIME
			
		SELECT @fecha0 = convert(datetime, @hora_inicio, 120);
		SELECT @fecha1 = convert(datetime, @hora_fin, 120);	
		
		SELECT T.numero, T.fecha, T.fecha_llegada, D.descripcion, P.apellido, P.nombre, CT.motivo
			FROM [NN_NN].[TURNO] AS T LEFT JOIN [NN_NN].[DIA] AS D ON (T.nro_day = D.codigo)
			LEFT JOIN [NN_NN].[CANCELACION_TURNO] AS CT ON (T.numero = CT.nro_turno)
			LEFT JOIN [NN_NN].[PROFESIONAL] AS P ON (T.nro_profesional = P.numero)
				WHERE T.nro_tipo_afiliado = @nroTipoAfiliado AND t.nro_afiliado = @nroAfiliado
				AND CT.nro_turno IS NULL AND t.fecha_llegada IS NOT NULL AND fecha <= @fechaNOW
				AND @fecha BETWEEN @fecha0 AND @fecha1
				ORDER BY fecha DESC
	END			
END
GO
CREATE PROCEDURE [NN_NN].[SP_MIS_TURNOS_AFILIADO_FUTUROS] (
	@nroTipoAfiliado DECIMAL(18,0)= 0,
	@nroAfiliado DECIMAL(18,0),
	@fecha VARCHAR(255),
	@dateF0 VARCHAR(255) = null,
	@dateF1 VARCHAR(255) = null
	@dateNow VARCHAR(255)
)
AS
BEGIN
	-- Si no tiene fecha de llega quiere decir que todabia no se ha cumplido el Turno
	-- Si tiene fecha de llegada es que el turno ya se uso.
	-- Si tiene cancelacion es que se cancelo
	-- Si no tiene fecha de llegada y la fecha del turno es menos a la del presente se muestra como Perdido.
	-- Si no tiene fecha de llegada y la fecha del turno es menos a 24 hs no se puede cancelar
	DECLARE  @fechaNOW DATETIME;
	SELECT @fechaNOW = convert(datetime, @hora_inicio, 120);
	IF @dateF0 is null || @dateF1 is null
	BEGIN
		SELECT T.numero, T.fecha, T.fecha_llegada, D.descripcion, P.apellido, P.nombre, CT.motivo
			FROM [NN_NN].[TURNO] AS T LEFT JOIN [NN_NN].[DIA] AS D ON (T.nro_day = D.codigo)
			LEFT JOIN [NN_NN].[CANCELACION_TURNO] AS CT ON (T.numero = CT.nro_turno)
			LEFT JOIN [NN_NN].[PROFESIONAL] AS P ON (T.nro_profesional = P.numero)
				WHERE T.nro_tipo_afiliado = @nroTipoAfiliado AND t.nro_afiliado = @nroAfiliado
				AND CT.nro_turno IS NULL AND t.fecha_llegada IS NULL AND fecha > @fechaNOW
				ORDER BY fecha ASC
	END
	ELSE
	BEGIN
		DECLARE @fecha0 DATETIME,
				@fecha1 DATETIME
			
		SELECT @fecha0 = convert(datetime, @hora_inicio, 120);
		SELECT @fecha1 = convert(datetime, @hora_fin, 120);	
		SELECT T.numero, T.fecha, T.fecha_llegada, D.descripcion, P.apellido, P.nombre, CT.motivo
			FROM [NN_NN].[TURNO] AS T LEFT JOIN [NN_NN].[DIA] AS D ON (T.nro_day = D.codigo)
			LEFT JOIN [NN_NN].[CANCELACION_TURNO] AS CT ON (T.numero = CT.nro_turno)
			LEFT JOIN [NN_NN].[PROFESIONAL] AS P ON (T.nro_profesional = P.numero)
				WHERE T.nro_tipo_afiliado = @nroTipoAfiliado AND t.nro_afiliado = @nroAfiliado
				AND CT.nro_turno IS NULL AND t.fecha_llegada IS NULL AND fecha > @fechaNOW
				AND fecha BETWEEN @fecha0 AND @fecha1
				ORDER BY fecha ASC			
	END			
END
GO
CREATE PROCEDURE [NN_NN].[SP_MIS_TURNOS_AFILIADO_PERDIDOS] (
	@nroTipoAfiliado DECIMAL(18,0)= 0,
	@nroAfiliado DECIMAL(18,0),
	@fecha VARCHAR(255),
	@dateF0 VARCHAR(255) = null,
	@dateF1 VARCHAR(255) = null
	@dateNow VARCHAR(255)
)
AS
BEGIN
	-- Si no tiene fecha de llega quiere decir que todabia no se ha cumplido el Turno
	-- Si tiene fecha de llegada es que el turno ya se uso.
	-- Si tiene cancelacion es que se cancelo
	-- Si no tiene fecha de llegada y la fecha del turno es menos a la del presente se muestra como Perdido.
	-- Si no tiene fecha de llegada y la fecha del turno es menos a 24 hs no se puede cancelar
	DECLARE  @fechaNOW DATETIME;
	SELECT @fechaNOW = convert(datetime, @hora_inicio, 120);
	IF @dateF0 is null || @dateF1 is null
	BEGIN
		SELECT T.numero, T.fecha, T.fecha_llegada, D.descripcion, P.apellido, P.nombre, CT.motivo
			FROM [NN_NN].[TURNO] AS T LEFT JOIN [NN_NN].[DIA] AS D ON (T.nro_day = D.codigo)
			LEFT JOIN [NN_NN].[CANCELACION_TURNO] AS CT ON (T.numero = CT.nro_turno)
			LEFT JOIN [NN_NN].[PROFESIONAL] AS P ON (T.nro_profesional = P.numero)
				WHERE T.nro_tipo_afiliado = @nroTipoAfiliado AND t.nro_afiliado = @nroAfiliado
				AND CT.nro_turno IS NULL AND t.fecha_llegada IS NULL AND fecha < @fechaNOW
				ORDER BY fecha DESC
	END
	ELSE
	BEGIN
		DECLARE @fecha0 DATETIME,
				@fecha1 DATETIME
			
		SELECT @fecha0 = convert(datetime, @hora_inicio, 120);
		SELECT @fecha1 = convert(datetime, @hora_fin, 120);	
		SELECT T.numero, T.fecha, T.fecha_llegada, D.descripcion, P.apellido, P.nombre, CT.motivo
			FROM [NN_NN].[TURNO] AS T LEFT JOIN [NN_NN].[DIA] AS D ON (T.nro_day = D.codigo)
			LEFT JOIN [NN_NN].[CANCELACION_TURNO] AS CT ON (T.numero = CT.nro_turno)
			LEFT JOIN [NN_NN].[PROFESIONAL] AS P ON (T.nro_profesional = P.numero)
				WHERE T.nro_tipo_afiliado = @nroTipoAfiliado AND t.nro_afiliado = @nroAfiliado
				AND CT.nro_turno IS NULL AND t.fecha_llegada IS NULL AND fecha < @fechaNOW
				AND fecha BETWEEN @fecha0 AND @fecha1
				ORDER BY fecha DESC			
	END			
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
	NN_NN.SP_CHEQUEAR_VENCIMIENTO_BONO_FARMACIA (@nro_bono int, @fecha datetime) AS
BEGIN
	SELECT  
		B.numero
    FROM 
		NN_NN.BONO_FARMACIA B
    WHERE 
		B.numero = @nro_bono 
	AND
		--B.fecha_vencimiento < GETDATE ()		
		B.fecha_vencimiento < @fecha
END
GO

CREATE PROCEDURE 
	NN_NN.SP_CHEQUEAR_USO_BONO_FARMACIA (@nro_bono int) AS
BEGIN
	SELECT  
		RB.nro_bono_farmacia		
    FROM 
		NN_NN.RECETA_BONO_FARMACIA RB
    WHERE 
		RB.nro_bono_farmacia = @nro_bono 
END
GO

CREATE PROCEDURE 
	NN_NN.SP_ADD_MEDICAMENTO (@nro_bono int, @descripcion VARCHAR(255), @cantidad int) AS
BEGIN
	INSERT INTO 
		NN_NN.MEDICAMENTO (nro_bono_farmacia, descripcion, cantidad)
	VALUES
		(@nro_bono, @descripcion, @cantidad)
END
GO

CREATE PROCEDURE 
	NN_NN.SP_GENERAR_RECETA (@nro_consulta int) AS
BEGIN
	DECLARE @ID NUMERIC(18,0)
	INSERT INTO 
		NN_NN.RECETA (nro_consulta)
	VALUES
		(@nro_consulta)
	SET @ID = SCOPE_IDENTITY()
	RETURN @ID
END
GO

CREATE PROCEDURE 
	NN_NN.SP_ADD_BONO_FARMACIA_IN_RECETA (@nro_receta int, @nro_bono int) AS
BEGIN
	INSERT INTO 
		NN_NN.RECETA_BONO_FARMACIA(nro_receta, nro_bono_farmacia)
	VALUES
		(@nro_receta, @nro_bono)
END
GO

/******************************************************
*                    REGISTRO LLEGADA                 *
*******************************************************/

CREATE PROCEDURE NN_NN.SP_LISTA_TURNOS_PROFESIONAL (
	@nro_profesional INT,
	@fecha datetime
)
AS
BEGIN
	SELECT  
		T.fecha fecha,
		T.numero nroTurno, 
		A.numero nroAfiliado, 
		A.numero_tipo_afiliado nroTipoAfiliado,
		A.apellido apellidoAfiliado,
		A.nombre nombreAfiliado,
		CT.motivo motivoCancelacion,
		C.numero nroConsulta
	FROM 
		NN_NN.TURNO AS T 
	LEFT JOIN 
		NN_NN.CANCELACION_TURNO AS CT	
	ON
		T.numero = CT.nro_turno
	LEFT JOIN 
		NN_NN.CONSULTA AS C
	ON
		C.nro_turno = T.numero
	JOIN 
		[NN_NN].[AFILIADO] AS A	
	ON 
		A.numero = T.nro_afiliado
	AND
		A.numero_tipo_afiliado = T.nro_tipo_afiliado
	WHERE 
		CT.motivo IS NULL 
	AND		
		C.numero IS NULL 	
	AND 
		DATEPART(YEAR, t.fecha) = DATEPART(YEAR, @fecha)
	AND
		DATEPART(MONTH, t.fecha) = DATEPART(MONTH, @fecha)
	AND
		DATEPART(DAY, t.fecha) = DATEPART(DAY, @fecha)
	AND 
		T.nro_profesional = @nro_profesional 
	ORDER BY
		T.fecha
		
END
GO

CREATE PROCEDURE NN_NN.SP_LISTA_TURNOS_AFILIADO (
	@nro_afiliado INT,
	@nro_tipo_afiliado INT,
	@fecha datetime
)
AS
BEGIN
	SELECT  
		T.fecha fecha,
		T.numero nroTurno, 
		P.apellido apellidoProfesional,
		P.nombre nombreProfesional,
		CT.motivo,
		C.numero	
	FROM 
		NN_NN.TURNO AS T 
	LEFT JOIN 
		NN_NN.CANCELACION_TURNO AS CT	
	ON
		T.numero = CT.nro_turno
	LEFT JOIN 
		NN_NN.CONSULTA AS C
	ON
		C.nro_turno = T.numero
	JOIN 
		[NN_NN].[AFILIADO] AS A	
	ON 
		A.numero = T.nro_afiliado
	AND
		A.numero_tipo_afiliado = T.nro_tipo_afiliado
	JOIN 
		NN_NN.PROFESIONAL P
	ON
		P.numero = T.nro_profesional
	WHERE 
		CT.motivo IS NULL 
	AND		
		C.numero IS NULL 
	AND 
		DATEPART(YEAR, t.fecha) = DATEPART(YEAR, @fecha)
	AND
		DATEPART(MONTH, t.fecha) = DATEPART(MONTH, @fecha)
	AND
		DATEPART(DAY, t.fecha) = DATEPART(DAY, @fecha)
	AND
		T.nro_afiliado = @nro_afiliado
	AND
		T.nro_tipo_afiliado = @nro_tipo_afiliado
	ORDER BY
		T.fecha
		
END
GO

CREATE PROCEDURE NN_NN.SP_LISTA_TURNOS_AFILIADO_PROFESIONAL (
	@nro_afiliado INT,
	@nro_tipo_afiliado INT,
	@nro_profesional INT,
	@fecha datetime
)
AS
BEGIN
	SELECT  
		T.fecha fecha,
		T.numero nroTurno, 
		A.numero nroAfiliado, 
		A.numero_tipo_afiliado nroTipoAfiliado,
		A.apellido apellidoAfiliado,
		A.nombre nombreAfiliado,	
		CT.motivo motivoCancelacion,
		C.numero nroConsulta
	FROM 
		NN_NN.TURNO AS T 
	LEFT JOIN 
		NN_NN.CANCELACION_TURNO AS CT	
	ON
		T.numero = CT.nro_turno
	LEFT JOIN 
		NN_NN.CONSULTA AS C
	ON
		C.nro_turno = T.numero
	JOIN 
		[NN_NN].[AFILIADO] AS A	
	ON 
		A.numero = T.nro_afiliado
	AND
		A.numero_tipo_afiliado = T.nro_tipo_afiliado
	JOIN 
		NN_NN.PROFESIONAL P
	ON
		P.numero = T.nro_profesional
	WHERE 
		CT.motivo IS NULL 
	AND		
		C.numero IS NULL 
	AND 
		DATEPART(YEAR, t.fecha) = DATEPART(YEAR, @fecha)
	AND
		DATEPART(MONTH, t.fecha) = DATEPART(MONTH, @fecha)
	AND
		DATEPART(DAY, t.fecha) = DATEPART(DAY, @fecha)
	AND
		T.nro_afiliado = @nro_afiliado
	AND
		T.nro_tipo_afiliado = @nro_tipo_afiliado
	AND
		T.nro_profesional = @nro_profesional
	ORDER BY
		T.fecha
		
END
GO

CREATE PROCEDURE NN_NN.CHEQUEAR_HORARIO (
	@nro_turno INT,
	@fecha datetime
)
AS
BEGIN
	SELECT  
		T.numero 
	FROM 
		[NN_NN].[TURNO] T 	
	WHERE
		t.numero = @nro_turno
	AND 		
		DATEPART(YEAR, t.fecha) = DATEPART(YEAR, @fecha)
	AND
		DATEPART(MONTH, t.fecha) = DATEPART(MONTH, @fecha)
	AND
		DATEPART(DAY, t.fecha) = DATEPART(DAY, @fecha)
	AND
		@fecha <= T.fecha		
END
GO

CREATE PROCEDURE NN_NN.REGISTRAR_LLEGADA_A_TURNO (
	@nro_turno INT,
	@fecha datetime
)
AS
BEGIN
	UPDATE
		NN_NN.TURNO 
	SET
		fecha_llegada = @fecha
END
GO

--INSERT INTO NN_NN.USUARIO_ROL (ID_USUARIO, ID_ROL) VALUES(1,1);

CREATE PROCEDURE NN_NN.SP_GENERAR_CONSULTA (
	@nro_turno INT,
	@nro_bono_consulta int
)
AS
BEGIN
	DECLARE @ID NUMERIC(18,0)
	INSERT INTO 
		NN_NN.CONSULTA (nro_turno, nro_bono_consulta, consulta_abierta)
	VALUES
		(@nro_turno, @nro_bono_consulta, 1)
	SET @ID = SCOPE_IDENTITY()
	RETURN @ID
END
GO

CREATE PROCEDURE 
	NN_NN.SP_CHEQUEAR_USO_BONO_CONSULTA (@nro_bono int) AS
BEGIN
	SELECT  
		C.nro_bono_consulta		
    FROM 
		NN_NN.CONSULTA C
    WHERE 
		C.nro_bono_consulta = @nro_bono 
END
GO

CREATE PROCEDURE 
	NN_NN.SP_CHEQUEAR_PERTENENCIA_BONO_CONSULTA (@nro_bono int, @nro_usuario int) AS
BEGIN

	SELECT  
		B.numero
    FROM 
		NN_NN.AFILIADO A
    JOIN 
		NN_NN.BONO_CONSULTA B
    ON 
		B.nro_afiliado = A.numero 
    WHERE 
		B.numero = @nro_bono
END
GO
/******************************************************
*                    CONSULTA                         *
*******************************************************/
CREATE PROCEDURE 
	NN_NN.SP_CONSULTAS_PENDIENTES (@nro_profesional int, @fecha datetime) AS
BEGIN

	SELECT  
		C.numero nro_consulta,
		C.nro_turno nro_turno,
		A.numero nro_afiliado,
		A.apellido apellido_afiliado,
		A.nombre nombre_afiliado
    FROM 
		NN_NN.TURNO T
    JOIN 
		NN_NN.CONSULTA C
    ON 
		T.numero = C.nro_turno
    JOIN 
		NN_NN.PROFESIONAL P
    ON 
		P.numero = T.nro_profesional
	JOIN
		NN_NN.AFILIADO A
	ON
		A.numero = T.nro_afiliado
	AND
		A.numero_tipo_afiliado = T.nro_tipo_afiliado
    WHERE 
		T.fecha_llegada is not null
	AND
		P.numero = @nro_profesional
	AND
		DATEPART(YEAR, t.fecha) = DATEPART(YEAR, @fecha)
	AND
		DATEPART(MONTH, t.fecha) = DATEPART(MONTH, @fecha)
	AND
		DATEPART(DAY, t.fecha) = DATEPART(DAY, @fecha)	
	ORDER BY
		T.fecha
END
GO


/******************************************************
*                    UTILS                            *
*******************************************************/
CREATE PROCEDURE 
	NN_NN.SP_GET_USER_BY_TURNO (@nro_turno int) AS
BEGIN

	SELECT TOP 1
		A.numero nroAfiliado,
		A.numero_tipo_afiliado nroTipoAfiliado
    FROM 
		NN_NN.AFILIADO A
    JOIN 
		NN_NN.TURNO T
    ON 
		T.nro_afiliado = A.numero 
	AND
		T.nro_tipo_afiliado = A.numero_tipo_afiliado
    WHERE 
		T.numero = @nro_turno
END
GO

CREATE PROCEDURE 
	NN_NN.SP_GET_BONO_CONSULTA_BY_NRO (@nro_bono int) AS
BEGIN
	SELECT TOP 1
		B.numero
    FROM 
		NN_NN.BONO_CONSULTA B
    WHERE 
		B.numero = @nro_bono
END
GO

CREATE PROCEDURE 
	NN_NN.SP_GET_BONO_FARMACIA_BY_NRO (@nro_bono int) AS
BEGIN
	SELECT TOP 1
		B.numero
    FROM 
		NN_NN.BONO_FARMACIA B
    WHERE 
		B.numero = @nro_bono
END

