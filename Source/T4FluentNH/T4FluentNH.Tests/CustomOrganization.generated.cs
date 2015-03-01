using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
using T4FluentNH.Metadata;
namespace T4FluentNH.Tests.External
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class CustomOrganization
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Users", new OneToManyRelationMetadata
                {
					RelatedModelType = typeof(CustomUser),
					RelatedModelIdProperty = typeof(CustomUser).GetProperty("Id"),
					AssociationType = AssociationType.Unidirectional,
					Field = typeof(CustomOrganization).GetField("_users", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "user",
					Property = typeof(CustomOrganization).GetProperty("Users"),
					CollectionMapType = CollectionMapType.Unknown,
					
                }},
		
            };

		#endregion

		#region Users

		private ISet<CustomUser> _users;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
