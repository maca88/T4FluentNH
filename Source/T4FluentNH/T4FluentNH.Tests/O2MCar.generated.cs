using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
using T4FluentNH.Metadata;
namespace T4FluentNH.Tests.OneToMany
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class O2MCar
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Owner", new ManyToOneRelationMetadata
                {
					RelatedModelType = typeof(O2MPerson),
					RelatedModelProperty = typeof(O2MPerson).GetProperty("Cars"),
					RelatedModelIdProperty = typeof(O2MPerson).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(O2MCar).GetField("_owner", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "owner",
					Property = typeof(O2MCar).GetProperty("Owner"),
					SetMethod = typeof(O2MCar).GetMethods().FirstOrDefault(o => o.Name == "SetOwner" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(O2MPerson)),
					UnsetMethod = typeof(O2MCar).GetMethods().FirstOrDefault(o => o.Name == "UnsetOwner" && o.GetParameters().Length == 0),
					SyntheticProperty = typeof(O2MCar).GetProperty("OwnerId"),
					SyntheticField = typeof(O2MCar).GetField("_ownerId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = true,
					RelatedModelRemoveMethod = typeof(O2MPerson).GetMethods().FirstOrDefault(o => o.Name == "RemoveCar" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(O2MCar)),
					
                }},
		
            };

		#endregion

		#region Owner

        private O2MPerson _owner;

        [ReadOnly(true)]
		public virtual int OwnerId 
		{ 
			get { return _ownerId != default(int) || Owner == null ? _ownerId : Owner.Id; } 
			set { _ownerId = value; }
		}

		private int _ownerId;

        public virtual void SetOwner(O2MPerson owner)
        {
			this.SetManyToOne(o => o.Owner, owner, o => o.RemoveCar, o => o.Cars);
        }

        public virtual void UnsetOwner()
        {
			this.UnsetManyToOne(o => o.Owner, o => o.Cars);
        }

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
