using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

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

	}
}
