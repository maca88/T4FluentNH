using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;

namespace T4FluentNH.Tests.Naming
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class Switch
	{

		#region Case

        [ReadOnly(true)]
        public virtual int CaseId { get; protected set; }

		public virtual void SetCase(Case @case)
        {
            this.SetOneToOne(o => o.Case, @case, o => o.Switch);
        }

        public virtual void UnsetCase()
        {
            this.UnsetOneToOne(o => o.Case, o => o.Switch);
        }	

		#endregion

	}
}
