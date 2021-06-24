using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCSharpNetCore
{
	public class Tests : DriverHelper
	{

	

		[SetUp]
		public void Setup()
		{

			Console.WriteLine("Setup");
			ChromeOptions chromeOptions = new ChromeOptions();
			Driver = new ChromeDriver(@"C:\\drivers");

		}

		[Test]
		public static void Test1()
		{
			Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");

			Driver.FindElement(By.Id("Meal")).SendKeys("Tomato");
			Driver.FindElement(By.Id("Meal")).SendKeys(Keys.Enter);

			Driver.FindElement(By.XPath("//input[@name='ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

			CustomControl.ComboBox("AllMealsCombo", "Almond");



			Console.WriteLine("Teste1");
			Assert.Pass();


		}



		[TearDown]
		public void TearDown()
		{

			//Driver.Quit();

		}

	}
}