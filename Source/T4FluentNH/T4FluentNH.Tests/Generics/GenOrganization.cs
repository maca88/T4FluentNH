using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests.Generics
{
    public partial class GenOrganization : GenOrganization<GenUser, GenOrganization>
    {
        
    }

    public abstract partial class GenOrganization<TUser, TOrganization> : Domain.Entity
        where TUser : GenUser<TUser, TOrganization>
        where TOrganization: GenOrganization<TUser, TOrganization>
    {
        public virtual ISet<TUser> Users { get; set; }

        public virtual string Name { get; set; }

        public virtual ISet<GenOrganizationRole<TOrganization>> OrganizationRoles { get; set; }
    }
}
