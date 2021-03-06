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
//<EntityProjectItem xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"><EntityFullName>T4FluentNH.Tests.EntityTypes.ETSimpleEntity</EntityFullName><EntityFilePaths><string>EntityTypes\ETSimpleEntity.cs</string></EntityFilePaths><OverrideFilePaths /><GeneratedFilePath>ETSimpleEntity.generated.cs</GeneratedFilePath></EntityProjectItem>
namespace T4FluentNH.Tests.EntityTypes
{
    [GeneratedCode("T4Template", "1.0")]
    public partial class ETSimpleEntity
    {

        #region RelationsMetadata
        #pragma warning disable

        public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"CodeListEntity", new ManyToOneRelationMetadata
                {
                    RelatedModelType = typeof(ETCodeListEntity),
                    RelatedModelIdProperty = typeof(ETCodeListEntity).GetProperty("Code"),
                    AssociationType = AssociationType.Unidirectional,
                    Field = typeof(ETSimpleEntity).GetField("_codeListEntity", BindingFlags.Instance | BindingFlags.NonPublic),
                    ParameterName = "codeListEntity",
                    Property = typeof(ETSimpleEntity).GetProperty("CodeListEntity"),
                    SyntheticProperty = typeof(ETSimpleEntity).GetProperty("CodeListEntityCode"),
                    SyntheticField = typeof(ETSimpleEntity).GetField("_codeListEntityCode", BindingFlags.Instance | BindingFlags.NonPublic),
                    SyntheticPropertyMaxLength = 20,
                    IsSyntheticPropertyTypeRequired = false,
                    
                }},
        
                {"InheritCodeListEntity", new ManyToOneRelationMetadata
                {
                    RelatedModelType = typeof(ETInheritedCodeListEntity),
                    RelatedModelIdProperty = typeof(ETInheritedCodeListEntity).GetProperty("Code"),
                    AssociationType = AssociationType.Unidirectional,
                    Field = typeof(ETSimpleEntity).GetField("_inheritCodeListEntity", BindingFlags.Instance | BindingFlags.NonPublic),
                    ParameterName = "inheritCodeListEntity",
                    Property = typeof(ETSimpleEntity).GetProperty("InheritCodeListEntity"),
                    SyntheticProperty = typeof(ETSimpleEntity).GetProperty("InheritCodeListEntityCode"),
                    SyntheticField = typeof(ETSimpleEntity).GetField("_inheritCodeListEntityCode", BindingFlags.Instance | BindingFlags.NonPublic),
                    SyntheticPropertyMaxLength = 20,
                    IsSyntheticPropertyTypeRequired = false,
                    
                }},
        
                {"LengthCodeListEntity", new ManyToOneRelationMetadata
                {
                    RelatedModelType = typeof(ETLengthCodeList),
                    RelatedModelIdProperty = typeof(ETLengthCodeList).GetProperty("Code"),
                    AssociationType = AssociationType.Unidirectional,
                    Field = typeof(ETSimpleEntity).GetField("_lengthCodeListEntity", BindingFlags.Instance | BindingFlags.NonPublic),
                    ParameterName = "lengthCodeListEntity",
                    Property = typeof(ETSimpleEntity).GetProperty("LengthCodeListEntity"),
                    SyntheticProperty = typeof(ETSimpleEntity).GetProperty("LengthCodeListEntityCode"),
                    SyntheticField = typeof(ETSimpleEntity).GetField("_lengthCodeListEntityCode", BindingFlags.Instance | BindingFlags.NonPublic),
                    SyntheticPropertyMaxLength = 30,
                    IsSyntheticPropertyTypeRequired = false,
                    
                }},
        
                {"AttrLengthByIndexCodeList", new ManyToOneRelationMetadata
                {
                    RelatedModelType = typeof(ETAttrLengthByIndexCodeList),
                    RelatedModelIdProperty = typeof(ETAttrLengthByIndexCodeList).GetProperty("Code"),
                    AssociationType = AssociationType.Unidirectional,
                    Field = typeof(ETSimpleEntity).GetField("_attrLengthByIndexCodeList", BindingFlags.Instance | BindingFlags.NonPublic),
                    ParameterName = "attrLengthByIndexCodeList",
                    Property = typeof(ETSimpleEntity).GetProperty("AttrLengthByIndexCodeList"),
                    SyntheticProperty = typeof(ETSimpleEntity).GetProperty("AttrLengthByIndexCodeListCode"),
                    SyntheticField = typeof(ETSimpleEntity).GetField("_attrLengthByIndexCodeListCode", BindingFlags.Instance | BindingFlags.NonPublic),
                    SyntheticPropertyMaxLength = 14,
                    IsSyntheticPropertyTypeRequired = false,
                    
                }},
        
                {"AttrLengthByPropertyCodeList", new ManyToOneRelationMetadata
                {
                    RelatedModelType = typeof(ETAttrLengthByPropertyCodeList),
                    RelatedModelIdProperty = typeof(ETAttrLengthByPropertyCodeList).GetProperty("Code"),
                    AssociationType = AssociationType.Unidirectional,
                    Field = typeof(ETSimpleEntity).GetField("_attrLengthByPropertyCodeList", BindingFlags.Instance | BindingFlags.NonPublic),
                    ParameterName = "attrLengthByPropertyCodeList",
                    Property = typeof(ETSimpleEntity).GetProperty("AttrLengthByPropertyCodeList"),
                    SyntheticProperty = typeof(ETSimpleEntity).GetProperty("AttrLengthByPropertyCodeListCode"),
                    SyntheticField = typeof(ETSimpleEntity).GetField("_attrLengthByPropertyCodeListCode", BindingFlags.Instance | BindingFlags.NonPublic),
                    SyntheticPropertyMaxLength = 11,
                    IsSyntheticPropertyTypeRequired = false,
                    
                }},
        
            };
        #pragma warning restore
        #endregion

        #region CodeListEntity

        private ETCodeListEntity _codeListEntity;

        [ReadOnly(true)]
        [T4FluentNH.Tests.LengthAttribute(20)]
        public virtual string CodeListEntityCode 
        {
            get 
            {
                if(_isCodeListEntityCodeSet) return _codeListEntityCode;
                return CodeListEntity == null ? default(string) : CodeListEntity.Code;
            }
            set 
            {
                _isCodeListEntityCodeSet = true;
                _codeListEntityCode = value; 
            }
        }

        private string _codeListEntityCode;

        private bool _isCodeListEntityCodeSet = false;

        #endregion

        #region InheritCodeListEntity

        private ETInheritedCodeListEntity _inheritCodeListEntity;

        [ReadOnly(true)]
        [T4FluentNH.Tests.LengthAttribute(20)]
        public virtual string InheritCodeListEntityCode 
        {
            get 
            {
                if(_isInheritCodeListEntityCodeSet) return _inheritCodeListEntityCode;
                return InheritCodeListEntity == null ? default(string) : InheritCodeListEntity.Code;
            }
            set 
            {
                _isInheritCodeListEntityCodeSet = true;
                _inheritCodeListEntityCode = value; 
            }
        }

        private string _inheritCodeListEntityCode;

        private bool _isInheritCodeListEntityCodeSet = false;

        #endregion

        #region LengthCodeListEntity

        private ETLengthCodeList _lengthCodeListEntity;

        [ReadOnly(true)]
        [T4FluentNH.Tests.LengthAttribute(30)]
        public virtual string LengthCodeListEntityCode 
        {
            get 
            {
                if(_isLengthCodeListEntityCodeSet) return _lengthCodeListEntityCode;
                return LengthCodeListEntity == null ? default(string) : LengthCodeListEntity.Code;
            }
            set 
            {
                _isLengthCodeListEntityCodeSet = true;
                _lengthCodeListEntityCode = value; 
            }
        }

        private string _lengthCodeListEntityCode;

        private bool _isLengthCodeListEntityCodeSet = false;

        #endregion

        #region AttrLengthByIndexCodeList

        private ETAttrLengthByIndexCodeList _attrLengthByIndexCodeList;

        [ReadOnly(true)]
        [T4FluentNH.Tests.LengthAttribute(14)]
        public virtual string AttrLengthByIndexCodeListCode 
        {
            get 
            {
                if(_isAttrLengthByIndexCodeListCodeSet) return _attrLengthByIndexCodeListCode;
                return AttrLengthByIndexCodeList == null ? default(string) : AttrLengthByIndexCodeList.Code;
            }
            set 
            {
                _isAttrLengthByIndexCodeListCodeSet = true;
                _attrLengthByIndexCodeListCode = value; 
            }
        }

        private string _attrLengthByIndexCodeListCode;

        private bool _isAttrLengthByIndexCodeListCodeSet = false;

        #endregion

        #region AttrLengthByPropertyCodeList

        private ETAttrLengthByPropertyCodeList _attrLengthByPropertyCodeList;

        [ReadOnly(true)]
        [T4FluentNH.Tests.LengthAttribute(11)]
        public virtual string AttrLengthByPropertyCodeListCode 
        {
            get 
            {
                if(_isAttrLengthByPropertyCodeListCodeSet) return _attrLengthByPropertyCodeListCode;
                return AttrLengthByPropertyCodeList == null ? default(string) : AttrLengthByPropertyCodeList.Code;
            }
            set 
            {
                _isAttrLengthByPropertyCodeListCodeSet = true;
                _attrLengthByPropertyCodeListCode = value; 
            }
        }

        private string _attrLengthByPropertyCodeListCode;

        private bool _isAttrLengthByPropertyCodeListCodeSet = false;

        #endregion


        private void ResetField<T>(ref T field, T value, ref bool synthIsSetField)
        {
            field = value;
            synthIsSetField = false;
        }
    }
}
