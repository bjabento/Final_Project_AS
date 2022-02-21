/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     21/02/2022 17:07:56                          */
/*==============================================================*/


if exists (select 1
            from  sysobjects
           where  id = object_id('ADMINISTRADOR')
            and   type = 'U')
   drop table ADMINISTRADOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DISPONIVEL')
            and   type = 'U')
   drop table DISPONIVEL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GERE')
            and   type = 'U')
   drop table GERE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REQUISITANTE')
            and   type = 'U')
   drop table REQUISITANTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RESERVA')
            and   type = 'U')
   drop table RESERVA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SALA')
            and   type = 'U')
   drop table SALA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SLOT_HORARIO')
            and   type = 'U')
   drop table SLOT_HORARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UTILIZADOR')
            and   type = 'U')
   drop table UTILIZADOR
go

/*==============================================================*/
/* Table: UTILIZADOR                                            */
/*==============================================================*/
create table UTILIZADOR (
   EMAIL                text                 not null,
   NOME                 text                 not null,
   APELIDO              text                 not null,
   COD_POSTAL           text                 not null,
   RUA                  text                 not null,
   CIDADE               text                 not null,
   PAIS                 text                 not null,
   constraint PK_UTILIZADOR primary key nonclustered (EMAIL)
)
go

/*==============================================================*/
/* Table: ADMINISTRADOR                                         */
/*==============================================================*/
create table ADMINISTRADOR (
   EMAIL                text                 not null,
   ID_ADMIN             int                  not null,
   NOME                 text                 not null,
   APELIDO              text                 not null,
   COD_POSTAL           text                 not null,
   RUA                  text                 not null,
   CIDADE               text                 not null,
   PAIS                 text                 not null,
   constraint PK_ADMINISTRADOR primary key nonclustered (EMAIL, ID_ADMIN),
   constraint FK_ADMINIST_TIPO_UTILIZAD foreign key (EMAIL)
      references UTILIZADOR (EMAIL)
)
go

/*==============================================================*/
/* Table: SALA                                                  */
/*==============================================================*/
create table SALA (
   ID_SALA              int                  not null,
   CAPACIDADE           int                  not null,
   ALOC_MAX             int                  not null,
   constraint PK_SALA primary key nonclustered (ID_SALA)
)
go

/*==============================================================*/
/* Table: SLOT_HORARIO                                          */
/*==============================================================*/
create table SLOT_HORARIO (
   ID_SLOT              int                  not null,
   HORA_SLOT            int                  not null,
   constraint PK_SLOT_HORARIO primary key nonclustered (ID_SLOT)
)
go

/*==============================================================*/
/* Table: DISPONIVEL                                            */
/*==============================================================*/
create table DISPONIVEL (
   ID_SALA              int                  not null,
   ID_SLOT              int                  not null,
   constraint PK_DISPONIVEL primary key (ID_SALA, ID_SLOT),
   constraint FK_DISPONIV_DISPONIVE_SALA foreign key (ID_SALA)
      references SALA (ID_SALA),
   constraint FK_DISPONIV_DISPONIVE_SLOT_HOR foreign key (ID_SLOT)
      references SLOT_HORARIO (ID_SLOT)
)
go

/*==============================================================*/
/* Table: GERE                                                  */
/*==============================================================*/
create table GERE (
   EMAIL                text                 not null,
   ID_ADMIN             int                  not null,
   ID_SALA              int                  not null,
   constraint PK_GERE primary key (EMAIL, ID_ADMIN, ID_SALA),
   constraint FK_GERE_GERE_ADMINIST foreign key (EMAIL, ID_ADMIN)
      references ADMINISTRADOR (EMAIL, ID_ADMIN),
   constraint FK_GERE_GERE2_SALA foreign key (ID_SALA)
      references SALA (ID_SALA)
)
go

/*==============================================================*/
/* Table: REQUISITANTE                                          */
/*==============================================================*/
create table REQUISITANTE (
   EMAIL                text                 not null,
   ID_REQ               int                  not null,
   NOME                 text                 not null,
   APELIDO              text                 not null,
   COD_POSTAL           text                 not null,
   RUA                  text                 not null,
   CIDADE               text                 not null,
   PAIS                 text                 not null,
   constraint PK_REQUISITANTE primary key nonclustered (EMAIL, ID_REQ),
   constraint FK_REQUISIT_TIPO2_UTILIZAD foreign key (EMAIL)
      references UTILIZADOR (EMAIL)
)
go

/*==============================================================*/
/* Table: RESERVA                                               */
/*==============================================================*/
create table RESERVA (
   ID_RESERVA           int                  not null,
   ID_SLOT              int                  not null,
   EMAIL                text                 not null,
   ID_REQ               int                  not null,
   ID_SALA              int                  not null,
   DATA                 datetime             not null,
   DATA_RESERVA         datetime             not null,
   constraint PK_RESERVA primary key nonclustered (ID_RESERVA),
   constraint FK_RESERVA_FAZ_REQUISIT foreign key (EMAIL, ID_REQ)
      references REQUISITANTE (EMAIL, ID_REQ),
   constraint FK_RESERVA_ASSOCIADO_SALA foreign key (ID_SALA)
      references SALA (ID_SALA),
   constraint FK_RESERVA_OCUPA_SLOT_HOR foreign key (ID_SLOT)
      references SLOT_HORARIO (ID_SLOT)
)
go

