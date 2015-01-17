using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.External
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class ExtTest
	{

		#region User

        [ReadOnly(true)]
        public virtual int? UserId { get; set; }

		#endregion

	}
}
