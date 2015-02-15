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
	public partial class ETSimpleEntity
	{

		#region CodeListEntity

        private ETCodeListEntity _codeListEntity;

        [ReadOnly(true)]
		public virtual string CodeListEntityCode 
		{ 
			get { return _codeListEntityCode != default(string) || CodeListEntity == null ? _codeListEntityCode : CodeListEntity.Code; } 
			set { _codeListEntityCode = value; }
		}

		private string _codeListEntityCode;

		#endregion

		#region InheritCodeListEntity

        private ETInheritedCodeListEntity _inheritCodeListEntity;

        [ReadOnly(true)]
		public virtual string InheritCodeListEntityCode 
		{ 
			get { return _inheritCodeListEntityCode != default(string) || InheritCodeListEntity == null ? _inheritCodeListEntityCode : InheritCodeListEntity.Code; } 
			set { _inheritCodeListEntityCode = value; }
		}

		private string _inheritCodeListEntityCode;

		#endregion

		#region LengthCodeListEntity

        private ETLengthCodeList _lengthCodeListEntity;

        [ReadOnly(true)]
		public virtual string LengthCodeListEntityCode 
		{ 
			get { return _lengthCodeListEntityCode != default(string) || LengthCodeListEntity == null ? _lengthCodeListEntityCode : LengthCodeListEntity.Code; } 
			set { _lengthCodeListEntityCode = value; }
		}

		private string _lengthCodeListEntityCode;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
