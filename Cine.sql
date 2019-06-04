CREATE DATABASE cine;

USE cine;

CREATE TABLE usuario(idTaquillero INT IDENTITY PRIMARY KEY NOT NULL, nombre VARCHAR(50), 
apPaterno VARCHAR(50), apMaterno VARCHAR(50), telTaquillero VARCHAR (11), tipoUsuario VARCHAR(20),contraseña VARCHAR(20));


CREATE TABLE pelicula(idPelicula INT PRIMARY KEY NOT NULL,nombre VARCHAR(50));

CREATE TABLE funcion(idFuncion VARCHAR(50), fechaFuncion VARCHAR(50), horaFuncion VARCHAR(50),
asientosDisponibles INT, asientosOcupados INT, asientoAsignado VARCHAR(3), diagrama VARCHAR(220),
precio INT, fk_idPelicula INT FOREIGN KEY REFERENCES pelicula(idPelicula), 
CONSTRAINT PK_FUNCION PRIMARY KEY(idFuncion, precio));

CREATE TABLE ventas(idVenta INT PRIMARY KEY IDENTITY, cantidad INT, hora VARCHAR(50), importe NUMERIC,
fk_idTaquillero INT FOREIGN KEY REFERENCES usuario(idTaquillero), idFuncion VARCHAR(50), precio INT,
CONSTRAINT fk_idFuncion FOREIGN KEY(idFuncion,precio) REFERENCES funcion(idFuncion,precio));

GO

CREATE PROCEDURE compraBoletos
@idFuncion VARCHAR(50)
AS
UPDATE funcion SET asientosDisponibles = asientosDisponibles-1,   asientosOcupados = asientosOcupados + 1 WHERE @idFuncion = idFuncion 
GO

--GO
--
--
--
--
--