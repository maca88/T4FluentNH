using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests
{
    public class LengthAttribute : Attribute
    {
        public LengthAttribute(int maxlength)
        {
            MaxLength = maxlength;
        }

        public int MaxLength { get; set; }
    }
}
