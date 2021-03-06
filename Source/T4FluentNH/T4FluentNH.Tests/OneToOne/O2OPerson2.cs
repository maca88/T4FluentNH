﻿using T4FluentNH.Attributes;

namespace T4FluentNH.Tests.OneToOne
{
    //The right way to do one to one (1..0 --- 1..0) between two classes
    public partial class O2OPerson2 : Domain.Entity
    {
        public virtual string Name { get; set; }

        [AsOneToOne]
        public virtual O2OIdentityCard2 IdentityCard
        {
            get { return _identityCard; }
            set { ResetField(ref _identityCard, value, ref _isIdentityCardIdSet); }
        }
    }

    public partial class O2OIdentityCard2 : Domain.Entity
    {
        public virtual string Code { get; set; }

        [AsOneToOne]
        public virtual O2OPerson2 Owner
        {
            get { return _owner; }
            set { ResetField(ref _owner, value, ref _isOwnerIdSet); }
        }
    } 
}
