using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        public FormLogIn formLogIn;

        [TestInitialize]
        public void Setup()
        {
            formLogIn = new FormLogIn();
        }

        [TestCleanup]
        public void TearDown()
        {
            formLogIn.Dispose();
        }

        [TestMethod]
        public void ButtonSignUp_Click_ShouldShowSignUpFormAndHideLogInForm()
        {
            
            FormSignUp signUpForm = Program.GetSignUpForm();
            signUpForm.Hide();

            
            formLogIn.ButtonSignUp_Click();

            
            Assert.IsTrue(signUpForm.Visible);
            Assert.IsFalse(formLogIn.Visible);
        }

        [TestMethod]
        public void ButtonExit_Click_ShouldExitApplication()
        {
            
            bool applicationExitCalled = false;

            void ApplicationExitHandler(object sender, EventArgs e)
            {
                applicationExitCalled = true;
            }

            System.Windows.Forms.Application.ApplicationExit += ApplicationExitHandler;

            
            formLogIn.ButtonExit_Click(null, EventArgs.Empty);

            
            Assert.IsTrue(applicationExitCalled);

            System.Windows.Forms.Application.ApplicationExit -= ApplicationExitHandler;
        }
    }
}
