using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;

namespace T4FluentNH.Tests.OneToOne
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class O2OIdentityCard2
	{

    

		#region Owner

		public virtual void SetOwner(O2OPerson2 owner)
        {
            this.SetOneToOne(o => o.Owner, owner, o => o.IdentityCard);
        }

        public virtual void UnsetOwner()
        {
            this.UnsetOneToOne(o => o.Owner, o => o.IdentityCard);
        }	

		#endregion

	}
}
