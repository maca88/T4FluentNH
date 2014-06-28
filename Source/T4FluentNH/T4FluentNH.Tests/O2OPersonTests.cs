using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4FluentNH.Tests.OneToOne;

namespace T4FluentNH.Tests
{
    [TestClass]
    public class O2OPersonTests
    {
        private void ResetPeople()
        {
            Ann = new O2OPerson { Name = "Ann" };
            Rocky = new O2OPerson { Name = "Rocky" };
            Patricia = new O2OPerson { Name = "Patricia" };
            Simon = new O2OPerson { Name = "Simon" };
        }

        public O2OPerson Ann { get; set; }

        public O2OPerson Patricia { get; set; }

        public O2OPerson Simon { get; set; }

        public O2OPerson Rocky { get; set; }

        [TestMethod]
        public void OneToOneRelationSelf()
        {
            //Person  1..0
            ResetPeople();

            #region Test1

            using (var session = NHConfig.OpenSession())
            {
                /* Action: 
                * A ---> R
                * 
                * Result:
                * A <--> R
                *  
                * P      S 
                */
                Ann.SetMarriedWith(Rocky);
                Assert.AreEqual(Ann.MarriedWith, Rocky);
                Assert.AreEqual(Rocky.MarriedWith, Ann);
                session.Save(Ann);
                session.Save(Rocky);
                Assert.IsFalse(Ann.IsTransient());
                Assert.IsFalse(Rocky.IsTransient());

                /* Action:
                * P ---> S
                * 
                * Result:
                * A <--> R
                *  
                * P <--> S 
                */
                Patricia.SetMarriedWith(Simon);
                Assert.AreEqual(Patricia.MarriedWith, Simon);
                Assert.AreEqual(Simon.MarriedWith, Patricia);
                session.Save(Simon);
                session.Save(Patricia);
                Assert.IsFalse(Patricia.IsTransient());
                Assert.IsFalse(Simon.IsTransient());


                /* Action: 
                * R ---> P
                * 
                * Result:
                * A    R
                *    /  
                *   /      
                * P    S 
                */
                Rocky.SetMarriedWith(Patricia);
                Assert.AreEqual(Rocky.MarriedWith, Patricia);
                Assert.AreEqual(Patricia.MarriedWith, Rocky);
                Assert.IsNull(Ann.MarriedWith);
                Assert.IsNull(Simon.MarriedWith);
                session.Save(Simon);
                session.Save(Patricia);
                session.Save(Ann);
                session.Save(Rocky);

                /* Action: 
                * A ---> S
                * 
                * Result:
                * A    R
                *   \/  
                *   /\      
                * P    S 
                */
                Ann.SetMarriedWith(Simon);
                Assert.AreEqual(Ann.MarriedWith, Simon);
                Assert.AreEqual(Simon.MarriedWith, Ann);
                session.Save(Simon);
                session.Save(Ann);
            }

            #endregion

            ResetPeople();

            #region Test2

            using (var session = NHConfig.OpenSession())
            {
                /* Action: 
                * A ---> R
                * P ---> S
                * 
                * Result:
                * A ---> R
                *         
                * P ---> S 
                */
                Ann.SetMarriedWith(Rocky);
                Assert.AreEqual(Ann.MarriedWith, Rocky);
                Assert.AreEqual(Rocky.MarriedWith, Ann);
                Patricia.SetMarriedWith(Simon);
                Assert.AreEqual(Patricia.MarriedWith, Simon);
                Assert.AreEqual(Simon.MarriedWith, Patricia);
                session.Save(Ann);
                session.Save(Simon);
                session.Save(Rocky);
                session.Save(Patricia);
            }

            #endregion
        }
    }
}
