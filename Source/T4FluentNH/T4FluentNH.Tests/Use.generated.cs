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
	public partial class Use
	{

		#region Case

        private Case _case;

        [ReadOnly(true)]
		public virtual int? CaseId 
		{ 
			get { return _caseId != default(int?) || Case == null ? _caseId : Case.Id; } 
			set { _caseId = value; }
		}

		private int? _caseId;

        public virtual void SetCase(Case @case)
        {
			this.SetManyToOne(o => o.Case, @case, o => o.RemoveUse, o => o.Uses);
        }

        public virtual void UnsetCase()
        {
			this.UnsetManyToOne(o => o.Case, o => o.Uses);
        }

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
