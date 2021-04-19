var webpack = require('webpack');

module.exports = {
    entry: {
        'app': './app/main.ts'
    },

    resolve: {
        extensions: ['.js']
    },
    output: {
        path: __dirname + '/dist',
        publicPath: '/',
        filename: 'app.js',
    }
};