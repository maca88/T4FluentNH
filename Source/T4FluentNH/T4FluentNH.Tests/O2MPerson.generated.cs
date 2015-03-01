using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
using T4FluentNH.Metadata;
namespace T4FluentNH.Tests.OneToMany
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class O2MPerson
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Cars", new OneToManyRelationMetadata
                {
					RelatedModelType = typeof(O2MCar),
					RelatedModelProperty = typeof(O2MCar).GetProperty("Owner"),
					RelatedModelIdProperty = typeof(O2MCar).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(O2MPerson).GetField("_cars", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "car",
					Property = typeof(O2MPerson).GetProperty("Cars"),
                    AddMethod = typeof(O2MPerson).GetMethods().FirstOrDefault(o => o.Name == "AddCar" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(O2MCar)),
					RemoveMethod = typeof(O2MPerson).GetMethods().FirstOrDefault(o => o.Name == "RemoveCar" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(O2MCar)),
					CollectionMapType = CollectionMapType.Unknown,
					
                }},
		
            };

		#endregion

		#region Cars

		private ISet<O2MCar> _cars;

        public virtual void AddCar(O2MCar car)
        {
            this.AddOneToMany(o => o.Cars, car, o => o.Owner, o=> o.RemoveCar);
        }

        public virtual void RemoveCar(O2MCar car)
        {
			this.RemoveOneToMany(o => o.Cars, car, o => o.Owner);
        }

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
