using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
