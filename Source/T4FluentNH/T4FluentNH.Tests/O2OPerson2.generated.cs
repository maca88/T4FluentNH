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
//<EntityProjectItem xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"><EntityFullName>T4FluentNH.Tests.OneToOne.O2OPerson2</EntityFullName><EntityFilePaths><string>OneToOne\O2OPerson2.cs</string></EntityFilePaths><OverrideFilePaths /><GeneratedFilePath>O2OPerson2.generated.cs</GeneratedFilePath></EntityProjectItem>
namespace T4FluentNH.Tests.OneToOne
{
    [GeneratedCode("T4Template", "1.0")]
    public partial class O2OPerson2
    {

        #region RelationsMetadata
        #pragma warning disable

        public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"IdentityCard", new OneToOneRelationMetadata
                {
                    RelatedModelType = typeof(O2OIdentityCard2),
                    RelatedModelProperty = typeof(O2OIdentityCard2).GetProperty("Owner"),
                    RelatedModelIdProperty = typeof(O2OIdentityCard2).GetProperty("Id"),
                    AssociationType = AssociationType.Bidirectional,
                    Field = typeof(O2OPerson2).GetField("_identityCard", BindingFlags.Instance | BindingFlags.NonPublic),
                    ParameterName = "identityCard",
                    Property = typeof(O2OPerson2).GetProperty("IdentityCard"),
                    SetMethod = typeof(O2OPerson2).GetMethods().FirstOrDefault(o => o.Name == "SetIdentityCard" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(O2OIdentityCard2)),
                    UnsetMethod = typeof(O2OPerson2).GetMethods().FirstOrDefault(o => o.Name == "UnsetIdentityCard" && o.GetParameters().Length == 0),
                    SyntheticProperty = typeof(O2OPerson2).GetProperty("IdentityCardId"),
                    SyntheticField = typeof(O2OPerson2).GetField("_identityCardId", BindingFlags.Instance | BindingFlags.NonPublic),
                    SyntheticPropertyMaxLength = null,
                    IsSyntheticPropertyTypeRequired = false,
                    
                }},
        
            };
        #pragma warning restore
        #endregion

        #region IdentityCard

        private O2OIdentityCard2 _identityCard;

        [ReadOnly(true)]
        public virtual int? IdentityCardId 
        { 
            get
            {
                if(_isIdentityCardIdSet) return _identityCardId;
                return IdentityCard == null ? default(int?) : IdentityCard.Id;
            }
            set 
            {
                _isIdentityCardIdSet = true;
                _identityCardId = value; 
            }
        }

        private int? _identityCardId;

        private bool _isIdentityCardIdSet = false;

        public virtual void SetIdentityCard(O2OIdentityCard2 identityCard)
        {
            this.SetOneToOne(o => o.IdentityCard, identityCard, o => o.Owner);
        }

        public virtual Task SetIdentityCardAsync(O2OIdentityCard2 identityCard)
        {
            return this.SetOneToOneAsync(o => o.IdentityCard, identityCard, o => o.Owner);
        }

        public virtual void UnsetIdentityCard()
        {
            this.UnsetOneToOne(o => o.IdentityCard, o => o.Owner);
        }    

        public virtual Task UnsetIdentityCardAsync()
        {
            return this.UnsetOneToOneAsync(o => o.IdentityCard, o => o.Owner);
        }    

        #endregion


        private void ResetField<T>(ref T field, T value, ref bool synthIsSetField)
        {
            field = value;
            synthIsSetField = false;
        }
    }
}
