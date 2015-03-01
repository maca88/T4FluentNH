using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
using T4FluentNH.Metadata;
namespace T4FluentNH.Tests.External
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class ExtTest
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"User", new ManyToOneRelationMetadata
                {
					RelatedModelType = typeof(T4FluentNH.Domain.IUser),
					RelatedModelIdProperty = typeof(T4FluentNH.Domain.IUser).GetProperty("Id"),
					AssociationType = AssociationType.Unidirectional,
					Field = typeof(ExtTest).GetField("_user", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "user",
					Property = typeof(ExtTest).GetProperty("User"),
					SyntheticProperty = typeof(ExtTest).GetProperty("UserId"),
					SyntheticField = typeof(ExtTest).GetField("_userId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
            };

		#endregion

		#region User

        private T4FluentNH.Domain.IUser _user;

        [ReadOnly(true)]
		public virtual int? UserId 
		{ 
			get { return _userId != default(int?) || User == null ? _userId : User.Id; } 
			set { _userId = value; }
		}

		private int? _userId;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
