using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4FluentNH.Domain;

namespace T4FluentNH.Tests
{
    public abstract partial class CodeList : IEntity
    {
        public virtual string Code { get; set; }
    }
}
