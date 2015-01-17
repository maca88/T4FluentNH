using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.OneToMany
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class O2MCar
	{

		#region Owner

        [ReadOnly(true)]
        public virtual int OwnerId { get; set; }

        public virtual void SetOwner(T4FluentNH.Tests.OneToMany.O2MPerson owner)
        {
            this.SetManyToOne(o => o.Owner, owner, o => o.RemoveCar, o => o.Cars);
        }

        public virtual void UnsetOwner()
        {
            this.UnsetManyToOne(o => o.Owner, o => o.Cars);
        }

		#endregion

	}
}
