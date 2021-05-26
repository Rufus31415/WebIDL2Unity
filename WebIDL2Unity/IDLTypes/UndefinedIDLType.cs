using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebIDL2Unity
{
    class UndefinedIDLType : IDLType
    {
        public UndefinedIDLType() : base("undefined", "Native")
        {

        }

        public override void Generate(GenerationContext context)
        {

        }

        public override string GetNETType(bool nullable)
        {
            return "void";
        }

    }
}
