using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
using T4FluentNH.Metadata;
namespace T4FluentNH.Tests.ManyToOne
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class M2OPerson
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Car", new ManyToOneRelationMetadata
                {
					RelatedModelType = typeof(M2OCar),
					RelatedModelIdProperty = typeof(M2OCar).GetProperty("Id"),
					AssociationType = AssociationType.Unidirectional,
					Field = typeof(M2OPerson).GetField("_car", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "car",
					Property = typeof(M2OPerson).GetProperty("Car"),
					SyntheticProperty = typeof(M2OPerson).GetProperty("CarId"),
					SyntheticField = typeof(M2OPerson).GetField("_carId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
            };

		#endregion

		#region Car

        private M2OCar _car;

        [ReadOnly(true)]
		public virtual int? CarId 
		{ 
			get { return _carId != default(int?) || Car == null ? _carId : Car.Id; } 
			set { _carId = value; }
		}

		private int? _carId;

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
