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

        private T4FluentNH.Domain.IUser _user;

        [ReadOnly(true)]
		public virtual int? UserId 
		{ 
			get { return _userId != default(int?) || User == null ? _userId : User.Id; } 
			set { _userId = value; }
		}

		private int? _userId;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
