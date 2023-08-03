using case1_hepsiburada.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enUygunCase.Elements
{
    public class TravelElements : Driver
    {
        public IWebElement cookieAlertClose => Get().FindElement(By.CssSelector("#CookieAlert button.close"));
        public IWebElement fromWhere => Get().FindElement(By.Id("OriginInput"));
        public IWebElement fromCountry(string fromWhereKeyword, int suggestionNo) => Get().FindElement(By.XPath($"(//div[@class='city_info']//div[@class='region']//strong[text()='{fromWhereKeyword}'])[{suggestionNo}]"));
        public IWebElement toWhere => Get().FindElement(By.Id("DestinationInput"));
        public IWebElement toCountry(string toWhereKeyword, int suggestionNo) => Get().FindElement(By.XPath($"(//div[@class='city_info']//div[@class='region']//strong[text()='{toWhereKeyword}'])[{suggestionNo}]"));
        public IWebElement departureDateInput => Get().FindElement(By.Id("DepartureDate"));
        public IWebElement alternativeDepartureElement => Get().FindElement(By.XPath("//div[@class=\"DayPickerNavigation_button DayPickerNavigation_button_1 DayPickerNavigation_button__horizontal DayPickerNavigation_button__horizontal_2\"][2]"));
        public IWebElement departureDate(string departureMonth, string day) => Get().FindElement(By.XPath($"//td[not(@aria-disabled='true') and contains(@aria-label,'{departureMonth}')]//div[@class='CalendarDay__content' and text()='{day}']"));
        public IWebElement returnDateInput => Get().FindElement(By.Id("ReturnDate"));
        public IWebElement returnDate(string returnMonth, string day) => Get().FindElement(By.XPath($"//td[not(@aria-disabled='true') and contains(@aria-label,'{returnMonth}')]//div[@class='CalendarDay__content' and text()='{day}']"));
        public IWebElement findTicketButton => Get().FindElement(By.CssSelector("button[data-testid='formSubmitButton']"));
        public IWebElement roundTripDeparture => Get().FindElement(By.XPath("(//div[contains(@data-provider,'project_pi')])[1]"));
        public IWebElement roundTripReturn => Get().FindElement(By.XPath("(//div[contains(@data-provider,'project_pi')])[2]"));
        public IWebElement providerSelectButton => Get().FindElement(By.Id("tooltipTarget_0"));
        public IWebElement flightPack => Get().FindElement(By.Id("div.flight-item__wrapper"));
      

    }
}
