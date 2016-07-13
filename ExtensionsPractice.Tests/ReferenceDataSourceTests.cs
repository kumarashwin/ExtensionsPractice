using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionsPractice.ReferenceDataSource;
using ExtensionsPractice.ReferenceDataSource.Implementations;
using System.Linq;

namespace ExtensionsPractice.Tests
{
    [TestClass]
    public class ReferenceDataSourceTests
    {
        [TestMethod]
        public void GetItems()
        {
            IReferenceDataSource source;

            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());

            source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());

            source = new ApiReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
        }

        [TestMethod]
        public void GetItemsByCode()
        {
            IReferenceDataSource source;

            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());

            source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());

            source = new ApiReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());
        }

        [TestMethod]
        public void GetAllItemsByCode_Array()
        {
            var sources = new IReferenceDataSource[] {
                new SqlReferenceDataSource(),
                new XmlReferenceDataSource(),
                new ApiReferenceDataSource()};

            var items = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(6, items.Count());
        }

        [TestMethod]
        public void GetAllItemsByCode_List()
        {
            var sources = new List<IReferenceDataSource> {
                new SqlReferenceDataSource(),
                new XmlReferenceDataSource(),
                new ApiReferenceDataSource()};

            var items = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(6, items.Count());
        }
    }
}
