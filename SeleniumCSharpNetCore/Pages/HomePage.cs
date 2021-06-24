using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumCSharpNetCore.Pages
{
	class HomePage 
	{

		private IWebDriver Driver;

		public HomePage(IWebDriver driver)
		{
			Driver = driver;
		}
		IWebElement lnkLogin => Driver.FindElement(By.Id("loginLink"));

		IWebElement lnkLogOff => Driver.FindElement(By.LinkText("Log off"));

		public void ClickLogin() => lnkLogin.Click();

		public bool IsLogOffExist() => lnkLogOff.Displayed;
	}
}
