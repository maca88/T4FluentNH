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
    public class O2OPerson3Tests
    {
        public O2OPerson3Tests()
        {
            Ann = new O2OPerson3 {Name = "Ann"};
            Rocky = new O2OPerson3 {Name = "Rocky"};
            IdentityCard1 = new O2OIdentityCard3();
            IdentityCard2 = new O2OIdentityCard3();
        }

        public O2OPerson3 Ann { get; set; }

        public O2OPerson3 Rocky { get; set; }

        public O2OIdentityCard3 IdentityCard1 { get; set; }

        public O2OIdentityCard3 IdentityCard2 { get; set; }


        [TestMethod] //Person  1..0 ------ 1 DrivingLicence
        public void Test1()
        {
            using (var session = NHConfig.OpenSession())
            {
                Ann.SetIdentityCard(IdentityCard1);
                session.Save(Ann);

                Rocky.SetIdentityCard(IdentityCard2);
                session.Save(Rocky);

                Ann.SetIdentityCard(IdentityCard2);
                Rocky.SetIdentityCard(IdentityCard1);

                session.Save(Ann);
                session.Save(Rocky);
            }
        }
    }
}
