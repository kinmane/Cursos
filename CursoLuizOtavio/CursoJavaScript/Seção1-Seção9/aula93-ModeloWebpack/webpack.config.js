const path = require("path");

module.exports = {
  mode: "development",
  entry: "./src/index.js",
  output: {
    path: path.resolve(__dirname, "public", "assets", "js"),
    filename: 'bundle.js'
  },
  module: {
    rule: [{
      exclude: /node_modules/,
      test: /\.js$/,
      use: {
        loader: 'babel-loader',
        option: {
          presets: ['@babel/env']
        }
      }
    }]
  },
  devtool: 'source-map'
};
