using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests
{
    public class IdentifierLengthAttributeByProperty : Attribute
    {
        public int Length { get; set; }

        public string Test { get; set; }
    }
}
