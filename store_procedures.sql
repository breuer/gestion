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

CREATE PROCEDURE 
	NN_NN.SP_ADD_AFILIADO (@apellido varchar(255), @nombre varchar(255), 
	@dni int, @direccion varchar(255), @telefono int, @mail varchar(255),
	@cod_plan int)
AS
BEGIN 
	INSERT INTO 
		NN_NN.AFILIADO(apellido, nombre, dni, direccion, telefono, mail, cod_plan)
	VALUES 
		(@nombre, @apellido, @dni, @direccion, @telefono, @mail, @cod_plan)
END
GO

/******************************************************
*                    ADD PROFESIONAL                  *
*******************************************************/

CREATE PROCEDURE NN_NN.SP_ADD_PROFESIONAL (
	@apellido varchar(255), 
	@nombre varchar(255), 
	@tipo_documento NUMERIC(18,0),
	@documento NUMERIC(18,0),
	@telefono NUMERIC(18,0),
	@sexo CHAR,
	@matricula NUMERIC(18,0),
	@direccion varchar(255), 
	@mail varchar(255)
)
AS
BEGIN 
	INSERT INTO NN_NN.PROFESIONAL(apellido, nombre, documento, tipo_documento, direccion, telefono, mail, sexo)
	VALUES 
		(@nombre, @apellido, @documento, @tipo_documento, @direccion, @telefono, @mail, @sexo)
END
GO

/******************************************************
*                    ADD ESPECIALIDAD TO PROFESIONAL  *
*******************************************************/

CREATE PROCEDURE NN_NN.SP_ADD_ESPECIALIDAD (@nro_profesional int, @cod_especialidad int)
AS
BEGIN 
	INSERT INTO 
		NN_NN.PROFESIONAL_ESPECIALIDAD(nro_profesional, cod_especialidad)
	VALUES 
		(@nro_profesional, @cod_especialidad)
END
GO

/******************************************************
*                    AGENDA PROFESIONAL               *
*******************************************************/

CREATE PROCEDURE 
NN_NN.SP_ADD_DIA_ATENCION (@codigo_dia int, @nro_profesional int) AS
BEGIN 
	INSERT INTO 
		NN_NN.DIA_ATENCION(codigo_dia, nro_profesional)
	VALUES 
		(@codigo_dia, @nro_profesional)
END
GO


/******************************************************
*                    BONOS                            *
*******************************************************/
CREATE PROCEDURE 
	NN_NN.SP_ADD_BONO_CONSULTA AS
BEGIN 
	DECLARE @max_nro int = ( 
		SELECT 
			MAX(B.numero)
		FROM
			NN_NN.BONO_CONSULTA B
		WHERE
			B.nro_afiliado IS NULL
	)
	IF (@max_nro is null)
	begin
		set @max_nro = 0
	end
	INSERT INTO 
		NN_NN.BONO_CONSULTA(numero ,fecha_impresion)
	VALUES 
		(@max_nro + 1, GETDATE())
END
GO

CREATE PROCEDURE 
	NN_NN.SP_ADD_BONO_FARMACIA AS
BEGIN
	DECLARE @max_nro int = ( 
		SELECT 
			MAX(B.numero)
		FROM
			NN_NN.BONO_FARMACIA B
		WHERE
			B.nro_afiliado IS NULL
	)
	IF (@max_nro is null)
	begin
		set @max_nro = 0
	end 
	INSERT INTO 
		NN_NN.BONO_FARMACIA(numero,fecha_impresion)
	VALUES 
		(@max_nro + 1, GETDATE())
END
GO

CREATE PROCEDURE 
	NN_NN.SP_BUY_BONO_CONSULTA (@nro_afiliado int) AS
BEGIN
	DECLARE @nro int = ( 
		SELECT TOP 1
			B.numero
		FROM
			NN_NN.BONO_CONSULTA B
		WHERE
			B.nro_afiliado IS NULL
	)
	IF (@nro IS NOT NULL)
	BEGIN
		UPDATE NN_NN.BONO_CONSULTA
		SET 
			nro_afiliado = @nro_afiliado, 
			fecha_compra = GETDATE()
		WHERE
			numero = @nro
	END
END
GO

CREATE PROCEDURE 
	NN_NN.SP_BUY_BONO_FARMACIA (@nro_afiliado int)
AS
BEGIN 
	DECLARE @nro int = ( 
		SELECT TOP 1
			B.numero
		FROM
			NN_NN.BONO_FARMACIA B
		WHERE
			B.nro_afiliado IS NULL
	)
	IF (@nro IS NOT NULL)
	BEGIN
		UPDATE NN_NN.BONO_FARMACIA
		SET 
			nro_afiliado = @nro_afiliado, 
			fecha_compra = GETDATE()
		WHERE
			numero = @nro
	END
END
GO









DROP PROCEDURE NN_NN.SP_TEST_RETURN;
GO

CREATE PROCEDURE NN_NN.SP_TEST_RETURN (
	@param1 varchar(255)
)
AS
BEGIN 
	return @param1 + '_HOLA';
END