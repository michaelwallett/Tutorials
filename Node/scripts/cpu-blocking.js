var http = require('http');

http.createServer(function (req, res) {
  res.writeHead(200, {'Content-Type': 'text/plain'});

  res.end(fibonacci(40).toString());

}).listen(1337, '127.0.0.1');

console.log('Server running at http://127.0.0.1:1337/');

function fibonacci(n) {
  if (n < 2)
    return 1;
  else
    return fibonacci(n-2) + fibonacci(n-1);
}