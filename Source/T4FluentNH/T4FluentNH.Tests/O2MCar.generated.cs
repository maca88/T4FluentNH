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
	public partial class O2MCar
	{

		#region Owner

        private O2MPerson _owner;

        [ReadOnly(true)]
		public virtual int OwnerId 
		{ 
			get { return _ownerId != default(int) || Owner == null ? _ownerId : Owner.Id; } 
			set { _ownerId = value; }
		}

		private int _ownerId;

        public virtual void SetOwner(O2MPerson owner)
        {
			this.SetManyToOne(o => o.Owner, owner, o => o.RemoveCar, o => o.Cars);
        }

        public virtual void UnsetOwner()
        {
			this.UnsetManyToOne(o => o.Owner, o => o.Cars);
        }

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
