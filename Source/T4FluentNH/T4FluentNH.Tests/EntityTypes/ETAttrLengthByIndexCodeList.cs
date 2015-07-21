using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace T4FluentNH.Tests.EntityTypes
{
    [IdentifierLengthAttributeByIndex("asdas",  14)]
    public partial class ETAttrLengthByIndexCodeList : CodeList
    {
    }

    public class ETAttrLengthByIndexCodeListMapping : IAutoMappingOverride<ETAttrLengthByIndexCodeList>
    {
        public void Override(AutoMapping<ETAttrLengthByIndexCodeList> mapping)
        {
            mapping.Id(o => o.Code).GeneratedBy.Assigned();
        }
    }
}
