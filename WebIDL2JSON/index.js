const fs = require('fs');
var pj = require('./parseJSON');


const IDLFolder = './IDL/';

function mergeDeep(...objects) {
    const isObject = obj => obj && typeof obj === 'object';

    return objects.reduce((prev, obj) => {
        Object.keys(obj).forEach(key => {
            const pVal = prev[key];
            const oVal = obj[key];

            if (Array.isArray(pVal) && Array.isArray(oVal)) {
                prev[key] = pVal.concat(...oVal);
            }
            else if (isObject(pVal) && isObject(oVal)) {
                prev[key] = mergeDeep(pVal, oVal);
            }
            else {
                prev[key] = oVal;
            }
        });

        return prev;
    }, {});
}

var mergedData = {};

var dataFiles = [];

fs.readdir(IDLFolder, (err, files) => {
    files.forEach(file => {

        let rawdata = fs.readFileSync(IDLFolder + file);

        let data = JSON.parse(rawdata);

        dataFiles.push({
            name: file,
            data: data
        })

        mergedData = mergeDeep(mergedData, data)
    });


    let data = JSON.stringify(mergedData, null, 4);
    fs.writeFileSync('Traces/IDL.json', data);

});
