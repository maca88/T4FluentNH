using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4FluentNH.Attributes;

namespace T4FluentNH.Tests.Naming
{
    public partial class Case : Entity
    {
        public virtual string Test { get; set; }

        [AsOneToOne]
        public virtual Switch Switch { get { return _switch; } set { SetField(ref _switch, value, ref _switchId); } }
    }

    public partial class Switch : Entity
    {
        public virtual string Name { get; set; }

        [AsOneToOne]
        public virtual Case Case { get { return _case; } set { SetField(ref _case, value, ref _caseId); } }
    }
}
