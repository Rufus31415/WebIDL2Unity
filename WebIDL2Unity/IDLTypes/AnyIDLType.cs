using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebIDL2Unity
{
        /// <summary>
        /// Compile any type as a string for now
        /// </summary>
    internal class AnyIDLType : DOMStringIDLType
    {

        public AnyIDLType() : base("any")
        {
        }

    }
}
