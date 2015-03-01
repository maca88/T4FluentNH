//----------------------
// <auto-generated>
// Auto gnerated code
// </auto-generated>
//----------------------
// ReSharper disable All
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
	public partial class Switch
	{

		#region RelationsMetadata
		#pragma warning disable

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Case", new OneToOneRelationMetadata
                {
					RelatedModelType = typeof(Case),
					RelatedModelProperty = typeof(Case).GetProperty("Switch"),
					RelatedModelIdProperty = typeof(Case).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(Switch).GetField("_case", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "@case",
					Property = typeof(Switch).GetProperty("Case"),
					SetMethod = typeof(Switch).GetMethods().FirstOrDefault(o => o.Name == "SetCase" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(Case)),
					UnsetMethod = typeof(Switch).GetMethods().FirstOrDefault(o => o.Name == "UnsetCase" && o.GetParameters().Length == 0),
					SyntheticProperty = typeof(Switch).GetProperty("CaseId"),
					SyntheticField = typeof(Switch).GetField("_caseId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
            };
		#pragma warning restore
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
			this.SetOneToOne(o => o.Case, @case, o => o.Switch);
        }

        public virtual void UnsetCase()
        {
			this.UnsetOneToOne(o => o.Case, o => o.Switch);
        }	

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
