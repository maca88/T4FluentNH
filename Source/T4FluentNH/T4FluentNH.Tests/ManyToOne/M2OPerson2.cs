using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests.ManyToOne
{
    public partial class M2OPerson2 : Entity
    {
        public virtual string Name { get; set; }

        //Unidirectional association
        public virtual M2OCar2 Car { get; set; }
    }


    public partial class M2OCar2 : Entity
    {
        public virtual string Model { get; set; }

    }

}
