


namespace LoginDemo.Test
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void Login_Id_Success()
        {
            var control = new Control();

            bool issuccess = control.ID("rorze");

            Assert.IsTrue(issuccess);
        }

        [TestMethod]
        public void Login_Pw_Success()
        {
            var control = new Control();

            bool issuccess = control.PW("123");

            Assert.IsTrue(issuccess);
        } 
    }
}
