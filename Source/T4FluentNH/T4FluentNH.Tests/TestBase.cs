using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace T4FluentNH.Tests
{
    public class TestBase
    {
        public TestBase()
        {
            Session = NHConfig.OpenSession();
        }

        protected ISession Session { get; set; }
    }
}
