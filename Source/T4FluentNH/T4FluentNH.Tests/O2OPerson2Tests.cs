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
    public class O2OPerson2Tests : TestBase
    {
        public O2OPerson2Tests()
        {
            Ann = new O2OPerson2 {Name = "Ann"};
            Rocky = new O2OPerson2 {Name = "Rocky"};
            IdentityCard1 = new O2OIdentityCard2();
            IdentityCard2 = new O2OIdentityCard2();
        }

        public O2OPerson2 Ann { get; set; }

        public O2OPerson2 Rocky { get; set; }

        public O2OIdentityCard2 IdentityCard1 { get; set; }

        public O2OIdentityCard2 IdentityCard2 { get; set; }



        [TestMethod]
        public void Test1()
        {
            using (var session = NHConfig.OpenSession())
            {
                /* Action: 
                 * A ---> IC1
                 * 
                 * Result:
                 * A <--> IC1
                 *  
                 * R      IC2
                 */
                Ann.SetIdentityCard(IdentityCard1);
                Assert.AreEqual(Ann.IdentityCard, IdentityCard1);
                Assert.AreEqual(Ann, IdentityCard1.Owner);
                session.Save(Ann);

                /* Action: 
                 * R ---> IC2
                 * 
                 * Result:
                 * A <--> IC1
                 *  
                 * R <--> IC2
                 */
                Rocky.SetIdentityCard(IdentityCard2);
                Assert.AreEqual(Rocky.IdentityCard, IdentityCard2);
                Assert.AreEqual(Rocky, IdentityCard2.Owner);
                session.Save(Rocky);

                /* Action: 
                 * A ---> IC2
                 * 
                 * Result:
                 * A   IC1
                 *   \
                 *    \
                 * R   IC2
                 */
                Ann.SetIdentityCard(IdentityCard2);
                Assert.AreEqual(Ann.IdentityCard, IdentityCard2);
                Assert.AreEqual(Ann, IdentityCard2.Owner);
                Assert.IsNull(Rocky.IdentityCard);
                Assert.IsNull(IdentityCard1.Owner);
                session.Save(Rocky);
                session.Save(IdentityCard1);
                session.Save(Ann);

                /* Action: 
                 * A --X IC2
                 * 
                 * Result:
                 * A   IC1
                 *   
                 *    
                 * R   IC2
                 */
                Ann.UnsetIdentityCard();
                Assert.IsNull(Ann.IdentityCard);
                Assert.IsNull(IdentityCard2.Owner);
                session.Save(IdentityCard2); //this will cause multiple nulls on a nullable unique column
                session.Save(Ann);
            }

        }

        [TestMethod]
        public void set_one2one_with_null_should_unset()
        {
            Ann.SetIdentityCard(null);

            Ann.SetIdentityCard(IdentityCard2);
            Assert.AreEqual(IdentityCard2, Ann.IdentityCard);
            Assert.AreEqual(IdentityCard2.Owner, Ann);
            Ann.SetIdentityCard(null);
            Assert.IsNull(Ann.IdentityCard);
            Assert.IsNull(IdentityCard2.Owner);
        }

        [TestMethod]
        public async Task set_one2one_async_with_null_should_unset()
        {
            await Ann.SetIdentityCardAsync(null);
            await Ann.SetIdentityCardAsync(IdentityCard2);
            Assert.AreEqual(IdentityCard2, Ann.IdentityCard);
            Assert.AreEqual(IdentityCard2.Owner, Ann);
            await Ann.SetIdentityCardAsync(null);
            Assert.IsNull(Ann.IdentityCard);
            Assert.IsNull(IdentityCard2.Owner);
        }
    }
}
