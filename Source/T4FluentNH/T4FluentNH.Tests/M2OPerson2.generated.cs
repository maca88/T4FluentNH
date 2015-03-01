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
	public partial class M2OPerson2
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Car", new ManyToOneRelationMetadata
                {
					RelatedModelType = typeof(M2OCar2),
					RelatedModelIdProperty = typeof(M2OCar2).GetProperty("Id"),
					AssociationType = AssociationType.Unidirectional,
					Field = typeof(M2OPerson2).GetField("_car", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "car",
					Property = typeof(M2OPerson2).GetProperty("Car"),
					SyntheticProperty = typeof(M2OPerson2).GetProperty("CarId"),
					SyntheticField = typeof(M2OPerson2).GetField("_carId", BindingFlags.Instance | BindingFlags.NonPublic),
					SyntheticPropertyMaxLength = null,
					IsSyntheticPropertyTypeRequired = false,
					
                }},
		
            };

		#endregion

		#region Car

        private M2OCar2 _car;

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
