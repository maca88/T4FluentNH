using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests.Inheritance
{
    public abstract partial class Animal : Entity
    {
        public virtual string Name { get; set; }

        public virtual Owner Owner { get { return _owner; } set { SetField(ref _owner, value, ref _ownerId); } }
    }
}
