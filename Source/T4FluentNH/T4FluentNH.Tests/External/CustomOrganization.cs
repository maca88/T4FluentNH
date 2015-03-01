using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using T4FluentNH.Domain;

namespace T4FluentNH.Tests.External
{
    public partial class CustomOrganization : Entity, IOrganization
    {
        public virtual ISet<CustomUser> Users
        {
            get { return _users ?? (_users = new HashSet<CustomUser>()); }
            set { _users = value; }
        } 
    }

    public class CustomOrganizationOverride : IAutoMappingOverride<CustomOrganization>
    {
        public void Override(AutoMapping<CustomOrganization> mapping)
        {
            mapping.HasMany(o => o.Users).KeyColumn(o => o.Organization);
        }
    }
}
