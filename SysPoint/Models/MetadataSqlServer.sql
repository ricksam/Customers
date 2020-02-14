create table Supervisor(
  Id INTEGER NOT NULL primary key identity,
  Nome varchar(60),
  Email varchar(200),
  Senha varchar(200)
);

create table Empresa(
  Id INTEGER NOT NULL primary key identity,
  Nome varchar(60),
  Endereco varchar(60)
);

create table Colaboradores (
  Id        INTEGER NOT NULL primary key identity, 
  Nome        VARCHAR(60), 
  Senha        VARCHAR(20), 
  Unidade        VARCHAR(40), 
  Turno        VARCHAR(60), 
  Id_Empresa        INTEGER, 
  Id_Supervisor        INTEGER
  constraint FK_COLABORADORES_EMPRESA foreign key (ID_EMPRESA) references EMPRESA (ID),  
  constraint FK_COLABORADORES_SUPERVISOR foreign key (ID_SUPERVISOR) references Supervisor (ID) 
);
 
create table Fotos (
  Id        INTEGER NOT NULL primary key identity, 
  Foto        TEXT, 
  Data        DATETIME
);
 
create table LogError (
  Id        INTEGER NOT NULL primary key identity, 
  DtLog        DATETIME NOT NULL, 
  Method        VARCHAR(60) NOT NULL, 
  Id_User        INTEGER, 
  Request        TEXT NOT NULL, 
  Error        TEXT NOT NULL
);
 
create table RegistroPonto (
  Id        INTEGER NOT NULL primary key identity, 
  Id_Colaborador        INTEGER, 
  Registro        DATETIME, 
  Latitude        NUMERIC(18, 4), 
  Longitude        NUMERIC(18, 4), 
  Log        VARCHAR(255), 
  Id_Foto        INTEGER NOT NULL
  constraint FK_REGPCOLAB foreign key (ID_COLABORADOR) references COLABORADORES (ID),  
  constraint FK_PONTO_FOTO foreign key (ID_FOTO) references FOTOS (ID) 
);