using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;

namespace T4FluentNH.Tests.Inheritance
{
    public partial class Owner : Entity
    {
        public virtual ISet<Dog> Dogs
        {
            get { return _dogs ?? (_dogs = new HashSet<Dog>()); }
            set { _dogs = value; }
        }

        public virtual ISet<Cat> Cats
        {
            get { return _cats ?? (_cats = new HashSet<Cat>()); }
            set { _cats = value; }
        }

        //Custom Add method
        public virtual void AddDog(Dog dog)
        {
            this.AddOneToMany(o => o.Dogs, dog, o => o.Owner, o => o.RemoveDog);
        }

        //Custom remove method
        public virtual void RemoveCat(Cat cat)
        {
            this.RemoveOneToMany(o => o.Cats, cat, o => o.Owner);
        }
    }
}