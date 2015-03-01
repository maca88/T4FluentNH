using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.ManyToMany
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class TestM2MRole
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Users", new ManyToManyRelationMetadata
                {
					RelatedModelType = typeof(M2MUser),
					RelatedModelProperty = typeof(M2MUser).GetProperty("Roles"),
					RelatedModelIdProperty = typeof(M2MUser).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(TestM2MRole).GetField("_users", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "user",
					Property = typeof(TestM2MRole).GetProperty("Users"),
                    AddMethod = typeof(TestM2MRole).GetMethods().FirstOrDefault(o => o.Name == "AddUser" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(M2MUser)),
					RemoveMethod = typeof(TestM2MRole).GetMethods().FirstOrDefault(o => o.Name == "RemoveUser" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(M2MUser)),
					CollectionMapType = CollectionMapType.Unknown,
					
                }},
		
            };

		#endregion

		#region Users

		private ISet<M2MUser> _users;
        public virtual void AddUser(M2MUser user)
        {
            this.AddManyToMany(o => o.Users, user, o => o.Roles);
        }

        public virtual void RemoveUser(M2MUser user)
        {
            this.RemoveManyToMany(o => o.Users, user, o => o.Roles);
        }

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
