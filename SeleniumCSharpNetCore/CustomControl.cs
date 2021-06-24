using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpNetCore
{
	public class CustomControl : DriverHelper
	{

		public static void ComboBox(string ControlName, string value) {


			IWebElement AllMealsCombo = Driver.FindElement(By.Id($"{ControlName}-awed"));
			AllMealsCombo.Clear();
			AllMealsCombo.SendKeys(value);
			AllMealsCombo.SendKeys(Keys.Enter);


		}


		public static void SelectByValue(IWebElement webElement, string value)
		{


			SelectElement selectElement = new SelectElement(webElement);

			selectElement.SelectByValue(value);

		}

		public static void SelectByText(IWebElement webElement, string text)
		{


			SelectElement selectElement = new SelectElement(webElement);

			selectElement.SelectByText(text);

		}

	}
}
