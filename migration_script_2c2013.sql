---  clean tables and procedures
--create:

use [GD2C2013]
GO

CREATE SCHEMA NN_NN
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*************************************************************************************
*                    ROL                                                                                           *
**************************************************************************************/

CREATE TABLE NN_NN.FUNCIONALIDAD(
	ID NUMERIC(18,0) IDENTITY PRIMARY KEY NOT NULL,
	NOMBRE VARCHAR(255) UNIQUE NOT NULL
)
-- END FUNCIONALIDAD
GO
INSERT INTO NN_NN.FUNCIONALIDAD VALUES 
	('ABM de Rol'),
	('Registro de Usuario'),
	('ABM de Afiliado'), 
	('ABM de Profesional'), 
	('Abm Especialidades Médicas'),
	('Abm de Planes'),
	('Registrar agenda del médico'), 
	('Compra de bonos'), 
	('Pedir turno'),
	('Registro de llegada para atención médica'), 
	('Registrar resultado para atención médica'), 
	('Cancelar atención médica por Medico'),
	('Cancelar atención médica por Paciente'),
	('Generar Receta'),
	('Listado estadísta');
GO
---------------------------------------------------
-- TABLA ROL
---------------------------------------------------
CREATE TABLE NN_NN.ROL(
	ID NUMERIC(18,0)IDENTITY PRIMARY KEY NOT NULL,
	NOMBRE VARCHAR(255) UNIQUE NOT NULL,
	HABILITADO BIT DEFAULT 1
)
-- END ROL
GO
---------------------------------------------------
-- TABLA ROL FUNCIONALIDAD
---------------------------------------------------
CREATE TABLE NN_NN.ROL_FUNCIONALIDAD(
	ID_ROL NUMERIC(18,0),
	ID_FUNCIONALIDAD NUMERIC (18,0),
	CONSTRAINT PK_ROL_FUNCIONALIDAD PRIMARY KEY(ID_ROL, ID_FUNCIONALIDAD),
	CONSTRAINT FK_ROL FOREIGN KEY(ID_ROL) REFERENCES NN_NN.ROL(ID),
	CONSTRAINT FK_FUNCIONALIDAD FOREIGN KEY(ID_FUNCIONALIDAD) REFERENCES NN_NN.FUNCIONALIDAD(ID)	
)
GO
INSERT INTO NN_NN.ROL (NOMBRE )VALUES('Administrativo');
INSERT INTO NN_NN.ROL_FUNCIONALIDAD (ID_ROL, ID_FUNCIONALIDAD) VALUES
	(1, 1),	-- Abm de Rol
	(1, 2), -- Registro de Usuario
	(1, 3), -- Abm Afiliado
	(1, 4), -- Abm Profesional
	(1, 5), -- Abm Especialidades Médicas
	(1, 6), -- Abm de Planes
	(1, 10), -- Registro de llegada para atención médica // Deberia ser otro tipo de administrador
	(1, 15); -- Listado estadistico
GO
INSERT INTO NN_NN.ROL (NOMBRE ) VALUES ('Afiliando');
GO
INSERT INTO NN_NN.ROL_FUNCIONALIDAD (ID_ROL, ID_FUNCIONALIDAD) VALUES 
	(2, 8), -- Compra de bonos
	(2, 9), -- Pedir Turno
	(2, 13);-- Cancelar atención médica por Paciente
GO
INSERT INTO NN_NN.ROL (NOMBRE ) VALUES ('Profesional');
GO
INSERT INTO NN_NN.ROL_FUNCIONALIDAD (ID_ROL, ID_FUNCIONALIDAD) VALUES 
	(3, 7), -- Registrar agenda del médico
	(2, 11), -- Registrar resultado para atención médic
	(2, 12), -- Cancelar atención médica por Medico
	(2, 14); -- Generar Receta
-- END ROL-FUNCIONALIDAD
GO
CREATE TABLE NN_NN.USUARIO(
	ID NUMERIC(18,0) IDENTITY PRIMARY KEY NOT NULL,
	USER_NAME VARCHAR(255) NOT NULL UNIQUE,
	PASSWORD VARCHAR(255) NOT NULL,
	ID_AFILIADO NUMERIC(18,0) NULL,
	ID_AFILIADO_DISCRIMINADOR NUMERIC(18,0) NULL,
	ID_PROFESIONAL NUMERIC(18,0) NULL,
	INTENTOS_FALLIDOS INT DEFAULT 0,
	HABILITADO BIT DEFAULT 1,
	CAMBIO_PASSWORD BIT DEFAULT 0
)
-- END ROL-FUNCIONALIDAD
GO
---------------------------------------------------
-- TABLA ROL USUARIO-ROL
---------------------------------------------------
CREATE TABLE NN_NN.USUARIO_ROL(
	ID_USUARIO NUMERIC(18,0) NOT NULL, 
	ID_ROL NUMERIC(18,0) NOT NULL,
	ID NUMERIC(18,0) NULL,	--Si es un admin no tiene cliente relacionado
	CONSTRAINT PK_USURIO_ROL PRIMARY KEY (ID_USUARIO, ID_ROL),
	CONSTRAINT FK_USUARIO_ROL FOREIGN KEY (ID_ROL) REFERENCES NN_NN.ROL(ID),
	CONSTRAINT FK_USUARIO_USUARIO FOREIGN KEY (ID_USUARIO) REFERENCES NN_NN.USUARIO(ID)
)
GO
--PASSWORD ADMIN
INSERT INTO NN_NN.USUARIO (USER_NAME, PASSWORD)VALUES('admin', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
INSERT INTO NN_NN.USUARIO_ROL (ID_USUARIO, ID_ROL) VALUES(1,1);
GO
/*************************************************************************************
*                    TABLAS                                                                                     *
**************************************************************************************/
-- Para el generar el numero de Afiliado utilizo un tabla con una primari key identiti
CREATE TABLE NN_NN.SECUENCIA_NUMERO_AFILIADO
(
	id [numeric](18,0) IDENTITY PRIMARY KEY,
	used CHAR
)
GO
CREATE TABLE NN_NN.AFILIADO
(
	numero [numeric](18, 0) null,
	numero_tipo_afiliado [numeric](18, 0) not null,
	apellido [varchar] (255) not null,
	nombre [varchar] (255) not null,
	codigo_documento [numeric](18, 0) not null,
	documento [numeric](18, 0) not null,
	direccion [varchar] (255) not null,
	cod_estado_civil [numeric](18, 0),
	fecha_nac [datetime],
	telefono [numeric](18, 0) not null,
	mail [varchar] (255) not null,
	cantidad_hijos [numeric](18, 0),
	fecha_baja [datetime],
	cod_plan [numeric](18, 0) not null,
	sexo [char] not null default ('I'),
	verificado [datetime] null,
	habilitado [char]not null default ('1'),
)

CREATE TABLE NN_NN.TIPO_DOCUMENTO
(
	codigo [numeric](18, 0)identity(1,1) not null,
	descripcion [varchar] (255) not null
)

CREATE TABLE NN_NN.ESTADO_CIVIL
(
	codigo [numeric](18, 0)identity(1,1) not null,
	descripcion [varchar] (255) not null
)

CREATE TABLE NN_NN.CAMBIO_PLAN
(
	fecha_modificaion [datetime] not null,
	motivo [varchar] (255) not null,
	nro_afiliado [numeric](18, 0) not null,
	nro_tipo_afiliado [numeric](18, 0) not null,
	habilitado [char] not null default ('1'),
	fecha datetime
)

CREATE TABLE NN_NN.PLAN_MEDICO
(
	codigo [numeric](18, 0) not null,
	descripcion [varchar] (255) not null,
	precio_bono_consulta  [numeric](18, 0) not null,
	precio_bono_farmacia [numeric](18, 0) not null,
	habilitado [char] not null default ('1')
)

CREATE TABLE NN_NN.BONO_CONSULTA
(
	fecha_compra [datetime],
	numero [numeric](18, 0) not null,
	--numero_consulta [numeric](18, 0),
	fecha_impresion [datetime],
	nro_afiliado [numeric](18, 0),
	nro_tipo_afiliado [numeric](18, 0)
)

CREATE TABLE NN_NN.BONO_FARMACIA
(
	fecha_compra [datetime],
	numero [numeric](18, 0) not null,
	fecha_impresion [datetime],
	fecha_vencimiento [datetime],
	nro_afiliado [numeric](18, 0),
	nro_tipo_afiliado [numeric](18, 0),
	habilitado [char] not null default ('1')
)

CREATE TABLE NN_NN.REGISTRO_COMPRA_BONO
(
	fecha_compra [datetime],
	nro_afiliado [numeric](18, 0),
	nro_tipo_afiliado [numeric](18, 0),
	cantidad_bonos_farmacia [numeric](18, 0),
	cantidad_bonos_consulta [numeric](18, 0)
)


CREATE TABLE NN_NN.MEDICAMENTO
(
	descripcion [varchar] (255) not null,
	nro_bono_farmacia [numeric](18, 0) not null,
	cantidad [numeric](18, 0) not null
)

CREATE TABLE NN_NN.PROFESIONAL
(
	numero [numeric](18, 0) identity(1,1) not null,
	apellido [varchar] (255) not null,
	nombre [varchar] (255) not null,
	codigo_documento [numeric](18, 0) not null,
	dni [numeric](18, 0) not null,
	direccion [varchar] (255) not null,
	fecha_nac [datetime],
	telefono [numeric](18, 0) not null,
	enable [varchar] (1),
	mail [varchar] (255) not null,
	sexo [char] not null default ('I'),
	matricula numeric(18,0) null,
	verificado [datetime] null,
	habilitado [char] not null default ('1')
)

CREATE TABLE NN_NN.AGENDA
(
	numero [numeric](18, 0) identity(1,1) not null,
	fecha_fin [date] not null,
	fecha_inicio [date] not null,
	nro_profesional [numeric](18, 0) not null,
	habilitado [char] not null default ('1')
)

CREATE TABLE NN_NN.DIA_ATENCION
(
	codigo_dia [numeric](18, 0) not null,
	hora_fin [time] not null,
	hora_inicio [time] not null,
	nro_agenda [numeric](18, 0) not null,
	habilitado [char] not null default ('1')
)


CREATE TABLE NN_NN.DIA
(
	codigo [numeric](18, 0) identity(1,1) not null,
	descripcion [varchar] (255) not null
)


CREATE TABLE NN_NN.PROFESIONAL_ESPECIALIDAD
(
	nro_profesional [numeric](18, 0) not null,
	cod_especialidad [numeric](18, 0) not null
)

CREATE TABLE NN_NN.ESPECIALIDAD
(
	codigo [numeric](18, 0) not null,
	descripcion [varchar] (255) not null,
	cod_tipo_especialidad [numeric](18, 0) not null,
	habilitado [char] not null default ('1')
)

CREATE TABLE NN_NN.TIPO_ESPECIALIDAD
(
	codigo [numeric](18, 0) not null,
	descripcion [varchar] (255) not null,
	habilitado [char] not null default ('1')
)

CREATE TABLE NN_NN.TURNO
(
	numero [numeric](18, 0) not null,
	fecha [datetime] not null,
	fecha_llegada [datetime],
	nro_afiliado [numeric](18, 0),
	nro_tipo_afiliado [numeric](18, 0) null,
	nro_profesional [numeric](18, 0) not null,
	nro_day [numeric](18, 0) not null,
	habilitado [char] not null default ('1')
)

CREATE TABLE NN_NN.CANCELACION_TURNO
(
	motivo [varchar] (255) not null,
	nro_turno [numeric](18, 0) not null,
	cod_tipo_cancelacion [numeric](18, 0) not null
)

CREATE TABLE NN_NN.TIPO_CANCELACION
(
	codigo [numeric](18, 0) not null,
	descripcion [varchar] (255) not null,
	habilitado [char] not null default ('1')
)


CREATE TABLE NN_NN.CONSULTA
(
	numero [numeric](18, 0) identity(1,1) not null,
	diagnostico [varchar] (255) not null,
	sintomas [varchar] (255) not null,
	fecha_atencion [datetime],
	nro_bono_consulta [numeric](18, 0) not null,
	nro_turno [numeric](18, 0) not null
)

/*
CREATE TABLE NN_NN.CONSULTA_BONO_FARMACIA
(
	nro_bono_farmacia [numeric](18, 0) not null,
	nro_turno [numeric](18, 0) not null,
	nro_bono_consulta [numeric](18, 0) not null
)*/

CREATE TABLE NN_NN.RECETA
(
	numero [numeric](18, 0) identity(1,1) not null,
	nro_consulta [numeric](18, 0) not null
)

CREATE TABLE NN_NN.RECETA_BONO_FARMACIA
(
	nro_bono_farmacia [numeric](18, 0) not null,
	nro_receta [numeric](18, 0) not null
)



/*************************************************************************************
*                    MIGRATION                                                       *
**************************************************************************************/
GO
CREATE FUNCTION NN_NN.GENERA_USER_NAME(
	@INICIAL_1 VARCHAR(2)=N,
	@INICIAL_2 VARCHAR(2)=N,
	@POS NUMERIC(18,0),
	@POST VARCHAR(2)
)
returns varchar(18)
begin
	DECLARE @DateTimeString VARCHAR(18);
	DECLARE @DateTime DATETIME;
	
	SELECT @DateTime = CURRENT_TIMESTAMP;
	SELECT @DateTimeSTRING = @INICIAL_1 + @INICIAL_2 + @POST + convert(varchar(18), @POS); 
	--convert(varchar,DATEPART(Ms, @DateTime));
	return @DateTimeSTRING
end
GO
CREATE TRIGGER [NN_NN].[TRIGGER_TEMPORAL_PROFESIONAL] ON [NN_NN].[PROFESIONAL]
FOR INSERT 
AS
	DECLARE @id_profesional NUMERIC(18,0)
	-- Creo una tabla para usarla como vector con las password iniciales
	DECLARE @PASS_TABLE TABLE (
		IDs INT,
		PASSWORD_DEFAULT VARCHAR(255) NOT NULL
	);
	INSERT INTO @PASS_TABLE VALUES
		(0, 'b4abc8499ea7c87b0906a72299e6ee1eb54a45edb42e9676a7089cdf2cd5f466'), --P4Ss4sW0rd0_0
		(1, '1610c5c6b8c42c3de4187a55fd1e7d7f7ccfb4444fa3ce350b1b449bab8a523f'), --P4Ss4sW0rd0_1
		(2, '1f88ea8fdd8c467661d158927540fda0771ce4d8b8c007856e615de191465631'), --P4Ss4sW0rdA_0
		(3, 'e6e35efa035d3c950f2a7392926c5f657784cbb19d7f463ffc5c62b6f44507b6'), --P4Ss4sW0rdA_E
		(4, 'f4ad3d4c16f02d7a45508b6b11f8f5f11c1326df54f0beb2332d7394a4a37850'), --PASs4sW0rdA_X
		(5, '7d2529f53023dbba3720eeda3e2d88b5bc25639cda9c3ac8d3a85d4485a27a36'), --PASs4sW0rd4_X
		(6, '816d02f9968e170cca4a2aa6c7e81d572d77f052bb5d123a916ac3f48e2e1d940'), --PASs4sWOrd4_X
		(7, 'de908722439886e996bbbf5fac506aa4e72e48f5b523d14fd1bb6ea4776a4b2e'), --PASs4sWOrds_X
		(8, 'af9b7dad195f66aa22e81bad4223a50b11be517a228d1abe7a04a1786a040c97'), --PASs4SWOrds_X
		(9, '89620a4132aaceeb69e89a3a80e7937839d6d464ba94e0355f421d93c24deb3c'), --PsXX4SWOrds_X
		(10, 'bc2fb5a3ca93f4e48ac73dd5a8f7d15237962b1d6d39d3338e2720e84f30b7c7'), --PsXX4SWOrds_1
		(11, '7cdf41714bb759707c6d8769ac37fcaa256199dc14052edd87e4da92276b99f5'), --PsXX4SWOrds_K
		(12, '049e1cc062e3f799b2c7ad2ee1d9ec043a1d3659a992d6de486f668638cee7d5'), --PsXX4XWOrds_K
		(13, '59a519408726557a3b8cd018567807afc3bf9faf95447a967063808e18192fd6'), --PsXX4XWOrds_A
		(14, '44bd5381f890879b9562737403629a24f8c6d172c1ea6470f94d2bfd24ebe30d'), --CLAVE_KEYs_A
		(15, '8d2a7d8966fcd8c51aecf2ce41c09b3eb9de0c245c0b54b37fa4316d865dbcab'), --CLAVX_KEYs_A 
		(16, '52bc741cd808de182a893fc5b48518aded3aa36b0ce72b59cddb0b51a7fd312a'), --CLABX_KEYs_A
		(17, 'ebec764c4afedd7c29280885897aa3a53ae78595ffc66d8f89b509c768d8cc71'), --TEMs_XXY-222
		(18, 'c0bfb39f36ea0cca8f4303e2e750dcda5e32467a384d00735365e15ba752ca5b'), --TEMP_XXY-222
		(19, '77ee0d9d9375068322f8f2adc44dc7916a5d33c0cde51f5ee840e88a2638ff6c'); --TEsMs_XXY-222
	
	DECLARE @post NUMERIC(18,0);
	DECLARE @passwordDefault VARCHAR(255);
	DECLARE @ids INT;
	DECLARE @nombre VARCHAR(255);
	DECLARE @apellido VARCHAR(255);
	DECLARE @idPush NUMERIC(18,0);
	
	DECLARE cProfecional CURSOR FOR 
		SELECT [numero], [nombre], [apellido] FROM inserted;
		
	SET @post = 0;
	
	OPEN cProfecional
		FETCH NEXT FROM cProfecional
			INTO @id_profesional, @nombre, @apellido
		WHILE (@@FETCH_STATUS = 0)
		BEGIN
			SELECT @ids = (SELECT ROUND(((19) * RAND()), 0));
			SELECT @passwordDefault = PASSWORD_DEFAULT 
				FROM @PASS_TABLE 
					WHERE  IDs = @ids;
			INSERT INTO NN_NN.USUARIO (USER_NAME, PASSWORD, ID_PROFESIONAL)	VALUES (
				NN_NN.GENERA_USER_NAME(
					Substring(@nombre, 1, 2), 
					Substring(@apellido, 1, 2),
					@id_profesional, 'p_'
				), 
				'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 
				@id_profesional
			)
			SET @idPush =  SCOPE_IDENTITY();
			INSERT INTO NN_NN.USUARIO_ROL (ID_USUARIO, ID_ROL) VALUES(@idPush, 3);
			SET @post = @post + 1;
			FETCH NEXT FROM cProfecional
				INTO @id_profesional, @nombre, @apellido
		END
		CLOSE cProfecional
		DEALLOCATE cProfecional
	
	
GO
-- Funcion que simula una secuencia para generar el id
-- del afiliado
CREATE PROCEDURE [NN_NN].FN_RETURN_ID_AFILIADO (
	@id_afiliado NUMERIC OUTPUT
)
AS 
BEGIN
	INSERT INTO NN_NN.SECUENCIA_NUMERO_AFILIADO (used) VALUES ('1'); 
	SET @id_afiliado = SCOPE_IDENTITY();
	RETURN @id_afiliado; 
END
GO
CREATE TRIGGER [NN_NN].[TRIGGER_TEMPORAL_AFILIADO] ON [NN_NN].[AFILIADO]
INSTEAD OF INSERT 
AS
	DECLARE @id_afiliado NUMERIC(18,0)
	-- Creo una tabla para usarla como vector con las password iniciales
	DECLARE @PASS_TABLE TABLE (
		IDs INT,
		PASSWORD_DEFAULT VARCHAR(255) NOT NULL
	);
	INSERT INTO @PASS_TABLE VALUES
		(0, 'b4abc8499ea7c87b0906a72299e6ee1eb54a45edb42e9676a7089cdf2cd5f466'), --P4Ss4sW0rd0_0
		(1, '1610c5c6b8c42c3de4187a55fd1e7d7f7ccfb4444fa3ce350b1b449bab8a523f'), --P4Ss4sW0rd0_1
		(2, '1f88ea8fdd8c467661d158927540fda0771ce4d8b8c007856e615de191465631'), --P4Ss4sW0rdA_0
		(3, 'e6e35efa035d3c950f2a7392926c5f657784cbb19d7f463ffc5c62b6f44507b6'), --P4Ss4sW0rdA_E
		(4, 'f4ad3d4c16f02d7a45508b6b11f8f5f11c1326df54f0beb2332d7394a4a37850'), --PASs4sW0rdA_X
		(5, '7d2529f53023dbba3720eeda3e2d88b5bc25639cda9c3ac8d3a85d4485a27a36'), --PASs4sW0rd4_X
		(6, '816d02f9968e170cca4a2aa6c7e81d572d77f052bb5d123a916ac3f48e2e1d940'), --PASs4sWOrd4_X
		(7, 'de908722439886e996bbbf5fac506aa4e72e48f5b523d14fd1bb6ea4776a4b2e'), --PASs4sWOrds_X
		(8, 'af9b7dad195f66aa22e81bad4223a50b11be517a228d1abe7a04a1786a040c97'), --PASs4SWOrds_X
		(9, '89620a4132aaceeb69e89a3a80e7937839d6d464ba94e0355f421d93c24deb3c'), --PsXX4SWOrds_X
		(10, 'bc2fb5a3ca93f4e48ac73dd5a8f7d15237962b1d6d39d3338e2720e84f30b7c7'), --PsXX4SWOrds_1
		(11, '7cdf41714bb759707c6d8769ac37fcaa256199dc14052edd87e4da92276b99f5'), --PsXX4SWOrds_K
		(12, '049e1cc062e3f799b2c7ad2ee1d9ec043a1d3659a992d6de486f668638cee7d5'), --PsXX4XWOrds_K
		(13, '59a519408726557a3b8cd018567807afc3bf9faf95447a967063808e18192fd6'), --PsXX4XWOrds_A
		(14, '44bd5381f890879b9562737403629a24f8c6d172c1ea6470f94d2bfd24ebe30d'), --CLAVE_KEYs_A
		(15, '8d2a7d8966fcd8c51aecf2ce41c09b3eb9de0c245c0b54b37fa4316d865dbcab'), --CLAVX_KEYs_A 
		(16, '52bc741cd808de182a893fc5b48518aded3aa36b0ce72b59cddb0b51a7fd312a'), --CLABX_KEYs_A
		(17, 'ebec764c4afedd7c29280885897aa3a53ae78595ffc66d8f89b509c768d8cc71'), --TEMs_XXY-222
		(18, 'c0bfb39f36ea0cca8f4303e2e750dcda5e32467a384d00735365e15ba752ca5b'), --TEMP_XXY-222
		(19, '77ee0d9d9375068322f8f2adc44dc7916a5d33c0cde51f5ee840e88a2638ff6c'); --TEsMs_XXY-222
	
	DECLARE @post int;
	DECLARE @passwordDefault VARCHAR(255);
	DECLARE @ids INT;
	DECLARE @idPush NUMERIC(18,0);
	
	
	DECLARE @apellido VARCHAR(255);
	DECLARE @nombre VARCHAR(255);
	DECLARE @estadoCivil INT;
	DECLARE @cod_plan INT;
	DECLARE @tipo_documento INT;
	DECLARE @documento INT;
	DECLARE @telefono INT;
	DECLARE @direccion VARCHAR(255); 
	DECLARE @fecha VARCHAR(255);
	DECLARE @email VARCHAR(255);
	DECLARE @sexo CHAR;
	DECLARE @numero INT;
	
	DECLARE cAfiliado CURSOR FOR 
		SELECT apellido, nombre, cod_estado_Civil, cod_plan, codigo_documento, documento,
			telefono, direccion, fecha_nac, mail, sexo 
		FROM inserted;
		
	SET @post = 0;
	
	OPEN cAfiliado
		FETCH NEXT FROM cAfiliado
			INTO @apellido, @nombre, @estadoCivil, @cod_plan, @tipo_documento, @documento,
				@telefono, @direccion, @fecha, @email, @sexo
		
		WHILE (@@FETCH_STATUS = 0)
		BEGIN
			--Obtengo el numero de usuario de la tabla
			
			exec [NN_NN].FN_RETURN_ID_AFILIADO @id_afiliado OUTPUT;
			
			INSERT INTO [NN_NN].[AFILIADO](apellido, nombre, cod_estado_Civil, cod_plan, codigo_documento, documento,
				telefono, direccion, fecha_nac, mail, sexo, numero_tipo_afiliado, numero)
			VALUES  (@apellido, @nombre, @estadoCivil, @cod_plan, @tipo_documento, @documento,
				@telefono, @direccion, @fecha, @email, @sexo, 0 , @id_afiliado);
			PRINT NN_NN.GENERA_USER_NAME(
					Substring('1', 1, 2), 
					Substring('2', 1, 2),
					@id_afiliado,
					'A_'
				);
			SELECT @ids = (SELECT ROUND(((19) * RAND()), 0));
			SELECT @passwordDefault = PASSWORD_DEFAULT 
				FROM @PASS_TABLE 
					WHERE  IDs = @ids;
			INSERT INTO NN_NN.USUARIO (USER_NAME, PASSWORD, ID_AFILIADO, ID_AFILIADO_DISCRIMINADOR)	VALUES (
				NN_NN.GENERA_USER_NAME(
					Substring(@nombre, 1, 2), 
					Substring(@apellido, 1, 2),
					@id_afiliado,
					'A_'
				), 
				'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 
				@id_afiliado,
				0
			) 
			SET @idPush =  SCOPE_IDENTITY();
			INSERT INTO NN_NN.USUARIO_ROL (ID_USUARIO, ID_ROL) VALUES(@idPush, 2);
			SET @post = @post + 1;
			FETCH NEXT FROM cAfiliado
				INTO @apellido, @nombre, @estadoCivil, @cod_plan, @tipo_documento, @documento,
				@telefono, @direccion, @fecha, @email, @sexo
		END
		CLOSE cAfiliado
		DEALLOCATE cAfiliado
	
	
GO
/******************************************************
*                    TIPO DOCUMENTO                         *
*******************************************************/
PRINT 'TIPO_DOCUMENTO'
INSERT INTO NN_NN.TIPO_DOCUMENTO (descripcion)
VALUES ('dni'), 
	('Libreta Cívica'), 
	('Libreta de Enrolamiento')
/******************************************************
*                    ESTADO CIVIL                     *
*******************************************************/
PRINT 'ESTADO_CIVIL'
INSERT INTO NN_NN.ESTADO_CIVIL (descripcion)
VALUES ('single'),
	('married'),
	('widower'),
	('concubinage'),
	('divorced')
/******************************************************
*                    DIA                              *
*******************************************************/
PRINT 'DIA'
INSERT INTO NN_NN.DIA (descripcion)
VALUES ('sunday'),
	('monday'),
	('tuesday'),
	('wednesday'),
	('thursday'),
	('friday'),
	('saturday')
/******************************************************
*                    TIPO CANCELACION TURNO           *
*******************************************************/
PRINT 'TIPO_CANCELACION'
INSERT INTO NN_NN.TIPO_CANCELACION (codigo, descripcion)
VALUES (0, 'CANCELACION POR SISTEMA'),
	(1, 'CANCELACION POR AFILIADO'),
	(2, 'CANCELACION POR MEDICO')
/******************************************************
*                    PLAN                             *
*******************************************************/
PRINT 'PLAN_MEDICO'
INSERT INTO 
	NN_NN.PLAN_MEDICO(codigo, descripcion, precio_bono_consulta, precio_bono_farmacia)
SELECT DISTINCT  
	Plan_Med_Codigo, Plan_Med_Descripcion, Plan_Med_Precio_Bono_Consulta, Plan_Med_Precio_Bono_Farmacia 
FROM 
	gd_esquema.Maestra
GO
/******************************************************
*                    AFILIADO                         *
*******************************************************/
GO
PRINT 'AFILIADO'
INSERT INTO NN_NN.AFILIADO(
	apellido, 
	nombre,
	codigo_documento, 
	documento, 
	direccion, 
	fecha_nac, 
	telefono, 
	mail, 
	cod_plan
) 
SELECT DISTINCT Paciente_Apellido, Paciente_Nombre,1, Paciente_Dni, Paciente_Direccion, Paciente_Fecha_Nac, Paciente_Telefono, Paciente_Mail, Plan_Med_Codigo
	FROM gd_esquema.Maestra
/******************************************************
*                    BONOS                            *
*******************************************************/
PRINT 'BONO_CONSULTA'
-- turno -> compra bono consulta ó compra bono farmacia -> medicamento

-- bonos consulta

INSERT INTO 
	NN_NN.BONO_CONSULTA(fecha_compra, numero, fecha_impresion, nro_afiliado, nro_tipo_afiliado)
SELECT DISTINCT 
	 M.Compra_Bono_Fecha, M.Bono_Consulta_Numero, M.Bono_Consulta_Fecha_Impresion, A.numero, A.numero_tipo_afiliado
FROM 
	gd_esquema.Maestra M
--order by M.Bono_Consulta_Numero
INNER JOIN
	NN_NN.AFILIADO A	
ON
	M.Paciente_Dni=A.documento
WHERE 
	M.Compra_Bono_Fecha IS NOT NULL AND
	M.Bono_Consulta_Fecha_Impresion IS NOT NULL 
--Order by 
--	A.nro_afiliado
	
	
-- bonos farmacia 
INSERT INTO 
	NN_NN.BONO_FARMACIA(fecha_compra, numero, fecha_impresion, nro_afiliado, nro_tipo_afiliado)
SELECT DISTINCT 
	 M.Compra_Bono_Fecha, M.Bono_Farmacia_Numero, M.Bono_Farmacia_Fecha_Impresion, A.numero, A.numero_tipo_afiliado
FROM 
	gd_esquema.Maestra M
INNER JOIN
	NN_NN.AFILIADO A	
ON
	M.Paciente_Dni=A.documento
WHERE 
	M.Compra_Bono_Fecha IS NOT NULL AND
	M.Bono_Farmacia_Fecha_Impresion IS NOT NULL
--Order by 
--	A.nro_afiliado
	
/******************************************************
*                    CONSULTA                         *
*******************************************************/
INSERT INTO 
	NN_NN.CONSULTA(nro_bono_consulta, diagnostico, sintomas, nro_turno)
SELECT DISTINCT 
	 M.Bono_Consulta_Numero, M.Consulta_Enfermedades, M.Consulta_Sintomas, M.Turno_Numero 
FROM 
	gd_esquema.Maestra M
where
	M.Bono_Consulta_Numero is not null and 
	M.Consulta_Enfermedades is not null and 
	M.Consulta_Sintomas is not null
--order by M.Bono_Consulta_Numero

/******************************************************
*                    CONSULTA_BONO_FARMACIA           *
*******************************************************/
/*INSERT INTO 
	NN_NN.CONSULTA_BONO_FARMACIA(nro_bono_consulta, nro_bono_farmacia, nro_turno)
SELECT DISTINCT 
	 M.Bono_Consulta_Numero, M.Bono_Farmacia_Numero, M.Turno_Numero 
FROM 
	gd_esquema.Maestra M
where
	M.Bono_Consulta_Numero is not null and 
	M.Consulta_Enfermedades is not null and 
	M.Consulta_Sintomas is not null
--order by M.Bono_Consulta_Numero
*/

/******************************************************
*                    MEDICAMENTOS                     *
*******************************************************/
INSERT INTO 
	NN_NN.MEDICAMENTO(descripcion, nro_bono_farmacia)
SELECT 
	 M.Bono_Farmacia_Medicamento, M.Bono_Farmacia_Numero
FROM 
	gd_esquema.Maestra M
INNER JOIN
	NN_NN.AFILIADO A	
ON
	M.Paciente_Dni=A.documento
WHERE 
	M.Bono_Farmacia_Medicamento IS NOT NULL 



/******************************************************
*                    PROFESIONAL                      *
*******************************************************/

INSERT INTO 
	NN_NN.PROFESIONAL(apellido, nombre, dni, direccion, fecha_nac, telefono, mail, codigo_documento)
SELECT DISTINCT 
	Medico_Apellido, Medico_Nombre, Medico_Dni, Medico_Direccion, Medico_Fecha_Nac, Medico_Telefono, Medico_Mail, 1 
FROM 
	gd_esquema.Maestra
WHERE 
	Medico_Apellido IS NOT NULL AND
	Medico_Nombre IS NOT NULL AND
	Medico_Dni IS NOT NULL AND
	Medico_Direccion IS NOT NULL AND
	Medico_Fecha_Nac IS NOT NULL AND
	Medico_Telefono IS NOT NULL AND
	Medico_Mail IS NOT NULL


/******************************************************
*                    TIPO_ESPECIALIDAD_MEDICA         *
*******************************************************/

INSERT INTO 
	NN_NN.TIPO_ESPECIALIDAD(codigo, descripcion)
SELECT DISTINCT 
	M.Tipo_Especialidad_Codigo, M.Tipo_Especialidad_Descripcion
FROM 
	gd_esquema.Maestra M
WHERE
	Tipo_Especialidad_Codigo IS NOT NULL AND
	Tipo_Especialidad_Descripcion IS NOT NULL


/******************************************************
*                    ESPECIALIDAD_MEDICA              *
*******************************************************/

INSERT INTO 
	NN_NN.ESPECIALIDAD(codigo, descripcion, cod_tipo_especialidad)
SELECT DISTINCT 
	Especialidad_Codigo, Especialidad_Descripcion, Tipo_Especialidad_Codigo
FROM 
	gd_esquema.Maestra
WHERE
	Especialidad_Codigo IS NOT NULL AND
	Especialidad_Descripcion IS NOT NULL AND
	Tipo_Especialidad_Codigo IS NOT NULL

/******************************************************
*                    PROFESIONAL_ESPECIALIDAD              *
*******************************************************/

INSERT INTO 
	NN_NN.PROFESIONAL_ESPECIALIDAD(cod_especialidad, nro_profesional)
SELECT DISTINCT 
	M.Especialidad_Codigo, P.numero
FROM 
	gd_esquema.Maestra M
JOIN
	NN_NN.PROFESIONAL P
ON
	P.dni = M.Medico_Dni

WHERE
	Especialidad_Codigo IS NOT NULL

	
/******************************************************
*                    TURNO                            *
*******************************************************/

INSERT INTO 
	NN_NN.TURNO(numero, fecha, nro_profesional, nro_afiliado, nro_tipo_afiliado, nro_day)
SELECT DISTINCT   
	M.Turno_Numero, M.Turno_Fecha, P.numero, A.numero, A.numero_tipo_afiliado, datepart(dw,Turno_Fecha)
FROM 
	gd_esquema.Maestra M
JOIN
	NN_NN.PROFESIONAL P
ON
	P.dni = M.Medico_Dni
JOIN
	NN_NN.AFILIADO A
ON
	A.documento = M.Paciente_Dni
WHERE
	Turno_Numero IS NOT NULL AND
	Turno_Fecha IS NOT NULL AND
	Medico_Dni IS NOT NULL AND
	Paciente_Dni IS NOT NULL

GO

/******************************************************
*                    CANCELACION TURNO POR SISTEMA    *
*******************************************************/

INSERT INTO 
	NN_NN.CANCELACION_TURNO(nro_turno, cod_tipo_cancelacion, motivo)
SELECT DISTINCT   
	T.numero, 0, 'cancelado por estar en día domingo'
FROM
	NN_NN.TURNO T
WHERE
	T.nro_day = 1
GO


/******************************************************
*                    AGENDA MEDICA                    *
*******************************************************/

-- AGENDA MAX DATE MIN DATE BY PROFESIONAL

INSERT INTO
	NN_NN.AGENDA (nro_profesional, fecha_fin, fecha_inicio )
SELECT 
	P.numero, MAX(CONVERT(date,M.Turno_Fecha) ) as fecha_max, DATEADD(DAY, -120,MAX(CONVERT(date,M.Turno_Fecha))) as fecha_min
FROM 
	GD2C2013.gd_esquema.Maestra M
JOIN
	NN_NN.PROFESIONAL P
ON
	M.Medico_Dni = P.dni
GROUP BY P.numero


-- DAY IN AGENDA MAX TIME MIN TIME BY PROFESIONAL

INSERT INTO
	NN_NN.DIA_ATENCION (codigo_dia, nro_agenda, hora_fin, hora_inicio)
SELECT  
	D.codigo as dia, A.numero as nro_agenda, MAX(CONVERT(time,M.Turno_Fecha) ) as hora_max, MIN(CONVERT(time,M.Turno_Fecha) ) as hora_min
FROM 
	GD2C2013.gd_esquema.Maestra M
INNER JOIN
	NN_NN.PROFESIONAL P
ON 
	P.dni = M.Medico_Dni
INNER JOIN
	NN_NN.AGENDA A
ON
	A.nro_profesional = P.numero
INNER JOIN
	NN_NN.DIA D
ON
	datepart(dw,M.Turno_Fecha) = D.codigo
	
WHERE
	M.Turno_Fecha >= A.fecha_inicio AND
	datepart(dw,M.Turno_Fecha) != 1 -- SUNDAY
	
GROUP BY
	A.numero, D.codigo
--ORDER BY D.codigo, A.numero
GO
ALTER TABLE NN_NN.AFILIADO ALTER COLUMN numero [numeric](18, 0) NOT NULL
GO
ALTER TABLE NN_NN.AFILIADO ALTER COLUMN numero_tipo_afiliado [numeric](18, 0) NOT NULL
GO
ALTER TABLE NN_NN.AFILIADO ADD CONSTRAINT PK_AFILIADO_numero PRIMARY KEY (numero, numero_tipo_afiliado)
GO
ALTER TABLE NN_NN.ESTADO_CIVIL ADD CONSTRAINT PK_ESTADO_CIVIL_codigo PRIMARY KEY (codigo)
GO
ALTER TABLE NN_NN.PLAN_MEDICO ADD CONSTRAINT PK_PLAN_MEDICO_codigo PRIMARY KEY (codigo)
GO
ALTER TABLE NN_NN.TIPO_DOCUMENTO ADD CONSTRAINT PK_TIPO_DOCUMENTO_codigo PRIMARY KEY (codigo)
GO
ALTER TABLE NN_NN.BONO_CONSULTA ADD CONSTRAINT PK_BONO_CONSULTA_numero PRIMARY KEY (numero)
GO
ALTER TABLE NN_NN.BONO_FARMACIA ADD CONSTRAINT PK_BONO_FARMACIA_numero PRIMARY KEY (numero)
GO
ALTER TABLE NN_NN.PROFESIONAL ADD CONSTRAINT PK_PROFESIONAL_numero PRIMARY KEY (numero)
GO
ALTER TABLE NN_NN.AGENDA ADD CONSTRAINT PK_AGENDA_numero PRIMARY KEY (numero)
GO
ALTER TABLE NN_NN.DIA ADD CONSTRAINT PK_DIA_codigo PRIMARY KEY (codigo)
GO
ALTER TABLE NN_NN.ESPECIALIDAD ADD CONSTRAINT PK_ESPECIALIDAD_codigo PRIMARY KEY (codigo)
GO
ALTER TABLE NN_NN.TIPO_ESPECIALIDAD ADD CONSTRAINT PK_TIPO_ESPECIALIDAD_codigo PRIMARY KEY (codigo)
GO
ALTER TABLE NN_NN.TURNO ADD CONSTRAINT PK_TURNO_numero PRIMARY KEY (numero)
GO
ALTER TABLE NN_NN.TIPO_CANCELACION ADD CONSTRAINT PK_TIPO_CANCELACION_codigo PRIMARY KEY (codigo)
/*************************************************************************************
*                    CONSTRAINT FK                                                   *
**************************************************************************************/

ALTER TABLE NN_NN.AFILIADO ADD CONSTRAINT FK_AFILIADO_secuencia FOREIGN KEY (numero)
	REFERENCES NN_NN.SECUENCIA_NUMERO_AFILIADO (id);
ALTER TABLE NN_NN.AFILIADO ADD CONSTRAINT FK_AFILIADO_cod_estado_civil FOREIGN KEY (cod_estado_civil)
	REFERENCES NN_NN.ESTADO_CIVIL (codigo);
ALTER TABLE NN_NN.AFILIADO ADD CONSTRAINT FK_AFILIADO_cod_plan FOREIGN KEY (cod_plan)
	REFERENCES NN_NN.PLAN_MEDICO (codigo);
ALTER TABLE NN_NN.AFILIADO ADD CONSTRAINT FK_AFILIADO_codigo_documento FOREIGN KEY (codigo_documento)
	REFERENCES NN_NN.TIPO_DOCUMENTO (codigo);
ALTER TABLE NN_NN.BONO_CONSULTA ADD CONSTRAINT FK_BONO_CONSULTA_nro_afiliado FOREIGN KEY (nro_afiliado, nro_tipo_afiliado)
	REFERENCES NN_NN.AFILIADO (numero, numero_tipo_afiliado);	
ALTER TABLE NN_NN.BONO_FARMACIA ADD CONSTRAINT FK_BONO_FARMACIA_nro_afiliado FOREIGN KEY (nro_afiliado,nro_tipo_afiliado)
	REFERENCES NN_NN.AFILIADO (numero,numero_tipo_afiliado);
ALTER TABLE NN_NN.ESPECIALIDAD ADD CONSTRAINT FK_ESPECIALIDAD_cod_tipo_especialidad FOREIGN KEY (cod_tipo_especialidad)
	REFERENCES NN_NN.TIPO_ESPECIALIDAD (codigo);
ALTER TABLE NN_NN.PROFESIONAL_ESPECIALIDAD ADD CONSTRAINT FK_PROFESIONAL_ESPECIALIDAD_nro_profesional FOREIGN KEY (nro_profesional)
	REFERENCES NN_NN.PROFESIONAL (numero);
ALTER TABLE NN_NN.PROFESIONAL_ESPECIALIDAD ADD CONSTRAINT FK_PROFESIONAL_ESPECIALIDAD_cod_especialidad FOREIGN KEY (cod_especialidad)
	REFERENCES NN_NN.ESPECIALIDAD (codigo);	
ALTER TABLE NN_NN.AGENDA ADD CONSTRAINT FK_AGENDA_nro_profesional FOREIGN KEY (nro_profesional)
	REFERENCES NN_NN.PROFESIONAL (numero);
ALTER TABLE NN_NN.DIA_ATENCION ADD CONSTRAINT FK_DIA_ATENCION_nro_agenda FOREIGN KEY (nro_agenda)
	REFERENCES NN_NN.AGENDA (numero);
ALTER TABLE NN_NN.DIA_ATENCION ADD CONSTRAINT FK_DIA_ATENCION_codigo_dia FOREIGN KEY (codigo_dia)
	REFERENCES NN_NN.DIA (codigo);
ALTER TABLE NN_NN.CAMBIO_PLAN ADD CONSTRAINT FK_CAMBIO_PLAN_nro_afiliado FOREIGN KEY (nro_afiliado,nro_tipo_afiliado)
	REFERENCES NN_NN.AFILIADO (numero,numero_tipo_afiliado);
ALTER TABLE NN_NN.CONSULTA ADD CONSTRAINT FK_CONSULTA_nro_bono_consulta FOREIGN KEY (nro_bono_consulta)
	REFERENCES NN_NN.BONO_CONSULTA (numero);
ALTER TABLE NN_NN.CONSULTA ADD CONSTRAINT FK_CONSULTA_nro_turno FOREIGN KEY (nro_turno)
	REFERENCES NN_NN.TURNO (numero);
ALTER TABLE NN_NN.MEDICAMENTO ADD CONSTRAINT FK_MEDICAMENTO_nro_bono_farmacia FOREIGN KEY (nro_bono_farmacia)
	REFERENCES NN_NN.BONO_FARMACIA (numero);
ALTER TABLE NN_NN.CANCELACION_TURNO ADD CONSTRAINT FK_CANCELACION_TURNO_nro_turno FOREIGN KEY (nro_turno)
	REFERENCES NN_NN.TURNO (numero);	
--ALTER TABLE NN_NN.CONSULTA_BONO_FARMACIA ADD CONSTRAINT FK_CONSULTA_BONO_FARMACIA_nro_bono_farmacia FOREIGN KEY (nro_bono_farmacia)
--	REFERENCES NN_NN.BONO_FARMACIA (numero);
--ALTER TABLE NN_NN.CONSULTA_BONO_FARMACIA ADD CONSTRAINT FK_CONSULTA_BONO_FARMACIA_nro_bono_consulta  FOREIGN KEY (nro_bono_consulta )
--	REFERENCES NN_NN.BONO_CONSULTA (numero);
ALTER TABLE NN_NN.TURNO ADD CONSTRAINT FK_TURNO_nro_afiliado FOREIGN KEY (nro_afiliado,nro_tipo_afiliado)
	REFERENCES NN_NN.AFILIADO (numero,numero_tipo_afiliado);
ALTER TABLE NN_NN.TURNO ADD CONSTRAINT FK_TURNO_nro_profesional FOREIGN KEY (nro_profesional)
	REFERENCES NN_NN.PROFESIONAL(numero);
ALTER TABLE NN_NN.CANCELACION_TURNO ADD CONSTRAINT FK_TURNO_cod_tipo_cancelacion FOREIGN KEY (cod_tipo_cancelacion)
	REFERENCES NN_NN.TIPO_CANCELACION(codigo);
ALTER TABLE NN_NN.REGISTRO_COMPRA_BONO ADD CONSTRAINT FK_REGISTRO_COMPRA_BONO_nro_afiliado FOREIGN KEY (nro_afiliado,nro_tipo_afiliado)
	REFERENCES NN_NN.AFILIADO (numero,numero_tipo_afiliado);
ALTER TABLE NN_NN.RECETA ADD CONSTRAINT FK_RECETA_nro_consulta FOREIGN KEY (nro_consulta)
	REFERENCES NN_NN.CONSULTA (numero);
ALTER TABLE NN_NN.RECETA_BONO_FARMACIA ADD CONSTRAINT FK_RECETA_BONO_FARMACIA_nro_receta FOREIGN KEY (nro_receta)
	REFERENCES NN_NN.RECETA (numero);
ALTER TABLE NN_NN.RECETA_BONO_FARMACIA ADD CONSTRAINT FK_RECETA_BONO_FARMACIA_nro_bono_farmacia FOREIGN KEY (nro_bono_farmacia)
	REFERENCES NN_NN.BONO_FARMACIA (numero);
	
	
DROP FUNCTION NN_NN.GENERA_USER_NAME;
DROP TRIGGER [NN_NN].[TRIGGER_TEMPORAL_PROFESIONAL];
DROP TRIGGER [NN_NN].[TRIGGER_TEMPORAL_AFILIADO];



