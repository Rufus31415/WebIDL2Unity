const path = require('path');
const fs = require('fs');


function GetNETType(idlType, forPInvoke) {
    switch (idlType) {
        case "boolean":
            return "bool";

        case "EventHandler":
            return "EventHandler";

        case "any":
            return "any";

        case "undefined":
            return "undefined";

        case "unsigned long":
            return "ulong";

        case "double":
            return "float";

        default:
            return forPInvoke ? "IntPtr" : idlType;
    }
}


exports.parseJSON = function (dataFile, mergedData, SourcesFolder) {
    let dataFileName = path.parse(dataFile.name).name;

    let data = dataFile.data;

    let dir = SourcesFolder + dataFileName + "/";

    fs.mkdirSync(dir);

    for (const [_, idlName] of Object.entries(data.idlNames)) {

        let csFile = fs.openSync(dir + idlName.name + ".cs", 'a');
        let jslibFile = fs.openSync(dir + idlName.name + ".jslib", 'a');

        switch (idlName.type) {
            case "interface":
                fs.appendFileSync(csFile, "using System;\r\nusing System.Runtime.InteropServices;\r\n");


                fs.appendFileSync(csFile, "public " + (idlName.partial ? "partial" : "") + " class " + idlName.name + " : WebIDL2UnityObject {");
                fs.appendFileSync(csFile, "\r\n")
                fs.appendFileSync(csFile, "internal " + idlName.name + "(IntPtr id) : base(id) {}");
                fs.appendFileSync(csFile, "\r\n")


                idlName.members.forEach(member => {
                    fs.appendFileSync(csFile, "\r\n");

                    switch (member.type) {
                        case "attribute":

                            let pInvokeType = GetNETType(member.idlType.idlType, true);
                            let netType = GetNETType(member.idlType.idlType, false);
                            let nativeMethodeName = idlName.name + "_get_" + member.name;

                            fs.appendFileSync(csFile, `
[DllImport("__Internal")]
private extern static ` + pInvokeType + " " + nativeMethodeName + `(IntPtr instance);
public ` + netType + " " + member.name + " => " + (pInvokeType == "IntPtr" ? ("new " + netType + "(" + nativeMethodeName + "(ID));" ) : (nativeMethodeName + "(ID);"))
                            );

                            break;

                        case "operation":

                            break;

                        case "constructor":

                            break;

                        case "setlike":

                            break;

                        case "iterable":

                            break;

                        default:
                            console.log("Unknown interface member type : " + member.type);
                    }
                })

                fs.appendFileSync(csFile, "\r\n}");
                break;

            case "enum":

                break;

            case "dictionary":

                break

            case "callback":

                break;

            case "typedef":

                break;

            default:
                console.log("Unknown idlName : " + idlName.type);
        }

        fs.closeSync(csFile);
        fs.closeSync(jslibFile);

    }



};