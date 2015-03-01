using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
using T4FluentNH.Metadata;
namespace T4FluentNH.Tests.Inheritance
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class Animal
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Owner", new ManyToOneRelationMetadata
                {
					RelatedModelType = typeof(Owner),
					RelatedModelIdProperty = typeof(Owner).GetProperty("Id"),
					AssociationType = AssociationType.Unidirectional,
					Field = typeof(Animal).GetField("_owner", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "owner",
					Property = typeof(Animal).GetProperty("Owner"),
					SyntheticProperty = typeof(Animal).GetProperty("OwnerId"),
					SyntheticField = typeof(Animal).GetField("_ownerId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
            };

		#endregion

		#region Owner

        private Owner _owner;

        [ReadOnly(true)]
		public virtual int? OwnerId 
		{ 
			get { return _ownerId != default(int?) || Owner == null ? _ownerId : Owner.Id; } 
			set { _ownerId = value; }
		}

		private int? _ownerId;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
