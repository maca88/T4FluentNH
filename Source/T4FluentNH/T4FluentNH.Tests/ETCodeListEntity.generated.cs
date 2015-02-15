using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.EntityTypes
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class ETCodeListEntity
	{

		#region SimpleEntity

        private ETSimpleEntity _simpleEntity;

        [ReadOnly(true)]
		public virtual int? SimpleEntityId 
		{ 
			get { return _simpleEntityId != default(int?) || SimpleEntity == null ? _simpleEntityId : SimpleEntity.Id; } 
			set { _simpleEntityId = value; }
		}

		private int? _simpleEntityId;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
