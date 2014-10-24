using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests.EntityTypes
{
    public partial class ETSimpleEntity : Entity
    {
        public virtual string Name { get; set; }

        public virtual ETCodeListEntity CodeListEntity { get; set; }

        public virtual ETInheritedCodeListEntity InheritCodeListEntity { get; set; }

        public virtual ETLengthCodeList LengthCodeListEntity { get; set; }
    }
}
