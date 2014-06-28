using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace T4FluentNH.Tests.ManyToMany
{
    public partial class M2MUser : Entity
    {
        public virtual string Name { get; set; }

        public virtual ISet<TestM2MRole> Roles
        {
            get { return _roles ?? (_roles = new HashSet<TestM2MRole>()); }
            protected set { _roles = value; }
        }
    }

    public class M2MUserMapping : IAutoMappingOverride<M2MUser>
    {
        public void Override(AutoMapping<M2MUser> mapping)
        {
            mapping.HasManyToMany(o => o.Roles).Inverse();
        }
    }

    public partial class TestM2MRole : Entity
    {
        public virtual ISet<M2MUser> Users
        {
            get { return _users ?? (_users = new HashSet<M2MUser>()); }
            protected set { _users = value; }
        }
    }

    public class M2MRoleMapping : IAutoMappingOverride<TestM2MRole>
    {
        public void Override(AutoMapping<TestM2MRole> mapping)
        {
            mapping.HasManyToMany(o => o.Users);
        }
    }
}
