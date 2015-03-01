using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests.Generics
{
    public partial class GenUser : GenUser<GenUser, GenOrganization>
    {
    }

    public abstract partial class GenUser<TUser, TOrganization> : Domain.Entity
        where TUser : GenUser<TUser, TOrganization>
        where TOrganization : GenOrganization<TUser, TOrganization>
    {
        public virtual string UserName { get; set; }

        public virtual TOrganization Organization { get; set; }
    }
}
