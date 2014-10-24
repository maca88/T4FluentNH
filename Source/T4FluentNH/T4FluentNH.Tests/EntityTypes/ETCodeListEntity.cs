using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests.EntityTypes
{
    public partial class ETCodeListEntity : CodeList
    {
        public virtual string Name { get; set; }

        public virtual ETSimpleEntity SimpleEntity { get; set; }

        
    }
}
