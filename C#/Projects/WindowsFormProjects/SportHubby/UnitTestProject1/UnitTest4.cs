using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class FormEventPageTests
    {
        private FormEventPage formEventPage;

        [TestInitialize]
        public void Setup()
        {
            formEventPage = new FormEventPage();
        }

        [TestMethod]
        public void Display_WithValidParameters_SetsCorrectValues()
        {
            
            int id = 1;
            string name = "Event 1";
            string desc = "Event 1 description";
            double price = 10.0;
            string dateS = "2023-01-01 10:00:00";
            string dateE = "2023-01-01 12:00:00";
            string location = "Location 1";
            int maxPeople = 100;
            int taken = 50;
            byte[] img = null;
            string cr = "Creator";

            
            formEventPage.Display(id, name, desc, price, dateS, dateE, location, maxPeople, taken, img, cr);

            Assert.AreEqual(id.ToString(), formEventPage.textBoxId.Text);
            Assert.AreEqual(name, formEventPage.textBoxName.Text);
            Assert.AreEqual(desc, formEventPage.textBoxDesc.Text);
            Assert.AreEqual(price.ToString(), formEventPage.textBoxPrice.Text);
            Assert.AreEqual(dateS, formEventPage.textBoxDateStart.Text);
            Assert.AreEqual(dateE, formEventPage.textBoxDateEnd.Text);
            Assert.AreEqual(location, formEventPage.textBoxLocation.Text);
            Assert.AreEqual((maxPeople - taken).ToString(), formEventPage.textBoxAvailablePlaces.Text);
            Assert.AreEqual(maxPeople.ToString(), formEventPage.textBoxTotalPlaces.Text);
            Assert.AreEqual(cr, formEventPage.textBoxCreator.Text);
        }
    }
}
