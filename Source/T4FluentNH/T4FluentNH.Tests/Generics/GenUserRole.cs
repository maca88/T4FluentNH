using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests.Generics
{
    public partial class GenUserRole<TUser> : Entity
    {
        public virtual TUser User { get; set; }

        public virtual GenRole Role { get; set; }
    }
}
