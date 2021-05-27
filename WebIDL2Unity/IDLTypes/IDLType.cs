using System;
using System.IO;
using System.Text;

namespace WebIDL2Unity
{
    public abstract class IDLType
    {
        protected string _module;
        public readonly string Name;

        public static string NativeSetterName()
        {
            return "WebIDL2Unity_reference_set";
        }

        public static string NativeGetterName()
        {
            return "WebIDL2Unity_reference_get";
        }

        public virtual string GetterName()
        {
            return NativeGetterName();
        }

        public virtual string SetterName()
        {
            return NativeSetterName();
        }


        public IDLType(string name, string module)
        {
            Name = name;
            _module = module;
        }

        public abstract void Generate(GenerationContext context);

        public StreamWriter GetFile(string outputDirectory, string extension, string prefix="")
        {

            return new StreamWriter(Path.Combine(Directory.CreateDirectory(Path.Combine(outputDirectory, _module)).FullName, prefix + Name + "." + extension));
        }

        public virtual string GetMarshalType()
        {
            return "int";
        }

        // TODO : proper implement nullable argument (now nullable=false always)
        public virtual string GetNETType(bool nullable)
        {
            return Name;
        }

        public virtual string MarshalToNET(string nativeValue)
        {
            return $"{nativeValue} == 0 ? null : new {Name}({nativeValue})";
        }

        public virtual string NETToMarshal(string netValue)
        {
            return $"{netValue}==null ? 0 : {netValue}.ID";
        }

        public virtual string MarshalToJS(string variable)
        {
            return $"_WebIDL2Unity.references[{variable}]";
        }

        public virtual string GetDynCallLetter()
        {
            return "i";
        }

        public virtual string JSToMarshalReturn(string variable, bool nullable)
        {
            return $"return {JSToMarshal(variable, nullable)};";
        }

        public virtual string JSToMarshal(string variable, bool nullable)
        {
            if (nullable)
            {
                // check if null of undefined
                return $"{variable}==null ? 0 : _WebIDL2Unity.addReference({variable})";
            }
            else
            {
                return $"_WebIDL2Unity.addReference({variable})";
            }
        }
    }
}
