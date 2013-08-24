var fs = require('fs');

fs.readFile('content.txt', 'utf-8', function onFileRead(err, data) {
	if (err) throw err;

	console.log(data);
});