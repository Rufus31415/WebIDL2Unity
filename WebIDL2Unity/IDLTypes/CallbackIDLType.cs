using Newtonsoft.Json.Linq;
using System;

namespace WebIDL2Unity
{
    class CallbackIDLType : JSONIDLType
    {
        public CallbackIDLType(JObject jproperty, string module) : base(jproperty, module)
        {

        }

        public override void Generate(GenerationContext context)
        {

        }

        public override string GetMarshalType()
        {
            throw new NotImplementedException();
        }

        public override string GetNETType(bool nullable)
        {
            throw new NotImplementedException();
        }

        public override string MarshalToNET(string nativeValue)
        {
            throw new NotImplementedException();
        }
    }
}
