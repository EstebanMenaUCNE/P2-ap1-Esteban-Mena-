CREATE TABLE Rentenciones(
RetencionId int IDENTITY(1,1) PRIMARY KEY,
Descripcion varchar(255),
Valor int
);

CREATE TABLE TiposEmails(
TipoId int IDENTITY(1,1) PRIMARY KEY,
Descripcion varchar(255)
);

CREATE TABLE Empleados(
EmpleadoId int IDENTITY(1,1) PRIMARY KEY,
Nombres varchar(100),
FechaNacimiento date,
Sueldo float
);

CREATE TABLE EmpleadosRetenciones(
Id int IDENTITY(1,1) PRIMARY KEY,
EmpleadoId int REFERENCES Empleados(EmpleadoId),
RetencionId int REFERENCES Retenciones(RetencionId)
);

CREATE TABLE EmpleadosEmails(
Id int IDENTITY(1,1) PRIMARY KEY,
EmpleadoId int REFERENCES Empleados(EmpleadoId),
TipoId int REFERENCES TiposEmails(TipoId),
Email varchar(255)
);