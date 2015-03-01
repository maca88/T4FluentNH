using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.EntityTypes
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class ETSimpleEntity
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"CodeListEntity", new ManyToOneRelationMetadata
                {
					RelatedModelType = typeof(ETCodeListEntity),
					RelatedModelIdProperty = typeof(ETCodeListEntity).GetProperty("Code"),
					AssociationType = AssociationType.Unidirectional,
					Field = typeof(ETSimpleEntity).GetField("_codeListEntity", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "codeListEntity",
					Property = typeof(ETSimpleEntity).GetProperty("CodeListEntity"),
					SyntheticProperty = typeof(ETSimpleEntity).GetProperty("CodeListEntityCode"),
					SyntheticField = typeof(ETSimpleEntity).GetField("_codeListEntityCode", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = 20,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
                {"InheritCodeListEntity", new ManyToOneRelationMetadata
                {
					RelatedModelType = typeof(ETInheritedCodeListEntity),
					RelatedModelIdProperty = typeof(ETInheritedCodeListEntity).GetProperty("Code"),
					AssociationType = AssociationType.Unidirectional,
					Field = typeof(ETSimpleEntity).GetField("_inheritCodeListEntity", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "inheritCodeListEntity",
					Property = typeof(ETSimpleEntity).GetProperty("InheritCodeListEntity"),
					SyntheticProperty = typeof(ETSimpleEntity).GetProperty("InheritCodeListEntityCode"),
					SyntheticField = typeof(ETSimpleEntity).GetField("_inheritCodeListEntityCode", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = 20,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
                {"LengthCodeListEntity", new ManyToOneRelationMetadata
                {
					RelatedModelType = typeof(ETLengthCodeList),
					RelatedModelIdProperty = typeof(ETLengthCodeList).GetProperty("Code"),
					AssociationType = AssociationType.Unidirectional,
					Field = typeof(ETSimpleEntity).GetField("_lengthCodeListEntity", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "lengthCodeListEntity",
					Property = typeof(ETSimpleEntity).GetProperty("LengthCodeListEntity"),
					SyntheticProperty = typeof(ETSimpleEntity).GetProperty("LengthCodeListEntityCode"),
					SyntheticField = typeof(ETSimpleEntity).GetField("_lengthCodeListEntityCode", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = 30,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
            };

		#endregion

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
