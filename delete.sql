use GD2C2013
go

ALTER TABLE NN_NN.AFILIADO DROP CONSTRAINT FK_AFILIADO_cod_estado_civil
ALTER TABLE NN_NN.AFILIADO DROP CONSTRAINT FK_AFILIADO_cod_plan
ALTER TABLE NN_NN.AFILIADO DROP CONSTRAINT FK_AFILIADO_codigo_documento
ALTER TABLE NN_NN.BONO_CONSULTA DROP CONSTRAINT FK_BONO_CONSULTA_nro_afiliado
ALTER TABLE NN_NN.BONO_FARMACIA DROP CONSTRAINT FK_BONO_FARMACIA_nro_afiliado
ALTER TABLE NN_NN.ESPECIALIDAD DROP CONSTRAINT FK_ESPECIALIDAD_cod_tipo_especialidad
ALTER TABLE NN_NN.PROFESIONAL_ESPECIALIDAD DROP CONSTRAINT FK_PROFESIONAL_ESPECIALIDAD_nro_profesional
ALTER TABLE NN_NN.PROFESIONAL_ESPECIALIDAD DROP CONSTRAINT FK_PROFESIONAL_ESPECIALIDAD_cod_especialidad
ALTER TABLE NN_NN.AGENDA DROP CONSTRAINT FK_AGENDA_nro_profesional
ALTER TABLE NN_NN.DIA_ATENCION DROP CONSTRAINT FK_DIA_ATENCION_nro_agenda
ALTER TABLE NN_NN.DIA_ATENCION DROP CONSTRAINT FK_DIA_ATENCION_codigo_dia
ALTER TABLE NN_NN.CAMBIO_PLAN DROP CONSTRAINT FK_CAMBIO_PLAN_nro_afiliado
ALTER TABLE NN_NN.CONSULTA DROP CONSTRAINT FK_CONSULTA_nro_bono_consulta
ALTER TABLE NN_NN.CONSULTA DROP CONSTRAINT FK_CONSULTA_nro_turno
ALTER TABLE NN_NN.MEDICAMENTO DROP CONSTRAINT FK_MEDICAMENTO_nro_bono_farmacia
ALTER TABLE NN_NN.CANCELACION_TURNO DROP CONSTRAINT FK_CANCELACION_TURNO_nro_turno
ALTER TABLE NN_NN.CONSULTA_BONO_FARMACIA DROP CONSTRAINT FK_CONSULTA_BONO_FARMACIA_nro_bono_farmacia
ALTER TABLE NN_NN.CONSULTA_BONO_FARMACIA DROP CONSTRAINT FK_CONSULTA_BONO_FARMACIA_nro_bono_consulta
ALTER TABLE NN_NN.TURNO DROP CONSTRAINT FK_TURNO_nro_profesional
ALTER TABLE NN_NN.TURNO DROP CONSTRAINT FK_TURNO_nro_afiliado
ALTER TABLE NN_NN.REGISTRO_COMPRA_BONO DROP CONSTRAINT FK_REGISTRO_COMPRA_nro_afiliado

drop table NN_NN.PROFESIONAL_ESPECIALIDAD
drop table NN_NN.ROL_FUNCIONALIDAD
drop table NN_NN.USUARIO_ROL
drop table NN_NN.ROL
drop table NN_NN.FUNCIONALIDAD
drop table NN_NN.CAMBIO_PLAN
drop table NN_NN.CONSULTA
--
drop table NN_NN.MEDICAMENTO
drop table NN_NN.CANCELACION_TURNO
drop table NN_NN.TURNO
drop table NN_NN.DIA_ATENCION
drop table NN_NN.ESPECIALIDAD
drop table NN_NN.TIPO_ESPECIALIDAD
drop table NN_NN.AGENDA
drop table NN_NN.DIA
drop table NN_NN.BONO_CONSULTA
drop table NN_NN.BONO_FARMACIA
drop table NN_NN.PROFESIONAL
drop table NN_NN.AFILIADO
drop table NN_NN.PLAN_MEDICO
drop table NN_NN.ESTADO_CIVIL
drop table NN_NN.TIPO_DOCUMENTO
drop table NN_NN.TIPO_CANCELACION
drop table NN_NN.USUARIO
drop table NN_NN.RECETA
drop table NN_NN.RECETA_BONO_FARMACIA
drop table NN_NN.REGISTRO_COMPRA_BONO
drop table NN_NN.SECUENCIA_NUMERO_AFILIADO
drop table NN_NN.CONSULTA_BONO_FARMACIA

DROP PROCEDURE NN_NN.SP_ADD_AFILIADO
DROP PROCEDURE NN_NN.SP_ADD_PROFESIONAL
DROP PROCEDURE NN_NN.SP_ADD_ESPECIALIDAD
DROP PROCEDURE NN_NN.SP_ADD_AGENDA
DROP PROCEDURE NN_NN.SP_ADD_DIA_ATENCION
DROP PROCEDURE NN_NN.SP_ADD_BONO_CONSULTA
DROP PROCEDURE NN_NN.SP_ADD_BONO_FARMACIA
DROP PROCEDURE NN_NN.SP_BUY_BONO_CONSULTA
DROP PROCEDURE NN_NN.SP_BUY_BONO_FARMACIA
--DROP PROCEDURE NN_NN.SP_LLEGADA_ATENCION_MEDICA
--DROP PROCEDURE NN_NN.NUEVO_ROL
DROP PROCEDURE NN_NN.sp_add_rol
DROP PROCEDURE NN_NN.sp_modificar_rol
DROP PROCEDURE NN_NN.sp_listar_rol_funcionalidad
DROP PROCEDURE NN_NN.SP_LISTAR_AGENDA_DIAS;
DROP PROCEDURE NN_NN.sp_generar_agenda;
DROP PROCEDURE NN_NN.SP_LISTA_TURNOS_LIBRE;
DROP PROCEDURE NN_NN.sp_listar_profesional;
DROP PROCEDURE NN_NN.sp_listar_turno;
DROP PROCEDURE NN_NN.SP_BUY_CANT_BONO_CONSULTA;
DROP PROCEDURE NN_NN.SP_BUY_CANT_BONO_FARMACIA;
DROP PROCEDURE NN_NN.SP_CHEQUEAR_EXISTENCIA_BONO_FARMACIA
DROP PROCEDURE NN_NN.SP_CHEQUEAR_PERTENENCIA_BONO_FARMACIA
DROP PROCEDURE NN_NN.SP_CHEQUEAR_VENCIMIENTO_BONO_FARMACIA
DROP PROCEDURE NN_NN.sp_listar_afiliado
DROP PROCEDURE NN_NN.sp_listar_especialidad
DROP PROCEDURE NN_NN.sp_listar_plan
DROP PROCEDURE NN_NN.SP_LOGIN
DROP PROCEDURE NN_NN.SP_RESERVAR_TURNO
DROP PROCEDURE NN_NN.SP_RETORNA_ULTIMA_AGENDA
DROP PROCEDURE NN_NN.SP_ROLES
DROP PROCEDURE FN_RETURN_ID_AFILIADO

DROP FUNCTION NN_NN.GENERA_USER_NAME


USE GD2C2013


drop schema NN_NN


DECLARE @id_afiliado NUMERIC(18,0)
			exec [NN_NN].FN_RETURN_ID_AFILIADO @id_afiliado OUTPUT;
SELECT @id_afiliado
