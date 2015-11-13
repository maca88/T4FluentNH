using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace T4FluentNH.Tests.OneToMany
{
    public partial class O2MPerson4 : Domain.Entity
    {
        public virtual string Name { get; set; }

        //Bidirectional association with a non convention key
        public virtual ISet<O2MCar4> Cars
        {
            get { return _cars ?? (_cars = new HashSet<O2MCar4>()); }
            set { _cars = value; }
        }

    }

    public partial class O2MCar4 : Domain.Entity
    {
        public virtual string Model { get; set; }

        [NotNull]
        public virtual O2MPerson4 Owner { get; set; }

        public virtual int OwnerId { get; set; }
    }

    public class O2MCar4Mapping : IAutoMappingOverride<O2MCar4>
    {
        public void Override(AutoMapping<O2MCar4> mapping)
        {
            mapping.References(o => o.Owner).Column("Owner_CustomFK");
        }
    }

    public class O2MPerson4Mapping : IAutoMappingOverride<O2MPerson4>
    {
        public void Override(AutoMapping<O2MPerson4> mapping)
        {
            mapping.HasMany(o => o.Cars).KeyColumn("Owner_CustomFK").Inverse();
        }
    }
}
