using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalogApplication;
using System;
using System.Collections.Generic;

namespace ProductCatalogUnitTest
{
    [TestClass]
    public class CatalogClassUnitTest
    {
        [TestMethod]
        public void TestMethodGetAllProducts()
        {
            // given
            Product product1 = new Product
            {
                Name = "A Song of Ice and Fire",
                Price = 80,
                Department = Department.Books
            };

            Product product2 = new Product
            {
                Name = "Harry Potter",
                Price = 50,
                Department = Department.Books
            };

            Product product3 = new Product
            {
                Name = "Pillow",
                Price = 30,
                Department = Department.Home
            };

            Product product4 = new Product
            {
                Name = "Pillow",
                Price = 80,
                Department = Department.Home
            };

            Catalog testCatalog = new Catalog();

            // when
            testCatalog.Add(product1);
            testCatalog.Add(product2);
            testCatalog.Add(product3);
            testCatalog.Add(product4);

            List<Product> expectedCatalog = new List<Product>
            {
                product1,
                product2,
                product3,
                product4
            };          

            List<Product> actualCatalog = (List<Product>)testCatalog.GetAllProducts();
            
            // then
            for (int i = 0; i < actualCatalog.Count; i++)
            {
                Assert.AreEqual(expectedCatalog[i], actualCatalog[i]);
            }           
        }

        [TestMethod]
        public void TestMethodGetProducts()
        {
            // given
            Product product1 = new Product
            {
                Name = "A Song of Ice and Fire",
                Price = 80,
                Department = Department.Books
            };

            Product product2 = new Product
            {
                Name = "Harry Potter",
                Price = 50,
                Department = Department.Books
            };

            Product product3 = new Product
            {
                Name = "Pillow",
                Price = 30,
                Department = Department.Home
            };

            Product product4 = new Product
            {
                Name = "Pillow",
                Price = 80,
                Department = Department.Home
            };

            Catalog testCatalog = new Catalog();

            // when
            testCatalog.Add(product1);
            testCatalog.Add(product2);
            testCatalog.Add(product3);
            testCatalog.Add(product4);

            List<Product> expectedFilteredCatalog = new List<Product>
            {
                product3,
                product4
            };

            List<Product> actualFilteredCatalog = (List<Product>)testCatalog.GetProducts("pillow");

            // then
            for (int i = 0; i < actualFilteredCatalog.Count; i++)
            {
                Assert.AreEqual(expectedFilteredCatalog[i], actualFilteredCatalog[i]);
            }
        }
    }
}
