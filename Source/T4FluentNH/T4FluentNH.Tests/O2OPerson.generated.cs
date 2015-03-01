using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
using T4FluentNH.Metadata;
namespace T4FluentNH.Tests.OneToOne
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class O2OPerson
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"MarriedWith", new OneToOneRelationMetadata
                {
					RelatedModelType = typeof(O2OPerson),
					RelatedModelProperty = typeof(O2OPerson).GetProperty("MarriedWith"),
					RelatedModelIdProperty = typeof(O2OPerson).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(O2OPerson).GetField("_marriedWith", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "marriedWith",
					Property = typeof(O2OPerson).GetProperty("MarriedWith"),
					SetMethod = typeof(O2OPerson).GetMethods().FirstOrDefault(o => o.Name == "SetMarriedWith" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(O2OPerson)),
					UnsetMethod = typeof(O2OPerson).GetMethods().FirstOrDefault(o => o.Name == "UnsetMarriedWith" && o.GetParameters().Length == 0),
					SyntheticProperty = typeof(O2OPerson).GetProperty("MarriedWithId"),
					SyntheticField = typeof(O2OPerson).GetField("_marriedWithId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
                {"Twin", new OneToOneRelationMetadata
                {
					RelatedModelType = typeof(O2OPerson),
					RelatedModelProperty = typeof(O2OPerson).GetProperty("Twin"),
					RelatedModelIdProperty = typeof(O2OPerson).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(O2OPerson).GetField("_twin", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "twin",
					Property = typeof(O2OPerson).GetProperty("Twin"),
					SetMethod = typeof(O2OPerson).GetMethods().FirstOrDefault(o => o.Name == "SetTwin" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(O2OPerson)),
					UnsetMethod = typeof(O2OPerson).GetMethods().FirstOrDefault(o => o.Name == "UnsetTwin" && o.GetParameters().Length == 0),
					SyntheticProperty = typeof(O2OPerson).GetProperty("TwinId"),
					SyntheticField = typeof(O2OPerson).GetField("_twinId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
            };

		#endregion

		#region MarriedWith

        private O2OPerson _marriedWith;

        [ReadOnly(true)]
		public virtual int? MarriedWithId 
		{ 
			get { return _marriedWithId != default(int?) || MarriedWith == null ? _marriedWithId : MarriedWith.Id; } 
			set { _marriedWithId = value; }
		}

		private int? _marriedWithId;

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

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
