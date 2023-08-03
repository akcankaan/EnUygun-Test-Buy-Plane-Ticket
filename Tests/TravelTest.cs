using Allure.Commons;
using Allure.Net.Commons;
using case1_hepsiburada.Utils;
using enUygunCase.Actuals;
using enUygunCase.Pages;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace enUygunCase.Tests
{
    [TestFixture(Author = "KaanAKCAN", Description = "EnUygunTests")]
    [AllureNUnit]
    [AllureLink("https://github.com/unickq/allure-nunit")]
    public class TravelTest
    {
        private GeneralMethods _GM;
        private TravelPage _do;
        private TravelActuals _actuals;

        public TravelTest()
        {
            _GM = new GeneralMethods();
            _do = new TravelPage();
            _actuals = new TravelActuals();
        }

        [OneTimeSetUp]
        public void OTSUP() { }
        
        [SetUp]
        public void Setup() { }
        #region
        public static string fromWhere = "İstanbul";
        public static string toWhere = "Lizbon";
        public static int suggestionNo = 1;
        public static int numberOfDepartureDays = 50;
        public static int numberOfReturnDays = 60;
        public static DateTime departureDate = DateTime.Now.AddDays(numberOfDepartureDays);
        public static DateTime returnDate = departureDate.AddDays(numberOfReturnDays);
        public static string departureMonth = departureDate.ToString("MMMM", CultureInfo.GetCultureInfo("tr-TR"));
        public static string returnMonth = returnDate.ToString("MMMM", CultureInfo.GetCultureInfo("tr-TR"));
        public static string departureDay = departureDate.Day.ToString();
        public static string returnDay = returnDate.Day.ToString();
        #endregion

        [Test]
        [AllureTag("NUnit", "Debug")]
        [AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")]
        [AllureSeverity(Allure.Commons.SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void EnUygunWebSiteTest()
        {

            _GM.GoToUrl("https://www.enuygun.com/ucak-bileti/"); // enuygun.com uçak bileti ziyaret et
            _do.clickCookieAlertClose();
            _do.clickFromWhere();
            _do.typeFromWhere(fromWhere);
            _do.selectFromWhere(fromWhere, suggestionNo);
            _do.clickToWhere();
            _do.typeToWhere(toWhere);
            _do.selectToWhere(toWhere, suggestionNo);
            _do.clickDepartureDateInput();
            _do.clickDepartureDate(departureMonth, departureDay);
            _do.clickReturnDateInput();
            _do.clickReturnDate(returnMonth, returnDay);
            _do.clickFindTicketButton();
            _do.clickRoundTripDeparture();
            _do.clickRoundTripReturn();
            _do.clickProviderSelectButton();
            Assert.AreEqual("Gidiş Uçuşu", _actuals.outboundFlightText);
            Assert.AreEqual("Dönüş Uçuşu", _actuals.returnFlightText);

        }

        [TearDown]
        public void Teardown()
        {
            _GM.CloseDriver();// Tarayıcıyı kapat
        }

        [OneTimeTearDown]
        public void ottd()
        {
        }
    }
}
