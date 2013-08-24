module.exports = function(config) {
    config.set({
        basePath: '../',
        frameworks: ['jasmine'],
        browsers: ['Firefox'],
        autoWatch: true,
        junitReporter: {
            outputFile: 'test_out/unit.xml',
            suite: 'unit'
        },
        files: [
            'app/lib/angular/angular.js',
            'app/lib/angular/angular-*.js',
            'test/lib/angular/angular-mocks.js',
            'app/js/**/*.js',
            'test/unit/**/*.js'
        ]
    });
};