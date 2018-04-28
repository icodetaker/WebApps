const path = require('path');

const config = {
  entry: {'main-server': './ClientApp/boot-server.ts'},
  resolve: {
      extensions: ['.js', '.ts']
  },
  output: {
    path: path.join(__dirname, '/ClientApp/dist'),
    filename: '[name].js',
    libraryTarget: 'commonjs'
  },
  module: {
    rules: [
    ]
  },
  target: 'node',
  devtool: 'ininline-source-map'
};

module.exports = config;