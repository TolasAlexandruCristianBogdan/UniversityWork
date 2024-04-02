using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void ButtonBack_Click_ShouldHideFormAttendingAndShowControlForm()
        {
            
            var formAttending = new FormAttending();
            var controlForm = new FormControls();
            Program.SetFormAttend(formAttending);
            Program.SetControlForm(controlForm);
            formAttending.Hide();
            controlForm.Hide();

            
            formAttending.ButtonBack_Click(null, null);

            
            Assert.IsFalse(formAttending.Visible);
            Assert.IsTrue(controlForm.Visible);
        }

        [TestMethod]
        public void ButtonFind_Click_ShouldPopulateFieldsWithEventDetails_WhenUserIsAttendingTheEvent()
        {
            
            var formAttending = new FormAttending();
            var account = new Account();
            account.SetName("John");
            Program.SetCurrentAccount(account);
            formAttending.textBoxID.Text = "1";
            var con = new SqlConnection(Program.GetConString());
            var com1 = new SqlCommand("SELECT * FROM attending WHERE idEvent = 1 AND userName LIKE 'John'", con);
            var reader1 = new TestDataReader(new List<string> { "idEvent" }, new List<object> { 1 });
            reader1.ReadCalled += (sender, args) => com1.OnReaderRead(sender, args);
            con.OpenCalled += (sender, args) => com1.OnConnectionOpen(sender, args);
            com1.ExecuteReaderCalled += (sender, args) => args.Result = reader1;
            formAttending.textBoxName.Text = "";
            formAttending.textBoxDesc.Text = "";
            formAttending.textBoxPrice.Text = "";
            formAttending.textBoxDateStart.Text = "";
            formAttending.textBoxDateEnd.Text = "";
            formAttending.textBoxLocation.Text = "";
            formAttending.textBoxPeople.Text = "";
            formAttending.pictureBox1.Image = null;
            formAttending.textBoxCreator.Text = "";
            formAttending.textBoxDEBUG.Text = "";

           
            formAttending.ButtonFind_Click(null, null);

            Assert.AreEqual("EventName", formAttending.textBoxName.Text);
            Assert.AreEqual("EventDescription", formAttending.textBoxDesc.Text);
            Assert.AreEqual("100", formAttending.textBoxPrice.Text);
            Assert.AreEqual("2023-05-20", formAttending.textBoxDateStart.Text);
            Assert.AreEqual("2023-05-21", formAttending.textBoxDateEnd.Text);
            Assert.AreEqual("EventLocation", formAttending.textBoxLocation.Text);
            Assert.AreEqual("50", formAttending.textBoxPeople.Text);
            Assert.IsNull(formAttending.pictureBox1.Image);
            Assert.AreEqual("EventCreator", formAttending.textBoxCreator.Text);
            Assert.AreEqual("", formAttending.textBoxDEBUG.Text);
        }
    }
}
