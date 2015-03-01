using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4FluentNH.Domain;

namespace T4FluentNH.Tests.External
{
    public partial class ExtTest : Domain.Entity
    {
        public virtual IUser User
        {
            get { return _user; }
            set { SetField(ref _user, value, ref _userId); }
        }

    }
}
