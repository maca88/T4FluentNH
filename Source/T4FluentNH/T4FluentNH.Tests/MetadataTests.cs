using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4FluentNH.Tests.ManyToOne;
using T4FluentNH.Tests.OneToMany;

namespace T4FluentNH.Tests
{
    [TestClass]
    public class MetadataTests
    {

        #region OneToMany

        [TestMethod]
        public void TestOneToManyBidirectionalRelation()
        {
            Assert.IsTrue(O2MPerson.RelationsMetadata.ContainsKey("Cars"), "RelationsMetadata for property Cars is not defined");
            var carRel = O2MPerson.RelationsMetadata["Cars"];
            var oneToMany = carRel as OneToManyRelationMetadata;
            Assert.IsTrue(oneToMany != null, "Relation for Cars is not of type OneToManyRelationMetadata");

            Assert.AreEqual(AssociationType.Bidirectional, carRel.AssociationType);
            Assert.AreEqual("_cars", carRel.Field.Name);
            Assert.AreEqual("car", carRel.ParameterName);
            Assert.AreEqual("Cars", carRel.Property.Name);
            Assert.AreEqual("Id", carRel.RelatedModelIdProperty.Name);
            Assert.AreEqual("Owner", carRel.RelatedModelProperty.Name);
            
            Assert.IsNotNull(oneToMany.AddMethod);
            Assert.AreEqual("AddCar", oneToMany.AddMethod.Name);

            Assert.IsNotNull(oneToMany.RemoveMethod);
            Assert.AreEqual("RemoveCar", oneToMany.RemoveMethod.Name);
        }

        [TestMethod]
        public void TestOneToManyUnidirectionalRelation()
        {
            Assert.IsTrue(O2MPerson2.RelationsMetadata.ContainsKey("Cars"), "RelationsMetadata for property Cars is not defined");
            var carRel = O2MPerson2.RelationsMetadata["Cars"];
            var oneToMany = carRel as OneToManyRelationMetadata;
            Assert.IsTrue(oneToMany != null, "Relation for Cars is not of type OneToManyRelationMetadata");

            Assert.AreEqual(AssociationType.Unidirectional, carRel.AssociationType);
            Assert.AreEqual("_cars", carRel.Field.Name);
            Assert.AreEqual("car", carRel.ParameterName);
            Assert.AreEqual("Cars", carRel.Property.Name);
            Assert.AreEqual("Id", carRel.RelatedModelIdProperty.Name);
            Assert.IsNull(carRel.RelatedModelProperty);

            Assert.IsNull(oneToMany.AddMethod);
            Assert.IsNull(oneToMany.RemoveMethod);
        }

        #endregion

        #region ManyToOne

        [TestMethod]
        public void TestManyToOneBidirectionalRelation()
        {
            Assert.IsTrue(O2MCar.RelationsMetadata.ContainsKey("Owner"), "RelationsMetadata for property Owner is not defined");
            var rel = O2MCar.RelationsMetadata["Owner"];
            var manyToOne = rel as ManyToOneRelationMetadata;
            Assert.IsTrue(manyToOne != null, "Relation for Owner is not of type ManyToOneRelationMetadata");

            Assert.AreEqual(AssociationType.Bidirectional, rel.AssociationType);
            Assert.AreEqual("_owner", rel.Field.Name);
            Assert.AreEqual("owner", rel.ParameterName);
            Assert.AreEqual("Owner", rel.Property.Name);
            Assert.AreEqual("Id", rel.RelatedModelIdProperty.Name);
            Assert.AreEqual("Cars", rel.RelatedModelProperty.Name);

            Assert.IsNotNull(manyToOne.SetMethod);
            Assert.AreEqual("SetOwner", manyToOne.SetMethod.Name);

            Assert.IsNotNull(manyToOne.UnsetMethod);
            Assert.AreEqual("UnsetOwner", manyToOne.UnsetMethod.Name);

            Assert.AreEqual("OwnerId", manyToOne.SyntheticProperty.Name);
            Assert.AreEqual("_ownerId", manyToOne.SyntheticField.Name);
            Assert.IsNull(manyToOne.SyntheticPropertyMaxLength);
            Assert.IsTrue(manyToOne.IsSyntheticPropertyTypeRequired);
            Assert.AreEqual("RemoveCar", manyToOne.RelatedModelRemoveMethod.Name);
        }

        [TestMethod]
        public void TestManyToOneUnidirectionalRelation()
        {
            Assert.IsTrue(M2OPerson.RelationsMetadata.ContainsKey("Car"), "RelationsMetadata for property Car is not defined");
            var rel = M2OPerson.RelationsMetadata["Car"];
            var manyToOne = rel as ManyToOneRelationMetadata;
            Assert.IsTrue(manyToOne != null, "Relation for Car is not of type ManyToOneRelationMetadata");

            Assert.AreEqual(AssociationType.Unidirectional, rel.AssociationType);
            Assert.AreEqual("_car", rel.Field.Name);
            Assert.AreEqual("car", rel.ParameterName);
            Assert.AreEqual("Car", rel.Property.Name);
            Assert.AreEqual("Id", rel.RelatedModelIdProperty.Name);
            Assert.IsNull(rel.RelatedModelProperty);

            Assert.IsNull(manyToOne.SetMethod);
            Assert.IsNull(manyToOne.UnsetMethod);

            Assert.AreEqual("CarId", manyToOne.SyntheticProperty.Name);
            Assert.AreEqual("_carId", manyToOne.SyntheticField.Name);
            Assert.IsNull(manyToOne.SyntheticPropertyMaxLength);
            Assert.IsFalse(manyToOne.IsSyntheticPropertyTypeRequired);
            Assert.IsNull( manyToOne.RelatedModelRemoveMethod);
        }

        #endregion
    }
}
