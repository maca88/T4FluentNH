using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
using T4FluentNH.Metadata;
namespace T4FluentNH.Tests.ManyToOne
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class M2OCar
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Person", new ManyToOneRelationMetadata
                {
					RelatedModelType = typeof(M2OPerson),
					RelatedModelIdProperty = typeof(M2OPerson).GetProperty("Id"),
					AssociationType = AssociationType.Unidirectional,
					Field = typeof(M2OCar).GetField("_person", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "person",
					Property = typeof(M2OCar).GetProperty("Person"),
					SyntheticProperty = typeof(M2OCar).GetProperty("PersonId"),
					SyntheticField = typeof(M2OCar).GetField("_personId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
            };

		#endregion

		#region Person

        private M2OPerson _person;

        [ReadOnly(true)]
		public virtual int? PersonId 
		{ 
			get { return _personId != default(int?) || Person == null ? _personId : Person.Id; } 
			set { _personId = value; }
		}

		private int? _personId;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
