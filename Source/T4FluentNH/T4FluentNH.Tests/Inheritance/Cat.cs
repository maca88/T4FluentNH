using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests.Inheritance
{
    public partial class Cat : Animal
    {
        public override string Name { get; set; }

        public override string GetSomething()
        {
            throw new NotImplementedException();
        }
    }
}
