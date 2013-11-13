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
INSERT INTO NN_NN.FUNCIONALIDAD VALUES ('ABM de Cliente'),('ABM de Rol')
	, ('ABM de Usuario'), ('ABM de Auto'), ('ABM de Reloj')
	, ('ABM de Chofer')
	, ('ABM de Turno'), ('Asignación Chofer-Auto'), ('Registro de Viajes'),
	('Rendición de cuenta del chofer'), ('Facturación a Cliente'), ('Listado Estadístico'),
	('Correccion incosistencias migracion');
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
INSERT INTO NN_NN.ROL (NOMBRE )VALUES('Administrador');
INSERT INTO NN_NN.ROL_FUNCIONALIDAD (ID_ROL, ID_FUNCIONALIDAD) VALUES  (1, 1), (1, 2)
, (1, 3), (1, 4), (1, 5), (1, 6)
, (1, 7), (1, 8), (1, 9), (1, 10), (1, 11)
, (1, 12), (1, 13)
GO
INSERT INTO NN_NN.ROL (NOMBRE )VALUES('Afiliando');
GO
INSERT INTO NN_NN.ROL_FUNCIONALIDAD (ID_ROL, ID_FUNCIONALIDAD) VALUES (2, 1)
, (2, 2)
, (2, 3)
, (2, 4)
,  (2, 5)
,  (2, 6)
,  (2, 7)
,  (2, 8)
,  (2, 9)
,  (2, 10)
,  (2, 11)
,  (2, 12)
,  (2, 13);
GO
-- END ROL-FUNCIONALIDAD
GO
CREATE TABLE NN_NN.USUARIO(
	ID NUMERIC(18,0) IDENTITY PRIMARY KEY NOT NULL,
	USER_NAME VARCHAR(255) NOT NULL UNIQUE,
	PASSWORD VARCHAR(255) NOT NULL,
	INTENTOS_FALLIDOS INT DEFAULT 0,
	HABILITADO BIT DEFAULT 1
)
-- END USUARIO
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
/*************************************************************************************
*                    TABLES                                                                                     *
**************************************************************************************/

CREATE TABLE NN_NN.AFILIADO
(
	numero [numeric](18, 0) identity(1,1) not null,
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
	enable [varchar] (1)
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
	nro_afiliado [numeric](18, 0) not null
)

CREATE TABLE NN_NN.PLAN_MEDICO
(
	codigo [numeric](18, 0) not null,
	descripcion [varchar] (255) not null,
	precio_bono_consulta  [numeric](18, 0) not null,
	precio_bono_farmacia [numeric](18, 0) not null
)

CREATE TABLE NN_NN.BONO_CONSULTA
(
	fecha_compra [datetime],
	numero [numeric](18, 0) not null,
	--numero_consulta [numeric](18, 0),
	fecha_impresion [datetime],
	nro_afiliado [numeric](18, 0)
)

CREATE TABLE NN_NN.BONO_FARMACIA
(
	fecha_compra [datetime],
	numero [numeric](18, 0) not null,
	fecha_impresion [datetime],
	fecha_vencimiento [datetime],
	nro_afiliado [numeric](18, 0)
)

CREATE TABLE NN_NN.MEDICAMENTO
(
	descripcion [varchar] (255) not null,
	nro_bono_farmacia [numeric](18, 0) not null
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
	matricula numeric(18,0) null 
)

CREATE TABLE NN_NN.AGENDA
(
	numero [numeric](18, 0) identity(1,1) not null,
	fecha_fin [date] not null,
	fecha_inicio [date] not null,
	nro_profesional [numeric](18, 0) not null
)

CREATE TABLE NN_NN.DIA_ATENCION
(
	codigo_dia [numeric](18, 0) not null,
	hora_fin [time] not null,
	hora_inicio [time] not null,
	nro_agenda [numeric](18, 0) not null
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
	cod_tipo_especialidad [numeric](18, 0) not null
)

CREATE TABLE NN_NN.TIPO_ESPECIALIDAD
(
	codigo [numeric](18, 0) not null,
	descripcion [varchar] (255) not null
)

CREATE TABLE NN_NN.TURNO
(
	numero [numeric](18, 0) not null,
	fecha [datetime] not null,
	fecha_llegada [datetime],
	nro_afiliado [numeric](18, 0) ,
	nro_profesional [numeric](18, 0),	
	nro_day [numeric](18, 0) not null
)

CREATE TABLE NN_NN.CANCELACION_TURNO
(
	motivo [varchar] (255) not null,
	nro_turno [numeric](18, 0) not null,
	--tipo_cancelacion [numeric](18, 0) not null
)



CREATE TABLE NN_NN.CONSULTA
(
	diagnostico [varchar] (255) not null,
	sintomas [varchar] (255) not null,
	fecha_atencion [datetime],
	nro_bono_consulta [numeric](18, 0) not null,
	nro_turno [numeric](18, 0) not null
)


CREATE TABLE NN_NN.CONSULTA_BONO_FARMACIA
(
	nro_bono_farmacia [numeric](18, 0) not null,
	nro_turno [numeric](18, 0) not null,
	nro_bono_consulta [numeric](18, 0) not null
)


/*************************************************************************************
*                    MIGRATION                                                          *
**************************************************************************************/

/******************************************************
*                    TIPO DOCUMENTO                         *
*******************************************************/

INSERT INTO 
	NN_NN.TIPO_DOCUMENTO (descripcion)
VALUES 
	('dni')

/******************************************************
*                    ESTADO CIVIL                     *
*******************************************************/

INSERT INTO 
	NN_NN.ESTADO_CIVIL (descripcion)
VALUES 
	('single')

INSERT INTO 
	NN_NN.ESTADO_CIVIL (descripcion)
VALUES 
	('married')

INSERT INTO 
	NN_NN.ESTADO_CIVIL (descripcion)
VALUES 
	('widower')

INSERT INTO 
	NN_NN.ESTADO_CIVIL (descripcion)
VALUES 
	('concubinage')

INSERT INTO 
	NN_NN.ESTADO_CIVIL (descripcion)
VALUES 
	('divorced')


/******************************************************
*                    DIA                              *
*******************************************************/
INSERT INTO 
	NN_NN.DIA (descripcion)
VALUES 
	('sunday')
	
INSERT INTO 
	NN_NN.DIA (descripcion)
VALUES 
	('monday')

INSERT INTO 
	NN_NN.DIA (descripcion)
VALUES 
	('tuesday')

INSERT INTO 
	NN_NN.DIA (descripcion)
VALUES 
	('wednesday')

INSERT INTO 
	NN_NN.DIA (descripcion)
VALUES 
	('thursday')

INSERT INTO 
	NN_NN.DIA (descripcion)
VALUES 
	('friday')

INSERT INTO 
	NN_NN.DIA (descripcion)
VALUES 
	('saturday')


/******************************************************
*                    AFILIADO                         *
*******************************************************/

INSERT INTO 
	NN_NN.AFILIADO(apellido, nombre, codigo_documento, documento, direccion, fecha_nac, telefono, mail,  cod_plan)
SELECT DISTINCT 
	Paciente_Apellido, Paciente_Nombre, 1, Paciente_Dni, Paciente_Direccion, Paciente_Fecha_Nac, Paciente_Telefono, Paciente_Mail, Plan_Med_Codigo
FROM 
	gd_esquema.Maestra


/******************************************************
*                    BONOS                            *
*******************************************************/

-- turno -> compra bono consulta ó compra bono farmacia -> medicamento

-- bonos consulta

INSERT INTO 
	NN_NN.BONO_CONSULTA(fecha_compra, numero, fecha_impresion, nro_afiliado)
SELECT DISTINCT 
	 M.Compra_Bono_Fecha, M.Bono_Consulta_Numero, M.Bono_Consulta_Fecha_Impresion, A.numero
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
	NN_NN.BONO_FARMACIA(fecha_compra, numero, fecha_impresion, nro_afiliado)
SELECT DISTINCT 
	 M.Compra_Bono_Fecha, M.Bono_Farmacia_Numero, M.Bono_Farmacia_Fecha_Impresion, A.numero
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
INSERT INTO 
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


/******************************************************
*                    MEDICAMENTOS                     *
*******************************************************/
INSERT INTO 
	NN_NN.MEDICAMENTO(descripcion, nro_bono_farmacia)
SELECT DISTINCT 
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
*                    PLAN                             *
*******************************************************/

INSERT INTO 
	NN_NN.PLAN_MEDICO(codigo, descripcion, precio_bono_consulta, precio_bono_farmacia)
SELECT DISTINCT  
	Plan_Med_Codigo, Plan_Med_Descripcion, Plan_Med_Precio_Bono_Consulta, Plan_Med_Precio_Bono_Farmacia 
FROM 
	gd_esquema.Maestra

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
*                    TURNO                            *
*******************************************************/

INSERT INTO 
	NN_NN.TURNO(numero, fecha, nro_profesional, nro_afiliado, nro_day)
SELECT DISTINCT   
	M.Turno_Numero, M.Turno_Fecha, P.numero, A.numero, datepart(dw,Turno_Fecha)
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
	


/*************************************************************************************
*                    CONSTRAINT                                                      *
**************************************************************************************/

ALTER TABLE NN_NN.AFILIADO ADD CONSTRAINT PK_AFILIADO_numero PRIMARY KEY (numero);
ALTER TABLE NN_NN.ESTADO_CIVIL ADD CONSTRAINT PK_ESTADO_CIVIL_codigo PRIMARY KEY (codigo);
ALTER TABLE NN_NN.PLAN_MEDICO ADD CONSTRAINT PK_PLAN_MEDICO_codigo PRIMARY KEY (codigo);
ALTER TABLE NN_NN.TIPO_DOCUMENTO ADD CONSTRAINT PK_TIPO_DOCUMENTO_codigo PRIMARY KEY (codigo);
ALTER TABLE NN_NN.BONO_CONSULTA ADD CONSTRAINT PK_BONO_CONSULTA_numero PRIMARY KEY (numero);
ALTER TABLE NN_NN.BONO_FARMACIA ADD CONSTRAINT PK_BONO_FARMACIA_numero PRIMARY KEY (numero);
ALTER TABLE NN_NN.PROFESIONAL ADD CONSTRAINT PK_PROFESIONAL_numero PRIMARY KEY (numero);
ALTER TABLE NN_NN.AGENDA ADD CONSTRAINT PK_AGENDA_numero PRIMARY KEY (numero);
ALTER TABLE NN_NN.DIA ADD CONSTRAINT PK_DIA_codigo PRIMARY KEY (codigo);
ALTER TABLE NN_NN.ESPECIALIDAD ADD CONSTRAINT PK_ESPECIALIDAD_codigo PRIMARY KEY (codigo);
ALTER TABLE NN_NN.TIPO_ESPECIALIDAD ADD CONSTRAINT PK_TIPO_ESPECIALIDAD_codigo PRIMARY KEY (codigo);
ALTER TABLE NN_NN.TURNO ADD CONSTRAINT PK_TURNO_numero PRIMARY KEY (numero);

ALTER TABLE NN_NN.AFILIADO ADD CONSTRAINT FK_AFILIADO_cod_estado_civil FOREIGN KEY (cod_estado_civil)
	REFERENCES NN_NN.ESTADO_CIVIL (codigo);
ALTER TABLE NN_NN.AFILIADO ADD CONSTRAINT FK_AFILIADO_cod_plan FOREIGN KEY (cod_plan)
	REFERENCES NN_NN.PLAN_MEDICO (codigo);
ALTER TABLE NN_NN.AFILIADO ADD CONSTRAINT FK_AFILIADO_codigo_documento FOREIGN KEY (codigo_documento)
	REFERENCES NN_NN.TIPO_DOCUMENTO (codigo);
ALTER TABLE NN_NN.BONO_CONSULTA ADD CONSTRAINT FK_CONSULTA_nro_afiliado FOREIGN KEY (nro_afiliado)
	REFERENCES NN_NN.AFILIADO (numero);	
ALTER TABLE NN_NN.BONO_FARMACIA ADD CONSTRAINT FK_BONO_FARMACIA_nro_afiliado FOREIGN KEY (nro_afiliado)
	REFERENCES NN_NN.AFILIADO (numero);
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
ALTER TABLE NN_NN.CAMBIO_PLAN ADD CONSTRAINT FK_CAMBIO_PLAN_nro_afiliado FOREIGN KEY (nro_afiliado)
	REFERENCES NN_NN.AFILIADO (numero);
ALTER TABLE NN_NN.CONSULTA ADD CONSTRAINT FK_CONSULTA_nro_bono_consulta FOREIGN KEY (nro_bono_consulta)
	REFERENCES NN_NN.BONO_CONSULTA (numero);
ALTER TABLE NN_NN.CONSULTA ADD CONSTRAINT FK_CONSULTA_nro_turno FOREIGN KEY (nro_turno)
	REFERENCES NN_NN.TURNO (numero);
ALTER TABLE NN_NN.MEDICAMENTO ADD CONSTRAINT FK_MEDICAMENTO_nro_bono_farmacia FOREIGN KEY (nro_bono_farmacia)
	REFERENCES NN_NN.BONO_FARMACIA (numero);
ALTER TABLE NN_NN.CANCELACION_TURNO ADD CONSTRAINT FK_CANCELACION_TURNO_nro_turno FOREIGN KEY (nro_turno)
	REFERENCES NN_NN.TURNO (numero);	
ALTER TABLE NN_NN.CONSULTA_BONO_FARMACIA ADD CONSTRAINT FK_CONSULTA_BONO_FARMACIA_nro_bono_farmacia FOREIGN KEY (nro_bono_farmacia)
	REFERENCES NN_NN.BONO_FARMACIA (numero);
ALTER TABLE NN_NN.CONSULTA_BONO_FARMACIA ADD CONSTRAINT FK_CONSULTA_BONO_FARMACIA_nro_bono_consulta  FOREIGN KEY (nro_bono_consulta )
	REFERENCES NN_NN.BONO_CONSULTA (numero);
ALTER TABLE NN_NN.TURNO ADD CONSTRAINT FK_TURNO_nro_afiliado FOREIGN KEY (nro_afiliado)
	REFERENCES NN_NN.AFILIADO (numero);
ALTER TABLE NN_NN.TURNO ADD CONSTRAINT FK_TURNO_nro_profesional FOREIGN KEY (nro_profesional)
	REFERENCES NN_NN.PROFESIONAL(numero);

