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

        //Bidirectional association
        public virtual M2OCar Car { get; set; }
    }


    public partial class M2OCar : Entity
    {
        public virtual string Model { get; set; }

        public virtual M2OPerson Person { get; set; }
    }

}
