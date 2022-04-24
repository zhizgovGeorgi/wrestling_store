using DAL;
using LogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLogic
{
    [TestClass]
    public class ProductTest
    {

        //[TestMethod]
        //public void TestConstructor()
        //{
           

        //    MockProductData mp = new MockProductData();
        //    ProductManager manager = new ProductManager(mp);

        

        //    Assert.AreEqual(mp, IProductDataManagement<Product>);



        //}

        [TestMethod]
        public void AddProductTest()
        {
            //arrange
            Product p = new WrestlingAccessories(1, "Nike", "Wrestling Accessories", 120, "www.facebook.bg");
            MockProductData mp = new MockProductData();
            ProductManager manager = new ProductManager(mp);
            //act
            manager.AddProduct(p);
            //assert
            Assert.AreEqual(manager.GetProducts().Count, 1);
        }

        [TestMethod]
        public void AddMultipleProductsTest()
        {
            //arrange
            Product accessories = new WrestlingAccessories(1, "Nike", "Wrestling Accessories", 120, "www.facebook.bg");
            Product shoes = new WrestlingShoes(2, "Nike Inflict", "Wrestling Shoes", 120, "www.facebook.bg", "Training");
            Product clothes = new WrestlingClothes(3, "Adidas Wreslting T-short", "Wrestling Clothes", 120, "www.facebook.bg", "cotton");
            MockProductData mp = new MockProductData();
            ProductManager manager = new ProductManager(mp);
            //act
            manager.AddProduct(accessories);
            manager.AddProduct(shoes);
            manager.AddProduct(clothes);
            //assert
            Assert.AreEqual(manager.GetProducts().Count, 3);
        }

        [TestMethod]
        public void AddTwoSameProductsTest()
        {
            //arrange
            Product accessories = new WrestlingAccessories(1, "Nike", "Wrestling Accessories", 120, "www.facebook.bg");
            Product accessories2 = new WrestlingAccessories(1, "Nike", "Wrestling Accessories", 120, "www.facebook.bg");
            MockProductData mp = new MockProductData();
            ProductManager manager = new ProductManager(mp);
            //act
            manager.AddProduct(accessories);
            manager.AddProduct(accessories2);
            //assert
            Assert.AreEqual(manager.GetProducts().Count, 1);
        }


        [TestMethod]
        public void RemoveProductTest()
        {
            //arrange
            Product accessories = new WrestlingAccessories(1, "Nike", "Wrestling Accessories", 120, "www.facebook.bg");
            Product clothes = new WrestlingClothes(3, "Adidas Wreslting T-short", "Wrestling Clothes", 120, "www.facebook.bg", "cotton");
            MockProductData mp = new MockProductData();
            ProductManager manager = new ProductManager(mp);
            //act
            manager.AddProduct(accessories);
            manager.AddProduct(clothes);
            manager.RemoveProduct(accessories);
            //assert
            Assert.AreEqual(manager.GetProducts().Count, 1);
        }

        [TestMethod]
        public void RemoveProductTest2()
        {
            //arrange
            Product accessories = new WrestlingAccessories(1, "Nike", "Wrestling Accessories", 120, "www.facebook.bg");
            MockProductData mp = new MockProductData();
            ProductManager manager = new ProductManager(mp);
            //act
            manager.AddProduct(accessories);
            manager.RemoveProduct(accessories);
            //assert
            Assert.AreEqual(manager.GetProducts().Count, 0);
        }

        [TestMethod]
        public void GetAllProducts()
        {
            //arrange
            MockProductData mp = new MockProductData();
            ProductManager manager = new ProductManager(mp);
            //act

            //assert
            Assert.AreEqual(manager.GetProducts().Count, 0);
        }
    }
}
