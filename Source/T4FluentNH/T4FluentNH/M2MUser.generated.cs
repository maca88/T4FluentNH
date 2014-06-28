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
	public partial class M2MUser
	{

    

		#region Roles

		private ISet<TestM2MRole> _roles;

        public virtual void AddRole(TestM2MRole roles)
        {
            this.AddManyToMany(o => o.Roles, roles, o => o.Users);
        }

        public virtual void RemoveRole(TestM2MRole roles)
        {
            this.RemoveManyToMany(o => o.Roles, roles, o => o.Users);
        }

		#endregion

	}
}
