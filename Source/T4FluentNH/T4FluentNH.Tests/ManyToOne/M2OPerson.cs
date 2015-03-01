using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests.ManyToOne
{
    public partial class M2OPerson : Entity
    {
        public virtual string Name { get; set; }

        //Unidirectional association
        public virtual M2OCar Car
        {
            get { return _car; }
            set { SetField(ref _car, value, ref _carId); }
        }
    }


    public partial class M2OCar : Entity
    {
        public virtual string Model { get; set; }

        //Unidirectional association
        public virtual M2OPerson Person
        {
            get { return _person; }
            set { SetField(ref _person, value, ref _personId); }
        }
    }

}
