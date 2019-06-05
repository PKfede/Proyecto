CREATE DATABASE cine;

USE cine;

CREATE TABLE usuario(idTaquillero INT IDENTITY PRIMARY KEY NOT NULL, nombre VARCHAR(50), 
apPaterno VARCHAR(50), apMaterno VARCHAR(50), telTaquillero VARCHAR (11), tipoUsuario VARCHAR(20),contra VARCHAR(20), nombre_usuario VARCHAR(10));


CREATE TABLE pelicula(idPelicula INT PRIMARY KEY IDENTITY NOT NULL,nombre VARCHAR(50));

CREATE TABLE funcion(idFuncion INT IDENTITY NOT NULL, fechaFuncion VARCHAR(50), horaFuncion VARCHAR(50),
asientosDisponibles INT, asientosOcupados INT, asientoAsignado VARCHAR(3), diagrama VARCHAR(220),
precio INT, fk_idPelicula INT FOREIGN KEY REFERENCES pelicula(idPelicula), 
CONSTRAINT PK_FUNCION PRIMARY KEY(fk_idPelicula, fechaFuncion, horaFuncion));

CREATE TABLE ventas(idVenta INT PRIMARY KEY IDENTITY, cantidad INT, hora VARCHAR(50), importe NUMERIC,
fk_idTaquillero INT FOREIGN KEY REFERENCES usuario(idTaquillero), idFuncion VARCHAR(50), precio INT, idPelicula INT, fechaFuncion VARCHAR(50), horaFuncion VARCHAR(50),
CONSTRAINT fk_Pelicula FOREIGN KEY(idPelicula, fechaFuncion, horaFuncion) REFERENCES funcion(fk_idPelicula,fechaFuncion, horaFuncion));

GO

CREATE PROCEDURE compraBoletos
@idFuncion VARCHAR(50)
AS
UPDATE funcion SET asientosDisponibles = asientosDisponibles-1,   asientosOcupados = asientosOcupados + 1 WHERE @idFuncion = idFuncion 
GO
