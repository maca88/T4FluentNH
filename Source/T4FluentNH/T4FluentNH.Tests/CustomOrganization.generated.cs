//----------------------
// <auto-generated>
//	Generated by T4FluentNH.
// </auto-generated>
//----------------------
// ReSharper disable All
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
using T4FluentNH.Metadata;
//<EntityProjectItem xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"><EntityFullName>T4FluentNH.Tests.External.CustomOrganization</EntityFullName><EntityFilePaths><string>External\CustomOrganization.cs</string></EntityFilePaths><OverrideFilePaths><string>External\CustomOrganization.cs</string></OverrideFilePaths><GeneratedFilePath>CustomOrganization.generated.cs</GeneratedFilePath></EntityProjectItem>
namespace T4FluentNH.Tests.External
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class CustomOrganization
	{

		#region RelationsMetadata
		#pragma warning disable

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Users", new OneToManyRelationMetadata
                {
					RelatedModelType = typeof(CustomUser),
					RelatedModelProperty = typeof(CustomUser).GetProperty("Organization"),
					RelatedModelIdProperty = typeof(CustomUser).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(CustomOrganization).GetField("_users", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "user",
					Property = typeof(CustomOrganization).GetProperty("Users"),
                    AddMethod = typeof(CustomOrganization).GetMethods().FirstOrDefault(o => o.Name == "AddUser" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(CustomUser)),
					RemoveMethod = typeof(CustomOrganization).GetMethods().FirstOrDefault(o => o.Name == "RemoveUser" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(CustomUser)),
					CollectionMapType = CollectionMapType.Unknown,
					
                }},
		
            };
		#pragma warning restore
		#endregion

		#region Users

		private ISet<CustomUser> _users;

        public virtual void AddUser(CustomUser user)
        {
            this.AddOneToMany(o => o.Users, user, o => o.Organization, o=> o.RemoveUser);
        }

        public virtual void RemoveUser(CustomUser user)
        {
			this.RemoveOneToMany(o => o.Users, user, o => o.Organization);
        }

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
