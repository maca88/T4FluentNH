using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4FluentNH.Tests.OneToMany;
using T4FluentNH.Tests.OneToOne;

namespace T4FluentNH.Tests
{
    [TestClass]
    public class SyntheticPropertyTests
    {
        [TestMethod]
        public void TestOneToOne()
        {
            var ann = new O2OPerson { Name = "Ann" };
            var rocky = new O2OPerson { Name = "Rocky" };
            var patricia = new O2OPerson { Name = "Patricia" };
            using (var session = NHConfig.OpenSession())
            {
                ann.SetMarriedWith(rocky);
                session.Save(rocky);
                session.Save(ann);
                session.Flush();

                Assert.AreEqual(rocky.Id, ann.MarriedWithId);
                Assert.AreEqual(ann.Id, rocky.MarriedWithId);

                patricia.SetMarriedWith(rocky);
                Assert.AreEqual(null, ann.MarriedWithId);
                Assert.AreEqual(rocky.Id, patricia.MarriedWithId);
                Assert.AreEqual(patricia.Id, rocky.MarriedWithId);
                session.Save(patricia);
            }

            using (var session = NHConfig.OpenSession())
            {
                patricia = session.Get<O2OPerson>(patricia.Id);
                Assert.AreEqual(rocky.Id, patricia.MarriedWithId);
                rocky = session.Get<O2OPerson>(rocky.Id);
                patricia.UnsetMarriedWith();
                Assert.AreEqual(null, patricia.MarriedWithId);
                Assert.AreEqual(null, rocky.MarriedWithId);


                patricia.SetMarriedWith(rocky);
                Assert.AreEqual(rocky.Id, patricia.MarriedWithId);
                Assert.AreEqual(patricia.Id, rocky.MarriedWithId);

                patricia.MarriedWithId = null;
                rocky.MarriedWithId = null;
                Assert.AreEqual(null, patricia.MarriedWithId);
                Assert.AreEqual(null, rocky.MarriedWithId);

                patricia.UnsetMarriedWith();
                patricia.SetMarriedWith(rocky);
                Assert.AreEqual(rocky.Id, patricia.MarriedWithId);
                Assert.AreEqual(patricia.Id, rocky.MarriedWithId);

            }
        }

        [TestMethod]
        public void TestOneToManyAndManyToOne()
        {
            var ann = new O2MPerson { Name = "Ann" };
            var bmw = new O2MCar { Model = "BMW" };
            var audi = new O2MCar { Model = "Audi" };
            using (var session = NHConfig.OpenSession())
            {
                ann.AddCar(bmw);
                session.Save(ann);
                session.Save(bmw);
                session.Save(audi);
                session.Flush();

                Assert.AreEqual(ann.Id, bmw.OwnerId);
                Assert.AreEqual(0, audi.OwnerId);

                ann.RemoveCar(bmw);
                Assert.AreEqual(0, bmw.OwnerId);

                audi.SetOwner(ann);
                Assert.AreEqual(ann.Id, audi.OwnerId);

                audi.UnsetOwner();
                Assert.AreEqual(0, audi.OwnerId);

                bmw.SetOwner(ann);
                Assert.AreEqual(ann.Id, bmw.OwnerId);
                audi.SetOwner(ann);
                Assert.AreEqual(ann.Id, audi.OwnerId);
                session.Flush();
            }

            using (var session = NHConfig.OpenSession())
            {
                ann = session.Get<O2MPerson>(ann.Id);
                bmw = session.Get<O2MCar>(bmw.Id);
                audi = session.Get<O2MCar>(audi.Id);
                Assert.AreEqual(ann.Id, bmw.OwnerId);
                Assert.AreEqual(ann.Id, audi.OwnerId);

                bmw.UnsetOwner();
                Assert.AreEqual(0, bmw.OwnerId);

                ann.RemoveCar(audi);
                Assert.AreEqual(0, audi.OwnerId);

                //Add relation again as the Owner is required
                ann.AddCar(bmw);
                ann.AddCar(audi);
                Assert.AreEqual(ann.Id, bmw.OwnerId);
                Assert.AreEqual(ann.Id, audi.OwnerId);
                session.Flush();
            }

            bmw.Owner = null;
            Assert.AreEqual(0, bmw.OwnerId);
        }
    }
}
