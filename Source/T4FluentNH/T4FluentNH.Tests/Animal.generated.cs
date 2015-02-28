using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.Inheritance
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class Animal
	{

		#region Owner

        private Owner _owner;

        [ReadOnly(true)]
		public virtual int? OwnerId 
		{ 
			get { return _ownerId != default(int?) || Owner == null ? _ownerId : Owner.Id; } 
			set { _ownerId = value; }
		}

		private int? _ownerId;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
