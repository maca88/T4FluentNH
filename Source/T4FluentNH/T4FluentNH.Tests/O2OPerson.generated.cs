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
	public partial class O2OPerson
	{

		#region MarriedWith

        [ReadOnly(true)]
        public virtual int MarriedWithId { get; protected set; }

		public virtual void SetMarriedWith(O2OPerson marriedWith)
        {
            this.SetOneToOne(o => o.MarriedWith, marriedWith, o => o.MarriedWith);
        }

        public virtual void UnsetMarriedWith()
        {
            this.UnsetOneToOne(o => o.MarriedWith, o => o.MarriedWith);
        }	

		#endregion

		#region Twin

        [ReadOnly(true)]
        public virtual int TwinId { get; protected set; }

		public virtual void SetTwin(O2OPerson twin)
        {
            this.SetOneToOne(o => o.Twin, twin, o => o.Twin);
        }

        public virtual void UnsetTwin()
        {
            this.UnsetOneToOne(o => o.Twin, o => o.Twin);
        }	

		#endregion

	}
}
