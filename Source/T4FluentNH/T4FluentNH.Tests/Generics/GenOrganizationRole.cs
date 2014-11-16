﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests.Generics
{
    public abstract partial class GenOrganizationRole<TOrganization> : Entity
    {
        public virtual TOrganization Organization { get; set; }

        public virtual GenRole Role { get; set; }
    }
}
