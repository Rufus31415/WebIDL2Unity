using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WebIDL2Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            var outputDir = @"D:\System\Rufus\WebIDL2Unity\Unity-Test\Assets\WebXR";
            var inputIDL = @"D:\System\Rufus\WebIDL2Unity\WebIDL2JSON\IDL";

            var idlTypes = new List<IDLType>();

            idlTypes.Add(new UndefinedIDLType());

            var stringIDLType = idlTypes.AddNew(new DOMStringIDLType());

            var anyIDLType = idlTypes.AddNew(new AnyIDLType());

            var booleanIDLType= idlTypes.AddNew(new PrimitiveIDLType("boolean", "bool"));

            var doubleIDLType = idlTypes.AddNew(new PrimitiveIDLType("double", "double"));
            var floatIDLType = idlTypes.AddNew(new PrimitiveIDLType("float", "float"));
            var ulongIDLType = idlTypes.AddNew(new PrimitiveIDLType("unsigned long", "ulong"));
            var longIDLType = idlTypes.AddNew(new PrimitiveIDLType("long", "long"));
            var sbyteIDLType = idlTypes.AddNew(new PrimitiveIDLType("byte", "sbyte"));
            var byteIDLType = idlTypes.AddNew(new PrimitiveIDLType("octet", "byte"));
            var uintIDLType = idlTypes.AddNew(new PrimitiveIDLType("unsigned short", "uint"));
            var intIDLType = idlTypes.AddNew(new PrimitiveIDLType("short", "int"));

            idlTypes.Add(new PrimitiveArrayIDLType(floatIDLType, "Float32Array"));
            idlTypes.Add(new PrimitiveArrayIDLType(sbyteIDLType, "Int8Array"));
            idlTypes.Add(new PrimitiveArrayIDLType(intIDLType, "Int16Array"));
            idlTypes.Add(new PrimitiveArrayIDLType(longIDLType, "Int32Array"));
            idlTypes.Add(new PrimitiveArrayIDLType(byteIDLType, "Uint8Array"));
            idlTypes.Add(new PrimitiveArrayIDLType(uintIDLType, "Uint16Array"));
            idlTypes.Add(new PrimitiveArrayIDLType(ulongIDLType, "Uint32Array"));
            idlTypes.Add(new PrimitiveArrayIDLType(byteIDLType, "Uint8ClampedArray"));
            idlTypes.Add(new PrimitiveArrayIDLType(doubleIDLType, "Float64Array"));

            idlTypes.Add(new PrimitiveArrayIDLType(booleanIDLType, "BoolArray"));
            idlTypes.Add(new PrimitiveArrayIDLType(anyIDLType, "StringArray")); // first approach : any is string
            idlTypes.Add(new PrimitiveArrayIDLType(stringIDLType, "StringArray"));

            var jsonMergeSettings = new JsonMergeSettings()
            {
                // union array values together to avoid duplicates
                MergeArrayHandling = MergeArrayHandling.Union
            };



            var externalDependencies = new HashSet<string>();

            foreach (var file in Directory.GetFiles(inputIDL, "*.json"))
            {
                var module = Path.GetFileNameWithoutExtension(file);

                using (StreamReader reader = File.OpenText(file))
                {
                    JObject jsonFile = (JObject)JToken.ReadFrom(new JsonTextReader(reader));

                    var jProperties = new List<JObject>();
                    jProperties.AddRange(jsonFile["idlNames"].Values().OfType<JObject>());

                    foreach (JProperty idlExtendedName in jsonFile["idlExtendedNames"])
                    {
                        JObject jPropertyToMerge = null;
                        foreach (JArray jArray in idlExtendedName)
                        {
                            foreach (JObject jProperty in jArray)
                            {
                                if (jPropertyToMerge == null) jPropertyToMerge = jProperty;
                                else jPropertyToMerge.Merge(jProperty, jsonMergeSettings);
                            }
                        }
                        jProperties.Add(jPropertyToMerge);
                    }


                    foreach (JObject jProperty in jProperties)
                    {
                        switch ((string)jProperty["type"])
                        {
                            case "typedef":
                                idlTypes.Add(new TypedefIDLType(jProperty, module));

                                break;

                            case "callback":
                                continue;

                                // TODO : implement callback
                                idlTypes.Add(new CallbackIDLType(jProperty, module));

                                break;

                            case "interface":
                            case "interface mixin":
                                idlTypes.Add(new InterfaceIDLType(jProperty, module, false));

                                break;

                            case "dictionary":
                                idlTypes.Add(new InterfaceIDLType(jProperty, module, true));

                                break;

                            case "enum":
                                idlTypes.Add(new EnumIDLType(jProperty, module));

                                break;

                            default:
                                Console.WriteLine("Unknown IDL type : " + (string)jProperty["type"]);

                                break;
                        }

                        foreach (string externalDependency in jsonFile["externalDependencies"])
                        {
                            externalDependencies.Add(externalDependency);
                        }
                    }
                }
            }

            foreach (var externalDependency in externalDependencies)
            {
                if (!idlTypes.Contains(externalDependency))
                {
                    idlTypes.Add(new ExternalDependencieIDLType(externalDependency, false));
                }
                // particular case of external dependency with additionnal members defined in another class
                else if (idlTypes.All(x => !string.Equals(x.Name, externalDependency) || (x is InterfaceIDLType && ((InterfaceIDLType)x).IsWebIDLPartial)))
                {
                    idlTypes.Add(new ExternalDependencieIDLType(externalDependency, true));
                }
            }

            if (Directory.Exists(outputDir))
            {
                DeleteGeneratedFilesRecursive(outputDir);
            }

            Directory.CreateDirectory(outputDir);

            var context = new GenerationContext();
            context.OutputDirectory = outputDir;
            context.IDLObjects = idlTypes;

            foreach (var idlObject in idlTypes)
            {
                idlObject.Generate(context);
            }

            Console.ReadKey();
        }


        private static void DeleteGeneratedFilesRecursive(string path)
        {
            foreach (var file in Directory.GetFiles(path))
            {
                // File to avoid
                if (Path.GetExtension(file) == ".meta") continue;

                File.Delete(file);
            }

            foreach (var dir in Directory.GetDirectories(path))
            {
                DeleteGeneratedFilesRecursive(dir);
            }
        }

    }
}
