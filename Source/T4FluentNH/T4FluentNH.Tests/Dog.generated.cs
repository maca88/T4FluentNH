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
//<EntityProjectItem xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"><EntityFullName>T4FluentNH.Tests.Inheritance.Dog</EntityFullName><EntityFilePaths><string>Inheritance\Dog.cs</string></EntityFilePaths><OverrideFilePaths><string>Inheritance\Dog.cs</string></OverrideFilePaths><GeneratedFilePath>Dog.generated.cs</GeneratedFilePath></EntityProjectItem>
namespace T4FluentNH.Tests.Inheritance
{
    [GeneratedCode("T4Template", "1.0")]
    public partial class Dog
    {

        #region RelationsMetadata
        #pragma warning disable

        public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
            };
        #pragma warning restore
        #endregion


        private void ResetField<T>(ref T field, T value, ref bool synthIsSetField)
        {
            field = value;
            synthIsSetField = false;
        }
    }
}
