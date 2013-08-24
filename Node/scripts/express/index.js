var express = require('express'),
	home = require('./routes/home.js');

var app = express();

app.get('/:message?', home.index);

app.listen(3000);