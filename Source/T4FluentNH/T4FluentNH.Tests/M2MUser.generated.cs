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
        public virtual void AddRole(T4FluentNH.Tests.ManyToMany.TestM2MRole role)
        {
            this.AddManyToMany(o => o.Roles, role, o => o.Users);
        }

        public virtual void RemoveRole(T4FluentNH.Tests.ManyToMany.TestM2MRole role)
        {
            this.RemoveManyToMany(o => o.Roles, role, o => o.Users);
        }

		#endregion

	}
}
