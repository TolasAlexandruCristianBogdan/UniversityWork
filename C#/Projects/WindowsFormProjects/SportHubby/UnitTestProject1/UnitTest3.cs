using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        private FormMainMenu form;

        [TestInitialize]
        public void SetUp()
        {
            form = new FormMainMenu();
        }

        [TestCleanup]
        public void TearDown()
        {
            form.Dispose();
        }

        [TestMethod]
        public void ShowProducts_WithValidInput_ShouldDisplayProducts()
        {
            
            TextBox textBoxName = form.Controls.Find("textBoxName", true)[0] as TextBox;
            TextBox textBoxLocation = form.Controls.Find("textBoxLocation", true)[0] as TextBox;
            TextBox textBoxPriceMin = form.Controls.Find("textBoxPriceMin", true)[0] as TextBox;
            TextBox textBoxPriceMax = form.Controls.Find("textBoxPriceMax", true)[0] as TextBox;

            textBoxName.Text = "Football";
            textBoxLocation.Text = "Stadium";
            textBoxPriceMin.Text = "50";
            textBoxPriceMax.Text = "100";

            
            form.ShowProducts();

            
            Panel panel1 = form.Controls.Find("panel1", true)[0] as Panel;
            Assert.IsTrue(panel1.Controls.Count > 0);
        }

        [TestMethod]
        public void Clear_ShouldClearTextBoxes()
        {
            
            TextBox textBoxName = form.Controls.Find("textBoxName", true)[0] as TextBox;
            TextBox textBoxLocation = form.Controls.Find("textBoxLocation", true)[0] as TextBox;
            TextBox textBoxPriceMin = form.Controls.Find("textBoxPriceMin", true)[0] as TextBox;
            TextBox textBoxPriceMax = form.Controls.Find("textBoxPriceMax", true)[0] as TextBox;

            textBoxName.Text = "Football";
            textBoxLocation.Text = "Stadium";
            textBoxPriceMin.Text = "50";
            textBoxPriceMax.Text = "100";

            
            form.Clear();

            Assert.AreEqual("", textBoxName.Text);
            Assert.AreEqual("", textBoxLocation.Text);
            Assert.AreEqual("", textBoxPriceMin.Text);
            Assert.AreEqual("", textBoxPriceMax.Text);
        }

        [TestMethod]
        public void ButtonExit_Click_ShouldExitApplication()
        {
            
            bool applicationExited = false;
            Application.ApplicationExit += (s, e) => applicationExited = true;
            Button buttonExit = form.Controls.Find("buttonExit", true)[0] as Button;

            
            buttonExit.PerformClick();

           
            Assert.IsTrue(applicationExited);
        }
    }
}
