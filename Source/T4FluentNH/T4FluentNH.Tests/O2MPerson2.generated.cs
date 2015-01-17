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
	public partial class O2MPerson2
	{

		#region Cars

		private ISet<T4FluentNH.Tests.OneToMany.O2MCar2> _cars;

		#endregion

	}
}
