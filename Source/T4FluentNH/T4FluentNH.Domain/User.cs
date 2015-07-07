using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Domain
{
    public class User<TOrganization> : Entity
        where TOrganization: IOrganization
    {
        public virtual TOrganization Organization { get; set; }

        public virtual int OrganizationId { get; set; }
    }
}
