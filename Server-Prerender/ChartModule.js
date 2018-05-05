
module.exports = function(callback) {
    let message = 'Hello world from Node at ' + new Date().toString();
    callback(null, message);
}