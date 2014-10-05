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
	public partial class O2OPerson2
	{

    

		#region IdentityCard

            
        [ReadOnly(true)]
        public virtual int IdentityCardId { get; protected set; }

		public virtual void SetIdentityCard(O2OIdentityCard2 identityCard)
        {
            this.SetOneToOne(o => o.IdentityCard, identityCard, o => o.Owner);
        }

        public virtual void UnsetIdentityCard()
        {
            this.UnsetOneToOne(o => o.IdentityCard, o => o.Owner);
        }	

		#endregion

	}
}
