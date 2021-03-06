//----------------------
// <auto-generated>
//    Generated by T4FluentNH.
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
using FluentNHibernate.Mapping;
using T4FluentNH.Metadata;
using NHibernate;
using NHibernate.Collection;
using NHibernate.Util;
using System.Threading.Tasks;
//<EntityProjectItem xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"><EntityFullName>T4FluentNH.Tests.ManyToMany.TestM2MRole</EntityFullName><EntityFilePaths><string>ManyToMany\M2MUser.cs</string></EntityFilePaths><OverrideFilePaths><string>ManyToMany\M2MUser.cs</string></OverrideFilePaths><GeneratedFilePath>TestM2MRole.generated.cs</GeneratedFilePath></EntityProjectItem>
namespace T4FluentNH.Tests.ManyToMany
{
    [GeneratedCode("T4Template", "1.0")]
    public partial class TestM2MRole
    {

        #region RelationsMetadata
        #pragma warning disable

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
        #pragma warning restore
        #endregion

        #region Users

        private ISet<M2MUser> _users;
        public virtual void AddUser(M2MUser user)
        {
            this.AddManyToMany(o => o.Users, user, o => o.Roles);
        }
        public virtual Task AddUserAsync(M2MUser user)
        {
            return this.AddManyToManyAsync(o => o.Users, user, o => o.Roles);
        }

        public virtual void RemoveUser(M2MUser user)
        {
            this.RemoveManyToMany(o => o.Users, user, o => o.Roles);
        }

        public virtual Task RemoveUserAsync(M2MUser user)
        {
            return this.RemoveManyToManyAsync(o => o.Users, user, o => o.Roles);
        }

        #endregion


        private void ResetField<T>(ref T field, T value, ref bool synthIsSetField)
        {
            field = value;
            synthIsSetField = false;
        }
    }
}
