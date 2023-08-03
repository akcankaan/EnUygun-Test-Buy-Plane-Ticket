using case1_hepsiburada.Utils;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enUygunCase.Actuals
{
    public class TravelActuals : Helper
    {
        public string outboundFlightText => GetText(By.XPath("//a[contains(., 'Gidiş Uçuşu')]"));
        public string returnFlightText => GetText(By.XPath("//a[contains(., 'Dönüş Uçuşu')]"));
    }
}
