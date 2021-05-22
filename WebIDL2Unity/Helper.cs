using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebIDL2Unity
{
   public static class Helper
    {
        public static string JavascriptToNETName(string idlName)
        {
            return string.Join("", idlName.Split('-').Select((x) => x[0].ToString().ToUpper() + x.Substring(1)).ToArray());
        }

        public static IDLType AddNew(this List<IDLType> IDLObjects, IDLType type)
        {
            IDLObjects.Add(type);
            return type;
        }

        public static bool TryGetValue(this List<IDLType> IDLObjects, string name, out IDLType type)
        {
            type = IDLObjects.FirstOrDefault(x => string.Equals(x.Name, name));
            return null != type;
        }
        public static bool Contains(this List<IDLType> IDLObjects, string name)
        {
            return TryGetValue(IDLObjects,name, out IDLType _);
        }
    }
}
