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
//<EntityProjectItem xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"><EntityFullName>T4FluentNH.Tests.OneToOne.O2OIdentityCard3</EntityFullName><EntityFilePaths><string>OneToOne\O2OPerson3.cs</string></EntityFilePaths><OverrideFilePaths /><GeneratedFilePath>O2OIdentityCard3.generated.cs</GeneratedFilePath></EntityProjectItem>
namespace T4FluentNH.Tests.OneToOne
{
    [GeneratedCode("T4Template", "1.0")]
    public partial class O2OIdentityCard3
    {

        #region RelationsMetadata
        #pragma warning disable

        public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Owner", new OneToOneRelationMetadata
                {
                    RelatedModelType = typeof(O2OPerson3),
                    RelatedModelProperty = typeof(O2OPerson3).GetProperty("IdentityCard"),
                    RelatedModelIdProperty = typeof(O2OPerson3).GetProperty("Id"),
                    AssociationType = AssociationType.Bidirectional,
                    Field = typeof(O2OIdentityCard3).GetField("_owner", BindingFlags.Instance | BindingFlags.NonPublic),
                    ParameterName = "owner",
                    Property = typeof(O2OIdentityCard3).GetProperty("Owner"),
                    SetMethod = typeof(O2OIdentityCard3).GetMethods().FirstOrDefault(o => o.Name == "SetOwner" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(O2OPerson3)),
                    UnsetMethod = typeof(O2OIdentityCard3).GetMethods().FirstOrDefault(o => o.Name == "UnsetOwner" && o.GetParameters().Length == 0),
                    SyntheticProperty = typeof(O2OIdentityCard3).GetProperty("OwnerId"),
                    SyntheticField = typeof(O2OIdentityCard3).GetField("_ownerId", BindingFlags.Instance | BindingFlags.NonPublic),
                    SyntheticPropertyMaxLength = null,
                    IsSyntheticPropertyTypeRequired = false,
                    
                }},
        
            };
        #pragma warning restore
        #endregion

        #region Owner

        private O2OPerson3 _owner;

        [ReadOnly(true)]
        public virtual int? OwnerId 
        { 
            get
            {
                if(_isOwnerIdSet) return _ownerId;
                return Owner == null ? default(int?) : Owner.Id;
            }
            set 
            {
                _isOwnerIdSet = true;
                _ownerId = value; 
            }
        }

        private int? _ownerId;

        private bool _isOwnerIdSet = false;

        public virtual void SetOwner(O2OPerson3 owner)
        {
            this.SetOneToOne(o => o.Owner, owner, o => o.IdentityCard);
        }

        public virtual Task SetOwnerAsync(O2OPerson3 owner)
        {
            return this.SetOneToOneAsync(o => o.Owner, owner, o => o.IdentityCard);
        }

        public virtual void UnsetOwner()
        {
            this.UnsetOneToOne(o => o.Owner, o => o.IdentityCard);
        }    

        public virtual Task UnsetOwnerAsync()
        {
            return this.UnsetOneToOneAsync(o => o.Owner, o => o.IdentityCard);
        }    

        #endregion


        private void ResetField<T>(ref T field, T value, ref bool synthIsSetField)
        {
            field = value;
            synthIsSetField = false;
        }
    }
}
