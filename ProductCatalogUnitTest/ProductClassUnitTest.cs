using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalogApplication;
using System;

namespace ProductCatalogUnitTest
{
    [TestClass]
    public class ProductClassUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // given
            string productName = "Bed";
            decimal productPrice = 1000;
            Department productDepartment = Department.Home;

            // when
            Product testProduct = new Product
            {
                Name = productName,
                Price = productPrice,
                Department = productDepartment
            };

            // then
            Assert.AreEqual(productName, testProduct.Name);
            Assert.AreEqual(productPrice, testProduct.Price);
            Assert.AreEqual(productDepartment, testProduct.Department);
        }
    }
}
