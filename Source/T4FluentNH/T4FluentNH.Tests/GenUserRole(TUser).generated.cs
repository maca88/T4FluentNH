using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.Generics
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class GenUserRole<TUser>
	{

		#region Role

        [ReadOnly(true)]
        public virtual int? RoleId { get; set; }

		#endregion

	}
}
