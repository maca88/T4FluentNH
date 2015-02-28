using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.Inheritance
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class Owner
	{

		#region Dogs

		private ISet<Dog> _dogs;

        public virtual void AddDog(Dog dog)
        {
            this.AddOneToMany(o => o.Dogs, dog, o => o.Owner, o=> o.RemoveDog);
        }

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

        public virtual void RemoveCat(Cat cat)
        {
			this.RemoveOneToMany(o => o.Cats, cat, o => o.Owner);
        }

		#endregion


		private void SetField<T, TSynth>(ref T field, T vatue, ref TSynth synthField)
        {
            field = vatue;
            synthField = default(TSynth);
        }
	}
}
