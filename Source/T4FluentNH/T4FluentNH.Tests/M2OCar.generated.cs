using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.ManyToOne
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class M2OCar
	{

		#region Person

        private M2OPerson _person;

        [ReadOnly(true)]
		public virtual int? PersonId 
		{ 
			get { return _personId != default(int?) || Person == null ? _personId : Person.Id; } 
			set { _personId = value; }
		}

		private int? _personId;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
