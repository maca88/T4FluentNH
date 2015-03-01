using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
using T4FluentNH.Metadata;
namespace T4FluentNH.Tests.Inheritance
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class Owner
	{

		#region RelationsMetadata

		public new static readonly Dictionary<string, RelationMetadata> RelationsMetadata =
            new Dictionary<string, RelationMetadata>
            {
                {"Dogs", new OneToManyRelationMetadata
                {
					RelatedModelType = typeof(Dog),
					RelatedModelProperty = typeof(Dog).GetProperty("Owner"),
					RelatedModelIdProperty = typeof(Dog).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(Owner).GetField("_dogs", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "dog",
					Property = typeof(Owner).GetProperty("Dogs"),
                    AddMethod = typeof(Owner).GetMethods().FirstOrDefault(o => o.Name == "AddDog" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(Dog)),
					RemoveMethod = typeof(Owner).GetMethods().FirstOrDefault(o => o.Name == "RemoveDog" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(Dog)),
					CollectionMapType = CollectionMapType.Unknown,
					
                }},
		
                {"Cats", new OneToManyRelationMetadata
                {
					RelatedModelType = typeof(Cat),
					RelatedModelProperty = typeof(Cat).GetProperty("Owner"),
					RelatedModelIdProperty = typeof(Cat).GetProperty("Id"),
					AssociationType = AssociationType.Bidirectional,
					Field = typeof(Owner).GetField("_cats", BindingFlags.Instance | BindingFlags.NonPublic),
					ParameterName = "cat",
					Property = typeof(Owner).GetProperty("Cats"),
                    AddMethod = typeof(Owner).GetMethods().FirstOrDefault(o => o.Name == "AddCat" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(Cat)),
					RemoveMethod = typeof(Owner).GetMethods().FirstOrDefault(o => o.Name == "RemoveCat" && o.GetParameters().Length == 1 && o.GetParameters()[0].ParameterType == typeof(Cat)),
					CollectionMapType = CollectionMapType.Unknown,
					
                }},
		
            };

		#endregion

		#region Dogs

		private ISet<Dog> _dogs;

        public virtual void RemoveDog(Dog dog)
        {
			this.RemoveOneToMany(o => o.Dogs, dog, o => o.Owner);
        }

		#endregion

		#region Cats

		private ISet<Cat> _cats;

        public virtual void AddCat(Cat cat)
        {
            this.AddOneToMany(o => o.Cats, cat, o => o.Owner, o=> o.RemoveCat);
        }

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
