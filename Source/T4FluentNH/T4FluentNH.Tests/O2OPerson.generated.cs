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
//<EntityProjectItem xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"><EntityFullName>T4FluentNH.Tests.OneToOne.O2OPerson</EntityFullName><EntityFilePaths><string>OneToOne\O2OPerson.cs</string></EntityFilePaths><OverrideFilePaths /><GeneratedFilePath>O2OPerson.generated.cs</GeneratedFilePath></EntityProjectItem>
namespace T4FluentNH.Tests.OneToOne
{
    [GeneratedCode("T4Template", "1.0")]
    public partial class O2OPerson
    {

        #region RelationsMetadata
        #pragma warning disable

        public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"MarriedWith", new OneToOneRelationMetadata
                {
                    RelatedModelType = typeof(O2OPerson),
                    RelatedModelProperty = typeof(O2OPerson).GetProperty("MarriedWith"),
                    RelatedModelIdProperty = typeof(O2OPerson).GetProperty("Id"),
                    AssociationType = AssociationType.Bidirectional,
                    Field = typeof(O2OPerson).GetField("_marriedWith", BindingFlags.Instance | BindingFlags.NonPublic),
                    ParameterName = "marriedWith",
                    Property = typeof(O2OPerson).GetProperty("MarriedWith"),
                    SetMethod = typeof(O2OPerson).GetMethods().FirstOrDefault(o => o.Name == "SetMarriedWith" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(O2OPerson)),
                    UnsetMethod = typeof(O2OPerson).GetMethods().FirstOrDefault(o => o.Name == "UnsetMarriedWith" && o.GetParameters().Length == 0),
                    SyntheticProperty = typeof(O2OPerson).GetProperty("MarriedWithId"),
                    SyntheticField = typeof(O2OPerson).GetField("_marriedWithId", BindingFlags.Instance | BindingFlags.NonPublic),
                    SyntheticPropertyMaxLength = null,
                    IsSyntheticPropertyTypeRequired = false,
                    
                }},
        
                {"Twin", new OneToOneRelationMetadata
                {
                    RelatedModelType = typeof(O2OPerson),
                    RelatedModelProperty = typeof(O2OPerson).GetProperty("Twin"),
                    RelatedModelIdProperty = typeof(O2OPerson).GetProperty("Id"),
                    AssociationType = AssociationType.Bidirectional,
                    Field = typeof(O2OPerson).GetField("_twin", BindingFlags.Instance | BindingFlags.NonPublic),
                    ParameterName = "twin",
                    Property = typeof(O2OPerson).GetProperty("Twin"),
                    SetMethod = typeof(O2OPerson).GetMethods().FirstOrDefault(o => o.Name == "SetTwin" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(O2OPerson)),
                    UnsetMethod = typeof(O2OPerson).GetMethods().FirstOrDefault(o => o.Name == "UnsetTwin" && o.GetParameters().Length == 0),
                    SyntheticProperty = typeof(O2OPerson).GetProperty("TwinId"),
                    SyntheticField = typeof(O2OPerson).GetField("_twinId", BindingFlags.Instance | BindingFlags.NonPublic),
                    SyntheticPropertyMaxLength = null,
                    IsSyntheticPropertyTypeRequired = false,
                    
                }},
        
            };
        #pragma warning restore
        #endregion

        #region MarriedWith

        private O2OPerson _marriedWith;

        [ReadOnly(true)]
        public virtual int? MarriedWithId 
        { 
            get
            {
                if(_isMarriedWithIdSet) return _marriedWithId;
                return MarriedWith == null ? default(int?) : MarriedWith.Id;
            }
            set 
            {
                _isMarriedWithIdSet = true;
                _marriedWithId = value; 
            }
        }

        private int? _marriedWithId;

        private bool _isMarriedWithIdSet = false;

        public virtual Task SetMarriedWithAsync(O2OPerson marriedWith)
        {
            return this.SetOneToOneAsync(o => o.MarriedWith, marriedWith, o => o.MarriedWith);
        }

        public virtual void UnsetMarriedWith()
        {
            this.UnsetOneToOne(o => o.MarriedWith, o => o.MarriedWith);
        }    

        public virtual Task UnsetMarriedWithAsync()
        {
            return this.UnsetOneToOneAsync(o => o.MarriedWith, o => o.MarriedWith);
        }    

        #endregion

        #region Twin

        private O2OPerson _twin;

        [ReadOnly(true)]
        public virtual int? TwinId 
        { 
            get
            {
                if(_isTwinIdSet) return _twinId;
                return Twin == null ? default(int?) : Twin.Id;
            }
            set 
            {
                _isTwinIdSet = true;
                _twinId = value; 
            }
        }

        private int? _twinId;

        private bool _isTwinIdSet = false;

        public virtual void SetTwin(O2OPerson twin)
        {
            this.SetOneToOne(o => o.Twin, twin, o => o.Twin);
        }

        public virtual Task SetTwinAsync(O2OPerson twin)
        {
            return this.SetOneToOneAsync(o => o.Twin, twin, o => o.Twin);
        }

        public virtual Task UnsetTwinAsync()
        {
            return this.UnsetOneToOneAsync(o => o.Twin, o => o.Twin);
        }    

        #endregion


        private void ResetField<T>(ref T field, T value, ref bool synthIsSetField)
        {
            field = value;
            synthIsSetField = false;
        }
    }
}
