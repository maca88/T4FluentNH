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
	public partial class O2MPerson
	{

    

		#region Cars

		private ISet<M2OCar> _cars;

        public virtual void AddCar(M2OCar cars)
        {
            this.AddOneToMany(o => o.Cars, cars, o => o.Owwwner, o=> o.RemoveCar);
        }

        public virtual void RemoveCar(M2OCar cars)
        {
            this.RemoveOneToMany(o => o.Cars, cars, o => o.Owwwner);
        }

		#endregion

	}
}
