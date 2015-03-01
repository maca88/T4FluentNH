using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4FluentNH.Attributes;

namespace T4FluentNH.Tests.Naming
{
    public partial class Case : Domain.Entity
    {
        public virtual string Test { get; set; }

        [AsOneToOne]
        public virtual Switch Switch
        {
            get { return _switch; }
            set { SetField(ref _switch, value, ref _switchId); }
        }

        public virtual ISet<Use> Uses
        {
            get { return _uses ?? (_uses = new HashSet<Use>()); }
            set { _uses = value; }
        } 
    }

    public partial class Switch : Domain.Entity
    {
        public virtual string Name { get; set; }

        [AsOneToOne]
        public virtual Case Case
        {
            get { return _case; }
            set { SetField(ref _case, value, ref _caseId); }
        }
    }

    public partial class Use : Domain.Entity
    {
        public virtual string Name { get; set; }

        public virtual Case Case
        {
            get { return _case; }
            set { SetField(ref _case, value, ref _caseId); }
        }

    }
}
