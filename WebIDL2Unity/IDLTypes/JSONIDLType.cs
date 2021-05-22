using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WebIDL2Unity
{
    abstract class JSONIDLType:IDLType
    {
        protected JObject _jProperty;

        public JSONIDLType(JObject jproperty, string module):base((string)jproperty["name"], module)
        {
            _jProperty = jproperty;
        }

        public override abstract void Generate(GenerationContext context);


    }
}
