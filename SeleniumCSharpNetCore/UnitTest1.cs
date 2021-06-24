using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpNetCore.Pages;
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

			//Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

		}

		[Test]
		public static void Test1()
		{
			WebDriverWait wait = new WebDriverWait(Driver,TimeSpan.FromSeconds(30));
			Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");

			//wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("Meal")));


			WebDriverWait FluentWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
			FluentWait.PollingInterval = TimeSpan.FromSeconds(10);
			FluentWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("Meal")));

			CustomControl.ComboBox("AllMealsCombo", "Almond");
			IWebElement comboAjax = Driver.FindElement(By.Id("add1-awed"));
			CustomControl.SelectByValue(comboAjax, "185");


			Console.WriteLine("Teste1");

			Assert.Pass();


		}


		[Test]
		public static void LoginTest()
		{

			Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

			HomePage homePage = new HomePage();
			LoginPage loginPage = new LoginPage();

			homePage.ClickLogin();

			loginPage.EnterUserNameAndPassWord();
			loginPage.ClockLogin();

			Assert.That(homePage.IsLogOffExist(),Is.True,"Log off button did nor displayed!");

		}

		[TearDown]
		public void TearDown()
		{

			//Driver.Quit();

		}

	}
}