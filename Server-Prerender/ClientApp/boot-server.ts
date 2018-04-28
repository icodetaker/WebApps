

import { createServerRenderer } from 'aspnet-prerendering';

export default createServerRenderer(params => {
    return new Promise(function (resolve, reject){
        const html =  `<h1> Hello World </h1>
                    <p> Current time in node: ${new Date()} </p>
                    <p> URL: ${params.location.path} </p>
                    <p> Data (IsAdministor): ${params.data.isAdministor} </p>
                    <p> Data (Cookies): ${params.data.cookies} </p>`;

        resolve({html});
    })   
});