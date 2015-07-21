using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests
{
    public class IdentifierLengthAttributeByIndex : Attribute
    {
        public IdentifierLengthAttributeByIndex(string test, int length)
        {
            Length = length;
            Test = test;
        }

        public int Length { get; private set; }

        public string Test { get; private set; }
    }
}
