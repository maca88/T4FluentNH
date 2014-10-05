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
	public partial class O2OIdentityCard5
	{

    

		#region Owner

            
        [ReadOnly(true)]
        public virtual int OwnerId { get; protected set; }

		public virtual void SetOwner(O2OPerson5 owner)
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