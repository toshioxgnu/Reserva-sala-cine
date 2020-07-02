/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2016                    */
/* Created on:     02-07-2020 19:18:42                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PERFILESJOSEGONZALEZ') and o.name = 'FK_PERFILES_REFERENCE_ACCIONES')
alter table PERFILESJOSEGONZALEZ
   drop constraint FK_PERFILES_REFERENCE_ACCIONES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACCIONESJOSEGONZALEZ')
            and   type = 'U')
   drop table ACCIONESJOSEGONZALEZ
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PERFILESJOSEGONZALEZ')
            and   type = 'U')
   drop table PERFILESJOSEGONZALEZ
go

/*==============================================================*/
/* Table: ACCIONESJOSEGONZALEZ                                  */
/*==============================================================*/
create table ACCIONESJOSEGONZALEZ (
   NUM                  int                  not null,
   CLAVE                varchar(13)          null,
   INICIOSESION         date                 null,
   FINSESION            date                 null,
   ACCION               varchar(50)          null,
   ACCIONF              varchar(50)          null,
   constraint PK_ACCIONESJOSEGONZALEZ primary key (NUM)
)
go

/*==============================================================*/
/* Table: PERFILESJOSEGONZALEZ                                  */
/*==============================================================*/
create table PERFILESJOSEGONZALEZ (
   RUT                  varchar(10)          not null,
   NUM                  int                  null,
   NOMBRE               varchar(30)          null,
   APPAT                varchar(30)          null,
   APMAT                varchar(30)          null,
   CLAVE                varchar(13)          null,
   constraint PK_PERFILESJOSEGONZALEZ primary key (RUT)
)
go

alter table PERFILESJOSEGONZALEZ
   add constraint FK_PERFILES_REFERENCE_ACCIONES foreign key (NUM)
      references ACCIONESJOSEGONZALEZ (NUM)
go

