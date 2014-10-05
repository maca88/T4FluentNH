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
	public partial class O2MCar3
	{

		#region O2MCar3

        [ReadOnly(true)]
        public virtual int OwnerId { get; protected set; }

		#endregion

	}
}
