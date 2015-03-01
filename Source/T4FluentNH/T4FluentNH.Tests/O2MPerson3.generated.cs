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
	public partial class O2MPerson3
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Cars", new OneToManyRelationMetadata
                {
					RelatedModelType = typeof(O2MCar3),
					RelatedModelIdProperty = typeof(O2MCar3).GetProperty("Id"),
					AssociationType = AssociationType.Unidirectional,
					Field = typeof(O2MPerson3).GetField("_cars", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "car",
					Property = typeof(O2MPerson3).GetProperty("Cars"),
					CollectionMapType = CollectionMapType.Unknown,
					
                }},
		
            };

		#endregion

		#region Cars

		private ISet<O2MCar3> _cars;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
