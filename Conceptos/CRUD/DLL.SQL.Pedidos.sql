-- Crear la tabla de pedidos
CREATE TABLE pedidos (
  id INT AUTO_INCREMENT PRIMARY KEY,
  cliente VARCHAR(50) NOT NULL,
  fecha DATE NOT NULL,
  producto VARCHAR(50) NOT NULL,
  cantidad INT NOT NULL,
  precio DECIMAL(10,2) NOT NULL
);

-- Crear pedidos
INSERT INTO pedidos (cliente, fecha, producto, cantidad, precio)
VALUES
  ('Juan Perez', '2023-06-16', 'Camisa roja', 2, 20.50),
  ('Ana Garcia', '2023-06-15', 'Pantalón azul', 1, 35.00),
  ('Luis Gomez', '2023-06-15', 'Vestido verde', 2, 40.00),
  ('Maria Hernandez', '2023-06-14', 'Calcetines de Bob Toronja', 12, 5.80),
  ('Carlos Rodriguez', '2023-06-14', 'Chaqueta para el frío', 1, 75.50),
  ('Laura Martinez', '2023-06-13', 'Blusa azul', 3, 30.20),
  ('Pedro Sanchez', '2023-06-13', 'Jeans de vaquero', 6, 50.00),
  ('Sofia Ramirez', '2023-06-12', 'Sudadera para el ejercicio', 2, 25.80),
  ('Diego Torres', '2023-06-12', 'Gorra de Cocodrilos', 1, 12.80),
  ('Fernanda Castro', '2023-06-11', 'Abrigo', 2, 90.00);

-- Leer todos los pedidos
SELECT * FROM pedidos;

-- Leer pedido por ID
SELECT * FROM pedidos WHERE id = 3;

-- Editar/Actualizar pedido
UPDATE pedidos SET cantidad = 4, precio = 80.00 WHERE id = 5;

-- Eliminar pedido
DELETE FROM pedidos WHERE id IN (2, 6, 8);