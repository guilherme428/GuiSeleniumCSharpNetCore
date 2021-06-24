using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumCSharpNetCore.Pages
{
	class LoginPage 
	{


		private IWebDriver Driver;

		public LoginPage(IWebDriver driver)
		{
			Driver = driver;
		}

		IWebElement fldUserName => Driver.FindElement(By.Id("UserName"));
		IWebElement fldPassword => Driver.FindElement(By.Id("Password"));
		IWebElement btnSubmit => Driver.FindElement(By.XPath("//input[@value='Log in']"));

		public void EnterUserNameAndPassword(String UserName, String Password) {

			fldUserName.SendKeys(UserName);
			fldPassword.SendKeys(Password);

		}


		public void ClickLogin()
		{

			btnSubmit.Click();

		}


	}
}
