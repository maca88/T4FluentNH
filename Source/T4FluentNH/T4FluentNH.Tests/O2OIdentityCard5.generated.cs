using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.OneToOne
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class O2OIdentityCard5
	{

		#region Owner

        private O2OPerson5 _owner;

        [ReadOnly(true)]
		public virtual int? OwnerId 
		{ 
			get { return _ownerId != default(int?) || Owner == null ? _ownerId : Owner.Id; } 
			set { _ownerId = value; }
		}

		private int? _ownerId;

		public virtual void SetOwner(O2OPerson5 owner)
        {
			this.SetOneToOne(o => o.Owner, owner, o => o.IdentityCard);
        }

        public virtual void UnsetOwner()
        {
			this.UnsetOneToOne(o => o.Owner, o => o.IdentityCard);
        }	

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
