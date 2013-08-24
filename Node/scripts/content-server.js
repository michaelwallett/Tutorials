var http = require('http'),
	fs = require('fs'),
	url = require('url');

http.createServer(function (req, res) {
  var urlParts = url.parse(req.url),
      fileName = urlParts.pathname.substring(1);

  fs.exists(fileName, function(exists) {
  	if (exists) {
  		res.writeHead(200, {'Content-Type': 'text/plain'});
  		fs.createReadStream(fileName).pipe(res);
  	}
  	else {
  		res.writeHead(400);
  		res.end('Not found.');
  	}
  });
}).listen(1337, '127.0.0.1');

console.log('Server running at http://127.0.0.1:1337/');