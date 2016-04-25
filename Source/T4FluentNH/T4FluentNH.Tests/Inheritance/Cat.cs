using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using T4FluentNH.Tests.OneToMany;

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

    public class CatMapping : IAutoMappingOverride<Cat>
    {
        public void Override(AutoMapping<Cat> mapping)
        {
            mapping.IgnoreProperty(o => o.Name);
        }
    }
}
