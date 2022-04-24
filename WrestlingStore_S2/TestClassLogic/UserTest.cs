using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicLayer;
using Modules;
using DAL;

namespace TestClassLogic
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void AddUserTest()
        {
            //arrange
            User u = new User(1, "Georgi","Zhizgov","g.antoanov@abv.bg",  "street", "1234", "Administrator");
            MockUserData mu = new MockUserData();
            UserManager manager = new UserManager(mu);
            //act
            manager.AddUser(u);
            //assert
            Assert.AreEqual(manager.GetAllUsers().Count, 1);
        }

        [TestMethod]
        public void AddTwoUsersTest()
        {
            //arrange
            User u1 = new User(1, "Georgi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
            User u2 = new User(2, "Ivan", "Ivanov", "ivan@abv.bg", "prostor", "1234", "User");
            MockUserData mu = new MockUserData();
            UserManager manager = new UserManager(mu);
            //act
            manager.AddUser(u1);
            manager.AddUser(u2);
            //assert
            Assert.AreEqual(manager.GetAllUsers().Count, 2);
        }

        [TestMethod]
        public void AddTwoSameUsersTest()
        {
            //arrange
            User u1 = new User(1, "Georgi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
            User u2 = new User(1, "Georgi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
            MockUserData mu = new MockUserData();
            UserManager manager = new UserManager(mu);
            //act
            manager.AddUser(u1);
            manager.AddUser(u2);
            //assert
            Assert.AreEqual(manager.GetAllUsers().Count, 1);
        }

        [TestMethod]
        public void RemoveUser()
        {
            //arrange
            User u = new User(1, "Georgi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
            MockUserData mu = new MockUserData();
            UserManager manager = new UserManager(mu);
            //act
            manager.AddUser(u);
            manager.RemoveUser(u);
            //assert
            Assert.AreEqual(manager.GetAllUsers().Count, 0);
        }



        [TestMethod]
        public void ReadUserTest()
        {
            //arrange
            User u = new User(1, "Georgi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
            MockUserData mu = new MockUserData();
            UserManager manager = new UserManager(mu);
            //act
            manager.AddUser(u);
            manager.ReadUser(u.Email, u.Password);
            //assert
            Assert.AreEqual(manager.ReadUser(u.Email, u.Password), u);
        }

        [TestMethod]
        public void ReadUserTest2()
        {
            //arrange
            User u = new User(1, "Georgi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
            MockUserData mu = new MockUserData();
            UserManager manager = new UserManager(mu);
            //act
            manager.ReadUser(u.Email, u.Password);
            //assert
            Assert.AreEqual(manager.ReadUser(u.Email, u.Password), null);
        }

        [TestMethod]
        public void GetUser()
        {
            //arrange
            User u = new User(1, "Georgi", "Zhizgov", "g.antoanov@abv.bg", "street", "1234", "Administrator");
            MockUserData mu = new MockUserData();
            UserManager manager = new UserManager(mu);
            //act
            manager.AddUser(u);
            manager.GetUser(u.Email);
            //assert
            Assert.AreEqual(manager.GetUser(u.Email), u);
        }

        [TestMethod]
        public void GetAllUsersTest()
        {
            //arrange

            MockUserData mu = new MockUserData();
            UserManager manager = new UserManager(mu);

            //act
            manager.GetAllUsers();
            //assert
            Assert.AreEqual(manager.GetAllUsers().Count, 0);
        }


    }
}