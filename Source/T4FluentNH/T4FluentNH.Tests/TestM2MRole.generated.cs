using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;
namespace T4FluentNH.Tests.ManyToMany
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class TestM2MRole
	{

		#region Users

		private ISet<M2MUser> _users;
        public virtual void AddUser(T4FluentNH.Tests.ManyToMany.M2MUser user)
        {
            this.AddManyToMany(o => o.Users, user, o => o.Roles);
        }

        public virtual void RemoveUser(T4FluentNH.Tests.ManyToMany.M2MUser user)
        {
            this.RemoveManyToMany(o => o.Users, user, o => o.Roles);
        }

		#endregion

	}
}
