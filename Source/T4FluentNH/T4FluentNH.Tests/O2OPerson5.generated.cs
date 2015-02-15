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
	public partial class O2OPerson5
	{

		#region IdentityCard

        private O2OIdentityCard5 _identityCard;

        [ReadOnly(true)]
		public virtual int? IdentityCardId 
		{ 
			get { return _identityCardId != default(int?) || IdentityCard == null ? _identityCardId : IdentityCard.Id; } 
			set { _identityCardId = value; }
		}

		private int? _identityCardId;

		public virtual void SetIdentityCard(O2OIdentityCard5 identityCard)
        {
			this.SetOneToOne(o => o.IdentityCard, identityCard, o => o.Owner);
        }

        public virtual void UnsetIdentityCard()
        {
			this.UnsetOneToOne(o => o.IdentityCard, o => o.Owner);
        }	

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
