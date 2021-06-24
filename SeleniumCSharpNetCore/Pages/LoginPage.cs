using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumCSharpNetCore.Pages
{
	class LoginPage : DriverHelper
	{


		IWebElement fldUserName => Driver.FindElement(By.Id("UserName"));
		IWebElement fldPassword => Driver.FindElement(By.Id("Password"));
		IWebElement btnSubmit => Driver.FindElement(By.XPath("//input[@value='Log in']"));

		public void EnterUserNameAndPassWord() {

			fldUserName.SendKeys("admin");
			fldPassword.SendKeys("password");

		}


		public void ClockLogin()
		{

			btnSubmit.Click();

		}



	}
}
