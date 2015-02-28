using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.Naming
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class Case
	{

		#region Switch

        private Switch _switch;

        [ReadOnly(true)]
		public virtual int? SwitchId 
		{ 
			get { return _switchId != default(int?) || Switch == null ? _switchId : Switch.Id; } 
			set { _switchId = value; }
		}

		private int? _switchId;

		public virtual void SetSwitch(Switch @switch)
        {
			this.SetOneToOne(o => o.Switch, @switch, o => o.Case);
        }

        public virtual void UnsetSwitch()
        {
			this.UnsetOneToOne(o => o.Switch, o => o.Case);
        }	

		#endregion

		#region Uses

		private ISet<Use> _uses;

        public virtual void AddUse(Use us)
        {
            this.AddOneToMany(o => o.Uses, us, o => o.Case, o=> o.RemoveUse);
        }

        public virtual void RemoveUse(Use us)
        {
			this.RemoveOneToMany(o => o.Uses, us, o => o.Case);
        }

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
