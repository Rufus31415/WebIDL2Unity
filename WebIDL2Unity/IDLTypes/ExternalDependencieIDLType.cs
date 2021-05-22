using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WebIDL2Unity
{
    class ExternalDependencieIDLType : IDLType
    {
        public readonly bool IsWebIDLPartial;

        public ExternalDependencieIDLType(string name, bool isPartialClass) : base(name, "ExternalDependencies")
        {
            IsWebIDLPartial = isPartialClass;
        }

        public override void Generate(GenerationContext context)
        {
            using (StreamWriter csFile = GetFile(context.OutputDirectory, "cs"))
            {

                csFile.WriteLine("using System;");
                csFile.WriteLine("using System.Runtime.InteropServices;");

                csFile.WriteLine();

                csFile.Write($"public {(IsWebIDLPartial ? "partial " : "")}class ");
                csFile.Write(Name);
                csFile.WriteLine(" : WebIDL2UnityObject {");

                csFile.WriteLine();

                csFile.Write("internal ");
                csFile.Write(Name);
                csFile.WriteLine("(int id) : base(id) {}");

                csFile.WriteLine();

                csFile.Write("}");


            }
        }

    }
}

