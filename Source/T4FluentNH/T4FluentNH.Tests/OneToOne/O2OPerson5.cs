using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace T4FluentNH.Tests.OneToOne
{
    //The right way to do one to one (1 --- 1..0) between two classes that share the same id
    public partial class O2OPerson5 : Domain.Entity
    {
        public virtual string Name { get; set; }

        public virtual O2OIdentityCard5 IdentityCard
        {
            get { return _identityCard; }
            set { SetField(ref _identityCard, value, ref _identityCardId); }
        }
    }

    public class O2OPerson5Mapping : IAutoMappingOverride<O2OPerson5>
    {
        public void Override(AutoMapping<O2OPerson5> mapping)
        {
            mapping.Id(o => o.Id).GeneratedBy.Native();
            mapping.HasOne(o => o.IdentityCard).PropertyRef(o => o.Owner).Cascade.All(); //With PropertyRef you specify that foreign key will be created on the related table (ie. TestO2OIdentityCard5)
        }
    }

    public partial class O2OIdentityCard5 : Domain.Entity
    {
        public virtual string Code { get; set; }

        public virtual O2OPerson5 Owner
        {
            get { return _owner; }
            set { SetField(ref _owner, value, ref _ownerId); }
        }
    }

    public class O2OIdentityCard5Mapping : IAutoMappingOverride<O2OIdentityCard5>
    {
        public void Override(AutoMapping<O2OIdentityCard5> mapping)
        {
            mapping.Id(o => o.Id).GeneratedBy.Foreign("Owner");
            mapping.HasOne(o => o.Owner).Constrained();
        }
    }
}
