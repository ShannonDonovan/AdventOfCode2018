'use strict';

const fs = require('fs')

fs.readFile('txt.txt', (err, data) => {
    if (err) throw err; 
    var input = data.toString();
    var inputarray = input.split("\n");
    console.log(inputarray);
    doStuff(inputarray);
})

function doStuff(input) {
    var dict = {};
    var reg = /#\d* @ (\d+),(\d+): (\d+)x(\d+)\s*/   

    for (var item of input) {

        console.log(item);
        var match = reg.exec(item);

        var maxX = Number(match[3]) + Number(match[1]);
        var maxY = Number(match[4]) + Number(match[2]);

        for (var x = Number(match[1]); x < maxX; x++) {
            for (var y = Number(match[2]); y < maxY; y++) {
                var key = x + ',' + y;
                if (dict[key] == undefined) {
                    dict[key] = 1;
                } else {
                    dict[key]++;
                }
            }
                
        }

    }
    var count = 0;
    for (var key in dict) {
        if (dict[key] != 1) {
            count++;
        }
    }
    console.log(count);
}
