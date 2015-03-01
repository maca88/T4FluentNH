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
	public partial class O2OPerson3
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"IdentityCard", new OneToOneRelationMetadata
                {
					RelatedModelType = typeof(O2OIdentityCard3),
					RelatedModelProperty = typeof(O2OIdentityCard3).GetProperty("Owner"),
					RelatedModelIdProperty = typeof(O2OIdentityCard3).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(O2OPerson3).GetField("_identityCard", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "identityCard",
					Property = typeof(O2OPerson3).GetProperty("IdentityCard"),
					SetMethod = typeof(O2OPerson3).GetMethods().FirstOrDefault(o => o.Name == "SetIdentityCard" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(O2OIdentityCard3)),
					UnsetMethod = typeof(O2OPerson3).GetMethods().FirstOrDefault(o => o.Name == "UnsetIdentityCard" && o.GetParameters().Length == 0),
					SyntheticProperty = typeof(O2OPerson3).GetProperty("IdentityCardId"),
					SyntheticField = typeof(O2OPerson3).GetField("_identityCardId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
            };

		#endregion

		#region IdentityCard

        private O2OIdentityCard3 _identityCard;

        [ReadOnly(true)]
		public virtual int? IdentityCardId 
		{ 
			get { return _identityCardId != default(int?) || IdentityCard == null ? _identityCardId : IdentityCard.Id; } 
			set { _identityCardId = value; }
		}

		private int? _identityCardId;

		public virtual void SetIdentityCard(O2OIdentityCard3 identityCard)
        {
			this.SetOneToOne(o => o.IdentityCard, identityCard, o => o.Owner);
        }

        public virtual void UnsetIdentityCard()
        {
			this.UnsetOneToOne(o => o.IdentityCard, o => o.Owner);
        }	

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
