using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace T4FluentNH.Tests.OneToOne
{
    public partial class O2OPerson4 : Domain.Entity
    {
   
        public virtual string Name { get; set; }

        public virtual O2OIdentityCard4 IdentityCard
        {
            get { return _identityCard; }
            set { SetField(ref _identityCard, value, ref _identityCardId); }
        }
    }

    public class O2OPerson4Mapping : IAutoMappingOverride<O2OPerson4>
    {
        public void Override(AutoMapping<O2OPerson4> mapping)
        {
            mapping.HasOne(o => o.IdentityCard).PropertyRef(o => o.Owner);
        }
    }




    public partial class O2OIdentityCard4 : Domain.Entity
    {
        public virtual string Code { get; set; }

        public virtual O2OPerson4 Owner
        {
            get { return _owner; }
            set { SetField(ref _owner, value, ref _ownerId); }
        }
    }
}
