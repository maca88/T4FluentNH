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

        private GenRole _role;

        [ReadOnly(true)]
		public virtual int? RoleId 
		{ 
			get { return _roleId != default(int?) || Role == null ? _roleId : Role.Id; } 
			set { _roleId = value; }
		}

		private int? _roleId;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
