using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace T4FluentNH.Tests.EntityTypes
{
    [IdentifierLengthAttributeByProperty(Test="asdas",   Length =   11)]
    public partial class ETAttrLengthByPropertyCodeList : CodeList
    {
    }

    public class ETAttrLengthByPropertyCodeListMapping : IAutoMappingOverride<ETAttrLengthByPropertyCodeList>
    {
        public void Override(AutoMapping<ETAttrLengthByPropertyCodeList> mapping)
        {
            mapping.Id(o => o.Code).GeneratedBy.Assigned();
        }
    }
}
