using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests.Generics
{
    public abstract partial class GenUserRole<TUser> : Domain.Entity
    {
        public virtual TUser User { get; set; }

        public virtual GenRole Role
        {
            get { return _role; }
            set { ResetField(ref _role, value, ref _isRoleIdSet); }
        }
    }
}
