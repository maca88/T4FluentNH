﻿using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace T4FluentNH.Tests.OneToOne
{
    public partial class O2OPerson3 : Entity
    {
        public virtual string Name { get; set; }  

        public virtual O2OIdentityCard3 IdentityCard { get; protected internal set; }
    }

    public class O2OPerson3Mapping : IAutoMappingOverride<O2OPerson3>
    {
        public void Override(AutoMapping<O2OPerson3> mapping)
        {
            mapping.HasOne(o => o.IdentityCard).PropertyRef(o => o.Owner).Constrained();
        }
    }



    public partial class O2OIdentityCard3 : Entity
    {
        public virtual string Code { get; set; }

        public virtual O2OPerson3 Owner { get; protected internal set; }
    }
}
