using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Automapping;

namespace T4FluentNH.Tests.OneToMany
{
	[GeneratedCode("T4Template", "1.0")]
	public partial class M2OCar
	{

    

		#region Owwwner

            
        [ReadOnly(true)]
        public virtual int OwwwnerId { get; protected set; }

        public virtual void SetOwwwner(O2MPerson owwwner)
        {
            this.SetManyToOne(o => o.Owwwner, owwwner, o => o.RemoveCar, o => o.Cars);
        }

        public virtual void UnsetOwwwner()
        {
            this.UnsetManyToOne(o => o.Owwwner, o => o.Cars);
        }

		#endregion

	}
}
