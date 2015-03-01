using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
using T4FluentNH.Metadata;
namespace T4FluentNH.Tests.Naming
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class Use
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Case", new ManyToOneRelationMetadata
                {
					RelatedModelType = typeof(Case),
					RelatedModelProperty = typeof(Case).GetProperty("Uses"),
					RelatedModelIdProperty = typeof(Case).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(Use).GetField("_case", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "@case",
					Property = typeof(Use).GetProperty("Case"),
					SetMethod = typeof(Use).GetMethods().FirstOrDefault(o => o.Name == "SetCase" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(Case)),
					UnsetMethod = typeof(Use).GetMethods().FirstOrDefault(o => o.Name == "UnsetCase" && o.GetParameters().Length == 0),
					SyntheticProperty = typeof(Use).GetProperty("CaseId"),
					SyntheticField = typeof(Use).GetField("_caseId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = false,
					RelatedModelRemoveMethod = typeof(Case).GetMethods().FirstOrDefault(o => o.Name == "RemoveUse" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(Use)),
					
                }},
		
            };

		#endregion

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
