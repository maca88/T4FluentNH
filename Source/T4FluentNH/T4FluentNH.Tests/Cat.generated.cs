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
//<EntityProjectItem xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"><EntityFullName>T4FluentNH.Tests.Inheritance.Cat</EntityFullName><EntityFilePaths><string>Inheritance\Cat.cs</string></EntityFilePaths><OverrideFilePaths /><GeneratedFilePath>Cat.generated.cs</GeneratedFilePath></EntityProjectItem>
namespace T4FluentNH.Tests.Inheritance
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class Cat
	{

		#region RelationsMetadata
		#pragma warning disable

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
            };
		#pragma warning restore
		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
