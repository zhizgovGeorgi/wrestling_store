using DAL;
using LogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modules;

namespace TestClassLogic
{
    [TestClass]
    public class OrderTest
    {

        [TestMethod]
        public void AddOrderTest()
        {
            //arrange
            User u1 = new User(1, "Georgi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
            Product accessories = new WrestlingAccessories(5, "NikeY", "Wrestling sHOES", 120, "www.facebook.bg");
            Order o = new Order(3, u1, accessories, "S", 3, Status.Pending);
            MockOrderData mo = new MockOrderData();
            OrderManager manager = new OrderManager(mo);
            //act
            manager.AddOrder(o);
            //assert
            Assert.AreEqual(manager.GetCartItems().Count, 1);
        }

        [TestMethod]
        public void AddTwoOrdersTest()
        {
            //arrange
            User u1 = new User(1, "Georgi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
            Product shoes = new WrestlingAccessories(5, "NikeY", "Wrestling sHOES", 120, "www.facebook.bg");
            Product accessories2 = new WrestlingAccessories(6, "Nik", "Wrestling accessories", 120, "www.facebook.bg");
            Order o = new Order(3, u1, accessories2, "S", 3, Status.Pending);
            Order o2 = new Order(4, u1, shoes, "42", 3, Status.Pending);
            MockOrderData mo = new MockOrderData();
            OrderManager manager = new OrderManager(mo);
            //act
            manager.AddOrder(o);
            manager.AddOrder(o2);
            //assert
            Assert.AreEqual(manager.GetCartItems().Count, 2);
        }

        [TestMethod]
        public void RemoveOrderTest()
        {
            //arrange
            User u1 = new User(1, "Georgi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
            Product shoes = new WrestlingAccessories(5, "NikeY", "Wrestling sHOES", 120, "www.facebook.bg");
            Product accessories = new WrestlingAccessories(1, "Nike", "Wrestling Accessories", 120, "www.facebook.bg");
            Order o1 = new Order(4, u1, shoes, "42", 3, Status.Pending);
            Order o2 = new Order(5, u1, accessories, "", 3, Status.Pending);
            MockOrderData mo = new MockOrderData();
            OrderManager manager = new OrderManager(mo);
            //act
            manager.AddOrder(o1);
            manager.AddOrder(o2);
            manager.RemoveCartItem(o2.OrderId);
            //assert
            Assert.AreEqual(manager.GetCartItems().Count, 1);
        }

        [TestMethod]
        public void ShowOrderItemsPerPersonTest()
        {
            //arrange

            User u1 = new User(1, "Georgi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
            User u2 = new User(2, "Ramdi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
            Product accessories = new WrestlingAccessories(1, "Nike", "Wrestling Accessories", 120, "www.facebook.bg");
            Order o = new Order(1, u1, accessories, "S", 3, Status.Pending);
            Order o2 = new Order(1, u2, accessories, "S", 3, Status.Pending);
            MockOrderData mo = new MockOrderData();
            OrderManager manager = new OrderManager(mo);
            //act
            manager.AddOrder(o);
            manager.AddOrder(o2);

            //assert
            Assert.AreEqual(manager.ShowOrderItems(u1).Count,1 );
        }

        //[TestMethod]
        //public void GetOrderTest()
        //{
        //    //arrange

        //    User u1 = new User(1, "Georgi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
        //    User u2 = new User(2, "Ramdi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
        //    Product accessories = new WrestlingAccessories(1, "Nike", "Wrestling Accessories", 120, "www.facebook.bg");
        //    Order o = new Order(1, u1, accessories, "S", 3, Status.Pending);
        //    Order o2 = new Order(1, u2, accessories, "S", 3, Status.Pending);
        //    MockOrderData mo = new MockOrderData();
        //    OrderManager manager = new OrderManager(mo);
        //    //act
        //    manager.AddOrder(o);
        //    manager.AddOrder(o2);

        //    //assert
        //    Assert.AreEqual(manager.GetCartItems().Count, 2);
        //}


    }
}
