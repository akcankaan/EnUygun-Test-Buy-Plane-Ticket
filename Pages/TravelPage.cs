using case1_hepsiburada.Utils;
using enUygunCase.Elements;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enUygunCase.Pages
{
    public class TravelPage : TravelElements
    {
        private Helper helper;
        public TravelPage()
        {
            this.helper = new Helper();
        }
        [AllureStep("Çerezleri kabul et.")]
        public void clickCookieAlertClose() => helper.ClickElement(cookieAlertClose);
        [AllureStep("Nereden inputuna tıkla.")]
        public void clickFromWhere() => helper.ClickElement(fromWhere);
        [AllureStep("Şehir adını gir.")]
        public void typeFromWhere(string fromWhereKeyword) => helper.SendkeysElement(base.fromWhere, fromWhereKeyword);
        [AllureStep("Çıkan şehirlerden ilkini seç.")]
        public void selectFromWhere(string fromWhereKeyword, int suggestionNo) => helper.ClickElement(base.fromCountry(fromWhereKeyword, suggestionNo));
        [AllureStep("Nereye inputuna tıkla.")]
        public void clickToWhere() => helper.ClickElement(toWhere);
        [AllureStep("Şehir adını gir.")]
        public void typeToWhere(string toWhereKeyword) => helper.SendkeysElement(base.toWhere, toWhereKeyword);
        [AllureStep("Çıkan şehirlerden ilkini seç.")]
        public void selectToWhere(string fromWhereKeyword, int suggestionNo) => helper.ClickElement(base.toCountry(fromWhereKeyword, suggestionNo));
        [AllureStep("Gidiş tarihi inputuna tıkla.")]
        public void clickDepartureDateInput() => helper.ClickElement(departureDateInput);
        [AllureStep("Parametreden gelen gidiş gününü seç.")]
        public void clickDepartureDate(string departureMonth, string day)
        {
            Get().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            while (true)
            {
                try
                {
                    helper.ClickElement(base.departureDate(departureMonth, day));
                    break;
                }
                catch (Exception)
                {
                    helper.ClickElement(alternativeDepartureElement);
                }
            }
            Get().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        [AllureStep("Dönüş tarihi inputuna tıkla.")]
        public void clickReturnDateInput() => helper.ClickElement(returnDateInput);
        [AllureStep("Parametreden gelen dönüş gününü seç.")]
        public void clickReturnDate(string returnMonth, string day)
        {
            Get().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            while (true)
            {
                try
                {
                    helper.ClickElement(base.returnDate(returnMonth, day));
                    break;
                }
                catch (Exception)
                {
                    helper.ClickElement(alternativeDepartureElement);
                }
            }
            Get().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        [AllureStep("Ucuz bilet bul butonuna tıkla.")]
        public void clickFindTicketButton() => helper.ClickElement(findTicketButton);
        [AllureStep("Gidiş biletini seç.")]
        public void clickRoundTripDeparture() 
        {
           helper.ClickElement(roundTripDeparture);
           Thread.Sleep(1000);
        }
        [AllureStep("Dönüş biletini seç.")]
        public void clickRoundTripReturn() 
        {
           helper.ClickElement(roundTripReturn);
           Thread.Sleep(1000);
        }
        [AllureStep("Seç butonuna tıkla.")]
        public void clickProviderSelectButton() => helper.ClickElement(providerSelectButton);


    }
}

