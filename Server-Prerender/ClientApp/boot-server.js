const prerendering = require('aspnet-prerendering');

module.exports = prerendering.createServerRenderer(function (params) {
    return new Promise(function (resolve, reject){
        var result =  "<h1> Hello World </h1>"
                    + "<p> Current time in node: " + new Date() + "</p>"
                    + "<p> URL: " + params.location.path + "</>"
                    + "<p> Data (IsAdministor): " + params.data.isAdministor + "</p>"
                    + "<p> Data (Cookies): " + params.data.cookies + "</p>";

        resolve({html : result});
    })
});