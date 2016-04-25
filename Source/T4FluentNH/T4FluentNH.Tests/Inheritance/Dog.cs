using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace T4FluentNH.Tests.Inheritance
{
    public partial class Dog : Animal
    {
        public override string Name { get; set; }

        public override string GetSomething()
        {
            throw new NotImplementedException();
        }
    }

    public class DogMapping : IAutoMappingOverride<Dog>
    {
        public void Override(AutoMapping<Dog> mapping)
        {
            mapping.IgnoreProperty(o => o.Name);
        }
    }
}
