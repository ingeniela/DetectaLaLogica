// Importar el módulo http para trabajar con servidores web
var http = require('http');

// Crear un servidor web
http.createServer(function (req, res) {
  // Cuando se reciba una solicitud, ejecutar esta función
  // Enviar un código de estado 200 (OK) y especificar que el contenido es de tipo HTML
  res.writeHead(200, {'Content-Type': 'text/html'});
  // Enviar el mensaje "Hello World!" como respuesta al cliente
  res.end('Hello World!');

}).listen(8080);
// Escuchar en el puerto 8080 (http://localhost:8080) para esperar solicitudes entrantes
