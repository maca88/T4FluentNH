﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4FluentNH.Domain;

namespace T4FluentNH.Tests.External
{
    public partial class ExtVersionedEntity : VersionedEntity
    {
        public virtual string Name { get; set; }

    }
}
