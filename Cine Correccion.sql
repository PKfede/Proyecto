CREATE DATABASE cine;
GO
USE cine;
GO
CREATE TABLE usuario(idTaquillero INT IDENTITY PRIMARY KEY NOT NULL, nombre VARCHAR(50), 
apPaterno VARCHAR(50), apMaterno VARCHAR(50), telTaquillero VARCHAR (11), tipoUsuario VARCHAR(20),contra VARCHAR(20), nombre_usuario VARCHAR(10));


CREATE TABLE pelicula(idPelicula INT PRIMARY KEY IDENTITY NOT NULL,nombre VARCHAR(50));

CREATE TABLE funcion(idFuncion INT IDENTITY NOT NULL, fechaFuncion VARCHAR(50), horaFuncion VARCHAR(50),
asientosDisponibles INT, asientosOcupados INT, asientoAsignado VARCHAR(3), diagrama VARCHAR(220),
precio INT, fk_idPelicula INT FOREIGN KEY REFERENCES pelicula(idPelicula), 
CONSTRAINT PK_FUNCION PRIMARY KEY(fk_idPelicula, fechaFuncion, horaFuncion));

CREATE TABLE ventas(idVenta INT PRIMARY KEY IDENTITY, cantidad_boletos INT, importe NUMERIC, idTaquillero INT,
fk_idTaquillero INT FOREIGN KEY(idTaquillero) REFERENCES usuario(idTaquillero),tarifa INT,
idPelicula INT, fechaFuncion varchar(50),horaFuncion varchar(50),
CONSTRAINT fk_Funcion FOREIGN KEY(idPelicula,fechaFuncion,horaFuncion) REFERENCES funcion(fk_idPelicula, fechaFuncion, horaFuncion));

create table boletoVendido(id int primary key identity, idVenta int foreign key references ventas(idVenta), num_asiento int, fila_asiento varchar(50));

select nombre from pelicula p join funcion f on p.idPelicula = f.fk_idPelicula 
where f.fk_idPelicula in (select idPelicula from ventas v join funcion f on 
v.fechaFuncion = f.fechaFuncion and v.horaFuncion = f.horaFuncion);


GO

CREATE PROCEDURE compraBoletos
@idFuncion VARCHAR(50)
AS
UPDATE funcion SET asientosDisponibles = asientosDisponibles-1,   asientosOcupados = asientosOcupados + 1 WHERE @idFuncion = idFuncion 
GO

