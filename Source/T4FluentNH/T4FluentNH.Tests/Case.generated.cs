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
	public partial class Case
	{

		#region Switch

        [ReadOnly(true)]
        public virtual int? SwitchId { get; set; }

		public virtual void SetSwitch(T4FluentNH.Tests.Naming.Switch @switch)
        {
            this.SetOneToOne(o => o.Switch, @switch, o => o.Case);
        }

        public virtual void UnsetSwitch()
        {
            this.UnsetOneToOne(o => o.Switch, o => o.Case);
        }	

		#endregion

	}
}
