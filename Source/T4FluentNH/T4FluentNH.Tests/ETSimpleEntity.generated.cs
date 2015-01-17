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
	public partial class ETSimpleEntity
	{

		#region CodeListEntity

        [ReadOnly(true)]
        public virtual string CodeListEntityCode { get; set; }

		#endregion

		#region InheritCodeListEntity

        [ReadOnly(true)]
        public virtual string InheritCodeListEntityCode { get; set; }

		#endregion

		#region LengthCodeListEntity

        [ReadOnly(true)]
        public virtual string LengthCodeListEntityCode { get; set; }

		#endregion

	}
}
