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

		private ISet<O2MCar> _cars;

        public virtual void AddCar(O2MCar car)
        {
            this.AddOneToMany(o => o.Cars, car, o => o.Owner, o=> o.RemoveCar);
        }

        public virtual void RemoveCar(O2MCar car)
        {
            this.RemoveOneToMany(o => o.Cars, car, o => o.Owner);
        }

		#endregion

	}
}
