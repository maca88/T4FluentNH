using System.Collections.Generic;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace T4FluentNH.Tests.OneToMany
{
    public partial class O2MPerson3 : Domain.Entity
    {
        public virtual string Name { get; set; }

        //UniDirectional association
        public virtual ISet<O2MCar3> Cars
        {
            get { return _cars ?? (_cars = new HashSet<O2MCar3>()); }
            set { _cars = value; }
        }
    }

    public partial class O2MCar3 : Domain.Entity
    {
        public virtual string Model { get; set; }

    }

    public class O2MPerson3Mapping : IAutoMappingOverride<O2MPerson3>
    {
        public void Override(AutoMapping<O2MPerson3> mapping)
        {
            mapping.HasMany(o => o.Cars).KeyColumn("OwnerId");
        }
    }
}
