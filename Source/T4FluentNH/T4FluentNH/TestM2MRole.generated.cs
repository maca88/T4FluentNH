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

        public virtual void AddUser(M2MUser users)
        {
            this.AddManyToMany(o => o.Users, users, o => o.Roles);
        }

        public virtual void RemoveUser(M2MUser users)
        {
            this.RemoveManyToMany(o => o.Users, users, o => o.Roles);
        }

		#endregion

	}
}
