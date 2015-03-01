using System.Collections.Generic;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace T4FluentNH.Tests.OneToMany
{
    public partial class O2MPerson2 : Domain.Entity
    {
        public virtual string Name { get; set; }

        //Unidirectional association
        public virtual ISet<O2MCar2> Cars
        {
            get { return _cars ?? (_cars = new HashSet<O2MCar2>()); }
            set { _cars = value; }
        }
    }

    public partial class O2MCar2 : Domain.Entity
    {
        public virtual string Model { get; set; }

    }

}
