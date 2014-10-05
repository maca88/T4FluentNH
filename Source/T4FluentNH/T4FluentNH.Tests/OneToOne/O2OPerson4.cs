using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace T4FluentNH.Tests.OneToOne
{
    public partial class O2OPerson4 : Entity
    {
   
        public virtual string Name { get; set; } 

        public virtual O2OIdentityCard4 IdentityCard { get; set; }
    }

    public class O2OPerson4Mapping : IAutoMappingOverride<O2OPerson4>
    {
        public void Override(AutoMapping<O2OPerson4> mapping)
        {
            mapping.HasOne(o => o.IdentityCard).PropertyRef(o => o.Owner);
        }
    }




    public partial class O2OIdentityCard4 : Entity
    {
        public virtual string Code { get; set; }

        public virtual O2OPerson4 Owner { get; set; }
    }
}
