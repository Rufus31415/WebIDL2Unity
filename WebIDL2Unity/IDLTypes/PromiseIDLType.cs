using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebIDL2Unity
{
    class PromiseIDLType : IDLType
    {
        private string _className;
        private string _methodName;

        private readonly Dictionary<string, IDLType> Args = new Dictionary<string, IDLType>();

        public PromiseIDLType(JToken member, GenerationContext context) : base("Promise", "Native")
        {
            _className = member.Parent.Parent.Parent.Value<string>("name");
            _methodName = Helper.JavascriptToNETName(member.Value<string>("name"));

            int i = 0;
            foreach (var arg in member["idlType"]["idlType"])
            {
                var typeName = arg.Value<string>("idlType");
                if (context.IDLObjects.TryGetValue(typeName, out IDLType type))
                {
                    Args["a" + i] = type;
                }
                else
                {
                    Console.WriteLine("Unknown type for promise : " + typeName);
                }

                i++;
            }

        }

        public override void Generate(GenerationContext context)
        {

        }

        public override string MarshalToNET(string nativeValue)
        {
            return $"{nativeValue} == 0 ? null : new {GetNETType(false)}(value, {_className}_{_methodName}_promises);";
        }

        public override string GetNETType(bool nullable)
        {
            return $"Promise<{_className}_{_methodName}_delegate>";
        }


        public override string JSToMarshal(string variable, bool nullable)
        {
            return $@"
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(supported){{
            Module[""dynCall_ii{string.Join("", Args.Values.Select(x=>x.GetDynCallLetter()).ToArray())}""](callback, promise, {string.Join(", ", Args.Keys.ToArray())})
        }});

        return promise;
";
        }

        /* dyncall prototypes
         * 
         * v : void
         * d : double
         * i : int
         * f : float
         * j : long
         * 
dynCall_dddi
​dynCall_ddi
​dynCall_dfi
​dynCall_di
​dynCall_diddi
​dynCall_didi
​dynCall_dii
​dynCall_diii
​dynCall_diiii
​dynCall_dji
​dynCall_f
​dynCall_fdi
​dynCall_ff
​dynCall_fff
​dynCall_ffffi
​dynCall_fffi
​dynCall_ffi
​dynCall_fi
​dynCall_fif
​dynCall_fiffi
​dynCall_fifi
​dynCall_fii
​dynCall_fiii
​dynCall_fiiii
​dynCall_fji
​dynCall_i
​dynCall_idi
​dynCall_idiii
​dynCall_iffi
​dynCall_ifi
​dynCall_ifiii
​dynCall_ii
​dynCall_iidi
​dynCall_iidii
​dynCall_iifi
​dynCall_iifii
​dynCall_iifiii
​dynCall_iii
​dynCall_iiif
​dynCall_iiifi
​dynCall_iiifii
​dynCall_iiii
​dynCall_iiiifii
​dynCall_iiiifiii
​dynCall_iiiii
​dynCall_iiiiii
​dynCall_iiiiiifffiiifiii
​dynCall_iiiiiii
​dynCall_iiiiiiii
​dynCall_iiiiiiiii
​dynCall_iiiiiiiiii
​dynCall_iiiiiiiiiii
​dynCall_iiiiiiiiiiii
​dynCall_iiiiiiiiiiiii
​dynCall_iiiiiiiiiiiiii
​dynCall_iiiiiji
​dynCall_iiiij
​dynCall_iiiiji
​dynCall_iiiijii
​dynCall_iiij
​dynCall_iiiji
​dynCall_iiijii
​dynCall_iiijiii
​dynCall_iiijjii
​dynCall_iij
​dynCall_iiji
​dynCall_iijii
​dynCall_iijiii
​dynCall_iijji
​dynCall_iijjii
​dynCall_iijjiii
​dynCall_iijjji
​dynCall_iji
​dynCall_ijiii
​dynCall_ijj
​dynCall_ijji
​dynCall_j
​dynCall_jdi
​dynCall_jdii
​dynCall_jfi
​dynCall_ji
​dynCall_jidi
​dynCall_jidii
​dynCall_jii
​dynCall_jiii
​dynCall_jiiii
​dynCall_jiiiii
​dynCall_jiiiiii
​dynCall_jiiiiiiiiii
​dynCall_jiiji
​dynCall_jiji
​dynCall_jijii
​dynCall_jijiii
​dynCall_jijj
​dynCall_jijji
​dynCall_jji
​dynCall_v
​dynCall_vd
​dynCall_vf
​dynCall_vff
​dynCall_vffff
​dynCall_vfi
​dynCall_vi
​dynCall_vid
​dynCall_vidi
​dynCall_vif
​dynCall_viff
​dynCall_vifff
​dynCall_viffff
​dynCall_viffffi
​dynCall_viffffii
​dynCall_vifffi
​dynCall_viffi
​dynCall_viffii
​dynCall_vifi
​dynCall_vii
​dynCall_viid
​dynCall_viidi
​dynCall_viidii
​dynCall_viif
​dynCall_viiff
​dynCall_viifff
​dynCall_viiffi
​dynCall_viifi
​dynCall_viifii
​dynCall_viifiii
​dynCall_viii
​dynCall_viiidi
​dynCall_viiifi
​dynCall_viiii
​dynCall_viiiii
​dynCall_viiiiif
​dynCall_viiiiiffii
​dynCall_viiiiifi
​dynCall_viiiiii
​dynCall_viiiiiif
​dynCall_viiiiiii
​dynCall_viiiiiiii
​dynCall_viiiiiiiii
​dynCall_viiiiiiiiii
​dynCall_viiiiiiiiiii
​dynCall_viiiiiiiiiiii
​dynCall_viiiiiiiiiiiiii
​dynCall_viiiiiiiiiiiiiii
​dynCall_viiiiiiiiiiiiiiiiii
​dynCall_viiiiiji
​dynCall_viiiijiiii
​dynCall_viiiji
​dynCall_viiijji
​dynCall_viij
​dynCall_viiji
​dynCall_viijii
​dynCall_viijiijiii
​dynCall_viijijii
​dynCall_viijijiii
​dynCall_viijj
​dynCall_viijji
​dynCall_viijjiii
​dynCall_viijjji
​dynCall_vij
​dynCall_viji
​dynCall_vijii
​dynCall_vijiii
​dynCall_vijiji
​dynCall_vijijji
​dynCall_vijji
​dynCall_vijjii
​dynCall_vjiiii
​dynCall_vjji
         * */
    }
}
