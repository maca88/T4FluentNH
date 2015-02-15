using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace T4FluentNH.Tests.EntityTypes
{
    public partial class ETLengthCodeList : CodeList
    {
    }

    public class ETLengthCodeListMapping : IAutoMappingOverride<ETLengthCodeList>
    {
        public void Override(AutoMapping<ETLengthCodeList> mapping)
        {
            mapping.Id(o => o.Code).GeneratedBy.Assigned();
        }
    }
}
