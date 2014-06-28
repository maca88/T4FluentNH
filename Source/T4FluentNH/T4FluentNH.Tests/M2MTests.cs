using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4FluentNH.Tests.ManyToMany;

namespace T4FluentNH.Tests
{
    [TestClass]
    public class M2MTests
    {
        public M2MTests()
        {
            Ann = new M2MUser {Name = "Ann"};
            Rocky = new M2MUser {Name = "Rocky"};
            Role1 = new TestM2MRole();
            Role2 = new TestM2MRole();
        }

        public M2MUser Ann { get; set; }

        public M2MUser Rocky { get; set; }

        public TestM2MRole Role1 { get; set; }

        public TestM2MRole Role2 { get; set; }

        [TestMethod]
        public void Test()
        {
            using (var session = NHConfig.OpenSession())
            {
                Ann.AddRole(Role1);
                Assert.IsTrue(Ann.Roles.Contains(Role1));
                Assert.IsTrue(Role1.Users.Contains(Ann));

                Rocky.AddRole(Role2);
                Assert.IsTrue(Rocky.Roles.Contains(Role2));
                Assert.IsTrue(Role2.Users.Contains(Rocky));

                session.Save(Ann);
                session.Save(Rocky);

                Ann.AddRole(Role2);
                Assert.IsTrue(Ann.Roles.Contains(Role2));
                Assert.IsTrue(Role2.Users.Contains(Ann));

                session.Save(Ann);

                Rocky.RemoveRole(Role2);
                Assert.IsFalse(Rocky.Roles.Contains(Role2));
                Assert.IsFalse(Role2.Users.Contains(Rocky));
            }
        }
    }
}
