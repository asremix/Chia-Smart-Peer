const fetch = require('node-fetch');
const country_list = [ 
    "Taiwan",
    "Hong Kong",
    "Singapore",
    "Thailand",
    "Indonesia",
    "Australia",
    "Vietnam",
    "Malaysia",
    "China",
]
//console.log("country_list:",country_list)
const fs = require('fs');
const myConsole = new console.Console(fs.createWriteStream('./NodeListF.txt'));
let conn_counter = 0;
fetch('https://chia.powerlayout.com/nodes?block_height=true&geoip=true')
    .then(res => res.json())
    .then(data => {
        if(data.nodes){
            data.nodes.forEach( ( val )=> {
               //if( country_list.indexOf(val.geo.country) != -1 ){
                    console.log(val.ip,":",val.port)
                    myConsole.log(val.ip,":",val.port);

                    conn_counter++;
               //}
            });
            console.log("Found:",conn_counter)
        }
    });

