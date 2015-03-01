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
	public partial class O2OIdentityCard4
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Owner", new OneToOneRelationMetadata
                {
					RelatedModelType = typeof(O2OPerson4),
					RelatedModelProperty = typeof(O2OPerson4).GetProperty("IdentityCard"),
					RelatedModelIdProperty = typeof(O2OPerson4).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(O2OIdentityCard4).GetField("_owner", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "owner",
					Property = typeof(O2OIdentityCard4).GetProperty("Owner"),
					SetMethod = typeof(O2OIdentityCard4).GetMethods().FirstOrDefault(o => o.Name == "SetOwner" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(O2OPerson4)),
					UnsetMethod = typeof(O2OIdentityCard4).GetMethods().FirstOrDefault(o => o.Name == "UnsetOwner" && o.GetParameters().Length == 0),
					SyntheticProperty = typeof(O2OIdentityCard4).GetProperty("OwnerId"),
					SyntheticField = typeof(O2OIdentityCard4).GetField("_ownerId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
            };

		#endregion

		#region Owner

        private O2OPerson4 _owner;

        [ReadOnly(true)]
		public virtual int? OwnerId 
		{ 
			get { return _ownerId != default(int?) || Owner == null ? _ownerId : Owner.Id; } 
			set { _ownerId = value; }
		}

		private int? _ownerId;

		public virtual void SetOwner(O2OPerson4 owner)
        {
			this.SetOneToOne(o => o.Owner, owner, o => o.IdentityCard);
        }

        public virtual void UnsetOwner()
        {
			this.UnsetOneToOne(o => o.Owner, o => o.IdentityCard);
        }	

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
