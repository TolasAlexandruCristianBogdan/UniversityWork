using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ButtonCreateAccountClick_ValidInput_ShouldInsertUserIntoDatabaseAndHideSignUpForm()
        {
            var formSignUp = new FormSignUp();
            formSignUp.textBoxUser.Text = "testuser";
            formSignUp.textBoxPass.Text = "testpassword";
            formSignUp.textBoxMail.Text = "test@example.com";

            // Simulează existența utilizatorului în baza de date
            // Mock object pentru conexiunea la baza de date și citirea datelor
            var mockReader = new FakeDataReader();
            var mockCommand = new FakeSqlCommand("select * from utilizator where username=@name or email=@mail", mockReader);
            var mockConnection = new FakeSqlConnection();
            mockConnection.AddCommand(mockCommand);
            Program.SetSqlConnection(mockConnection);

            formSignUp.ButtonCreateAccount_Click(null, null);

            
            Assert.IsTrue(formSignUp.textBoxError.Text == "");
            Assert.IsFalse(formSignUp.Visible);

            // Verifică inserția utilizatorului în baza de date
            var insertedUserCommand = mockConnection.Commands.FirstOrDefault(c => c.CommandText.Contains("insert into utilizator"));
            Assert.IsNotNull(insertedUserCommand);
            Assert.AreEqual("testuser", insertedUserCommand.Parameters["@nameUt"].Value);
            Assert.AreEqual("testpassword", insertedUserCommand.Parameters["@pass"].Value);
            Assert.AreEqual("test@example.com", insertedUserCommand.Parameters["@email"].Value);
        }
    }
}
