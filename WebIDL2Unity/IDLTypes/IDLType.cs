using System.IO;
using System.Text;

namespace WebIDL2Unity
{
    public abstract class IDLType
    {
        protected string _module;
        public readonly string Name;

        public string JSFullName => $"{_module}_{Name}";

        public static string NativeSetterName()
        {
            return "WebIDL2Unity_short_set";
        }

        public static string NativeGetterName()
        {
            return "WebIDL2Unity_short_get";
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

        public StreamWriter GetFile(string outputDirectory, string extension)
        {

            return new StreamWriter(Path.Combine(Directory.CreateDirectory(Path.Combine(outputDirectory, _module)).FullName, Name + "." + extension));
        }

        public virtual string GetMarshalType()
        {
            return "int";
        }

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
            return $"{netValue}.ID";
        }

        public virtual string MarshalToJS(string variable)
        {
            return $"_WebIDL2Unity.references[{variable}]";
        }

        public virtual string JSToMarshal(string variable, bool nullable)
        {
            var sb = new StringBuilder();

            if (nullable)
            {
                // check if null or undefined
                sb.Append($@"
        if({variable} == null){{
            return 0;
        }}");
            }

            sb.Append($@"
        return _WebIDL2Unity.addReference({variable});
");
            return sb.ToString();
        }
    }
}
