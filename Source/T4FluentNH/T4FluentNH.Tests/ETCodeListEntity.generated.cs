using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.EntityTypes
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class ETCodeListEntity
	{

		#region SimpleEntity

        [ReadOnly(true)]
        public virtual int? SimpleEntityId { get; set; }

		#endregion

	}
}
