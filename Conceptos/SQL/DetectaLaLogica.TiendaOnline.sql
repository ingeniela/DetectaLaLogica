-- Copia y pega esto en un tab de Sql donde pueda ejecutar queries, va a crear el schema, dos tablas y va a hacer una inserción en ambas tablas --

-- Crear el schema tienda_online
CREATE SCHEMA tienda_online;

-- Seleccionar el schema tienda_online
USE tienda_online;

-- Crear la tabla productos
CREATE TABLE productos (
  id INT NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(50) NOT NULL,
  precio DECIMAL(10, 2) NOT NULL,
  PRIMARY KEY (id)
);

-- Insertar un registro en la tabla productos
INSERT INTO productos (nombre, precio)
VALUES ('Producto 1', 10.50);

-- Crear la tabla clientes
CREATE TABLE clientes (
  id INT NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(50) NOT NULL,
  apellido VARCHAR(50) NOT NULL,
  fechaDeNacimiento DATE NOT NULL,
  PRIMARY KEY (id)
);

-- Insertar un registro en la tabla clientes
INSERT INTO clientes (nombre, apellido, fechaDeNacimiento)
VALUES ('Juan', 'Pérez', '1990-05-15');