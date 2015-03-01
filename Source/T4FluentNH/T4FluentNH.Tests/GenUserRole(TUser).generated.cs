using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.Generics
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class GenUserRole<TUser>
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Role", new ManyToOneRelationMetadata
                {
					RelatedModelType = typeof(GenRole),
					RelatedModelIdProperty = typeof(GenRole).GetProperty("Id"),
					AssociationType = AssociationType.Unidirectional,
					Field = typeof(GenUserRole<TUser>).GetField("_role", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "role",
					Property = typeof(GenUserRole<TUser>).GetProperty("Role"),
					SyntheticProperty = typeof(GenUserRole<TUser>).GetProperty("RoleId"),
					SyntheticField = typeof(GenUserRole<TUser>).GetField("_roleId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
            };

		#endregion

		#region Role

        private GenRole _role;

        [ReadOnly(true)]
		public virtual int? RoleId 
		{ 
			get { return _roleId != default(int?) || Role == null ? _roleId : Role.Id; } 
			set { _roleId = value; }
		}

		private int? _roleId;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
