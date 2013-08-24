module.exports = function(config) {
    config.set({
        basePath: '../',
        frameworks: ['jasmine'],
        browsers: ['Firefox'],
        urlRoot: '/__karma/',
        autoWatch: false,
        singleRun: true,
        junitReporter: {
            outputFile: 'test_out/e2e.xml',
            suite: 'e2e'
        },
        proxies: {
            '/': 'http://localhost:8000/'
        },
        files: [
            'test/e2e/**/*.js'
        ]
    });
};
