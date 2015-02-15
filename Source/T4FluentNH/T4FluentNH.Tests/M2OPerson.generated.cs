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
	public partial class M2OPerson
	{

		#region Car

        private M2OCar _car;

        [ReadOnly(true)]
		public virtual int? CarId 
		{ 
			get { return _carId != default(int?) || Car == null ? _carId : Car.Id; } 
			set { _carId = value; }
		}

		private int? _carId;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
