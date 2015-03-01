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
	public partial class M2MUser
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Roles", new ManyToManyRelationMetadata
                {
					RelatedModelType = typeof(TestM2MRole),
					RelatedModelProperty = typeof(TestM2MRole).GetProperty("Users"),
					RelatedModelIdProperty = typeof(TestM2MRole).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(M2MUser).GetField("_roles", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "role",
					Property = typeof(M2MUser).GetProperty("Roles"),
                    AddMethod = typeof(M2MUser).GetMethods().FirstOrDefault(o => o.Name == "AddRole" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(TestM2MRole)),
					RemoveMethod = typeof(M2MUser).GetMethods().FirstOrDefault(o => o.Name == "RemoveRole" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(TestM2MRole)),
					CollectionMapType = CollectionMapType.Unknown,
					
                }},
		
            };

		#endregion

		#region Roles

		private ISet<TestM2MRole> _roles;
        public virtual void AddRole(TestM2MRole role)
        {
            this.AddManyToMany(o => o.Roles, role, o => o.Users);
        }

        public virtual void RemoveRole(TestM2MRole role)
        {
            this.RemoveManyToMany(o => o.Roles, role, o => o.Users);
        }

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
