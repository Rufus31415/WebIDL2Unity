using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebIDL2Unity
{
    class TypedefIDLType:JSONIDLType
    {
        public TypedefIDLType(JObject jproperty, string module) : base(jproperty, module)
        {

        }

        public override void Generate(GenerationContext context)
        {

        }


    }
}
