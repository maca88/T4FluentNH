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
	public partial class O2OPerson
	{

		#region MarriedWith

        private O2OPerson _marriedWith;

        [ReadOnly(true)]
		public virtual int? MarriedWithId 
		{ 
			get { return _marriedWithId != default(int?) || MarriedWith == null ? _marriedWithId : MarriedWith.Id; } 
			set { _marriedWithId = value; }
		}

		private int? _marriedWithId;

		public virtual void SetMarriedWith(O2OPerson marriedWith)
        {
			this.SetOneToOne(o => o.MarriedWith, marriedWith, o => o.MarriedWith);
        }

        public virtual void UnsetMarriedWith()
        {
			this.UnsetOneToOne(o => o.MarriedWith, o => o.MarriedWith);
        }	

		#endregion

		#region Twin

        private O2OPerson _twin;

        [ReadOnly(true)]
		public virtual int? TwinId 
		{ 
			get { return _twinId != default(int?) || Twin == null ? _twinId : Twin.Id; } 
			set { _twinId = value; }
		}

		private int? _twinId;

		public virtual void SetTwin(O2OPerson twin)
        {
			this.SetOneToOne(o => o.Twin, twin, o => o.Twin);
        }

        public virtual void UnsetTwin()
        {
			this.UnsetOneToOne(o => o.Twin, o => o.Twin);
        }	

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
