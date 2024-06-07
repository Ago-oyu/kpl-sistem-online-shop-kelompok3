using Yoga;
namespace YogaTesting
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestUserCount1()
        {
            int expected = 0;
            Assert.AreEqual(expected, User.UserCount);
        }

        [TestMethod]
        public void TestUserCount2()
        {
            int expected = 2;
            User u1 = new User("nama1", "email1", "password1");
            User u2 = new User("nama2", "email2", "password2");

            Assert.AreEqual(expected, User.UserCount);
        }
    }
}