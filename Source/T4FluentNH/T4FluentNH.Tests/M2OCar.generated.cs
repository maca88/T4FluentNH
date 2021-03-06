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
//<EntityProjectItem xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"><EntityFullName>T4FluentNH.Tests.ManyToOne.M2OCar</EntityFullName><EntityFilePaths><string>ManyToOne\M2OPerson.cs</string></EntityFilePaths><OverrideFilePaths /><GeneratedFilePath>M2OCar.generated.cs</GeneratedFilePath></EntityProjectItem>
namespace T4FluentNH.Tests.ManyToOne
{
    [GeneratedCode("T4Template", "1.0")]
    public partial class M2OCar
    {

        #region RelationsMetadata
        #pragma warning disable

        public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Person", new ManyToOneRelationMetadata
                {
                    RelatedModelType = typeof(M2OPerson),
                    RelatedModelIdProperty = typeof(M2OPerson).GetProperty("Id"),
                    AssociationType = AssociationType.Unidirectional,
                    Field = typeof(M2OCar).GetField("_person", BindingFlags.Instance | BindingFlags.NonPublic),
                    ParameterName = "person",
                    Property = typeof(M2OCar).GetProperty("Person"),
                    SyntheticProperty = typeof(M2OCar).GetProperty("PersonId"),
                    SyntheticField = typeof(M2OCar).GetField("_personId", BindingFlags.Instance | BindingFlags.NonPublic),
                    SyntheticPropertyMaxLength = null,
                    IsSyntheticPropertyTypeRequired = false,
                    
                }},
        
            };
        #pragma warning restore
        #endregion

        #region Person

        private M2OPerson _person;

        [ReadOnly(true)]
        public virtual int? PersonId 
        {
            get 
            {
                if(_isPersonIdSet) return _personId;
                return Person == null ? default(int?) : Person.Id;
            }
            set 
            {
                _isPersonIdSet = true;
                _personId = value; 
            }
        }

        private int? _personId;

        private bool _isPersonIdSet = false;

        #endregion


        private void ResetField<T>(ref T field, T value, ref bool synthIsSetField)
        {
            field = value;
            synthIsSetField = false;
        }
    }
}
