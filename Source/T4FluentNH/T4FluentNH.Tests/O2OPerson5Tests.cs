using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4FluentNH.Tests.OneToOne;

namespace T4FluentNH.Tests
{
    [TestClass]
    public class O2OPerson5Tests
    {
        public O2OPerson5Tests()
        {
            Ann = new O2OPerson5 {Name = "Ann"};
            Rocky = new O2OPerson5 {Name = "Rocky"};
            IdentityCard1 = new O2OIdentityCard5();
            IdentityCard2 = new O2OIdentityCard5();
        }

        public O2OPerson5 Ann { get; set; }

        public O2OPerson5 Rocky { get; set; }

        public O2OIdentityCard5 IdentityCard1 { get; set; }

        public O2OIdentityCard5 IdentityCard2 { get; set; }

        [TestMethod]
        public void Test()
        {
            using (var session = NHConfig.OpenSession())
            {
                Ann.SetIdentityCard(IdentityCard1);
                Rocky.SetIdentityCard(IdentityCard2);
                session.Save(Ann);
                session.Save(Rocky);

                Assert.IsFalse(IdentityCard1.IsTransient());
                Assert.IsFalse(IdentityCard2.IsTransient());
                Assert.IsFalse(Ann.IsTransient());
                Assert.IsFalse(Rocky.IsTransient());
            }
        }
    }
}
