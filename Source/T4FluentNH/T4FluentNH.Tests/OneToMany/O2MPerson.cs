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
    public partial class O2MPerson : Domain.Entity
    {
        public virtual string Name { get; set; }

        //Bidirectional association
        public virtual ISet<O2MCar> Cars
        {
            get { return _cars ?? (_cars = new HashSet<O2MCar>()); }
            set { _cars = value; }
        }

    }

    public partial class O2MCar : Domain.Entity
    {
        public virtual string Model { get; set; }

        [NotNull]
        public virtual O2MPerson Owner
        {
            get { return _owner; }
            set { SetField(ref _owner, value, ref _ownerId); }
        }

    }

    public class M2MRoleMapping : IAutoMappingOverride<O2MPerson>
    {
        public void Override(AutoMapping<O2MPerson> mapping)
        {
            mapping.HasMany(o => o.Cars).KeyColumn(o => o.Owner);
        }
    }
}
