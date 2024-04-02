using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void ButtonExit_Click_ShouldExitTheApplication()
        {
            var formAdv = new FormAdv();
            bool applicationExited = false;
            System.Windows.Forms.Application.Exit += (sender, args) => { applicationExited = true; };

           
            formAdv.ButtonExit_Click(null, null);

            Assert.IsTrue(applicationExited);
        }

        [TestMethod]
        public void ButtonBack_Click_ShouldHideFormAdvAndShowControlForm()
        {
            var formAdv = new FormAdv();
            var controlForm = new FormControls();
            Program.SetFormAdvertisement(formAdv);
            Program.SetControlForm(controlForm);
            formAdv.Hide();
            controlForm.Hide();

            
            formAdv.ButtonBack_Click(null, null);

            
            Assert.IsFalse(formAdv.Visible);
            Assert.IsTrue(controlForm.Visible);
        }

        [TestMethod]
        public void ButtonClrImg_Click_ShouldClearPictureBoxImageAndPhotoIdTextBox()
        {
          
            var formAdv = new FormAdv();
            formAdv.pictureBox1.Image = new Bitmap(100, 100);
            formAdv.textBoxPhotoId.Text = "image.png";

            
            formAdv.ButtonClrImg_Click(null, null);

            Assert.IsNull(formAdv.pictureBox1.Image);
            Assert.AreEqual("", formAdv.textBoxPhotoId.Text);
        }
    }
}
