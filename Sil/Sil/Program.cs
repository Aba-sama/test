using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Drawing;
using System.Drawing.Imaging;

namespace Sil
{
    class Program
    {
        static void Main(string[] args)
        {
            Screenshot ss;
            //tylko imie (niepoprawne)
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("tak");
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/1.png", ScreenshotImageFormat.Png);
             driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //imie i nazwisko(niepoprawne)
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("123123");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/2.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
             driver.Quit();
            // nazwisko(niepoprawne)
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/3.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //imie i nazwisko(niepoprawne) data (Poprawna - pełnoletni) zapis 1
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("123123");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            driver.FindElement(By.Id("dataU")).SendKeys("1-1-2000");
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/4.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //imie i nazwisko(niepoprawne) data (Poprawna - pełnoletni) zapis 2
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("123123");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            driver.FindElement(By.Id("dataU")).SendKeys("10/10/2000");
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/5.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //imie i nazwisko(niepoprawne) data (niepoprawna - nie ma 300 lat + ludzi) 
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("123123");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            driver.FindElement(By.Id("dataU")).SendKeys("10/10/1700");
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/6.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //imie i nazwisko(niepoprawne) data (Poprawna - senior) brak zaświadczenia
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("123123");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            driver.FindElement(By.Id("dataU")).SendKeys("10/10/1920");
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/7.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //imie i nazwisko(niepoprawne) data (Poprawna - senior)zaświadczenie
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("123123");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            driver.FindElement(By.Id("dataU")).SendKeys("10/10/1920");
            driver.FindElement(By.Id("lekarz")).Click();
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/8.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //imie i nazwisko(niepoprawne) data (Poprawna - pełnoletni) 
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("123123");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            driver.FindElement(By.Id("dataU")).SendKeys("10/10/2000");
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/9.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //sprawdzam czy jest zabezpieczenie przed injectami
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("<strong>Nie ma</strong>");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            driver.FindElement(By.Id("dataU")).SendKeys("10/10/2000");
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/10.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //imie i nazwisko(niepoprawne) data niepoprawna (przyszłość)
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("123123");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            driver.FindElement(By.Id("dataU")).SendKeys("10/10/2100");
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/11.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //imie i nazwisko(niepoprawne) data poprawna (10 lat) brak zgody
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("123123");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            driver.FindElement(By.Id("dataU")).SendKeys("10/10/2010");
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/12.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //imie i nazwisko(niepoprawne) data poprawna (10 lat) zgoda
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("123123");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            driver.FindElement(By.Id("dataU")).SendKeys("10/10/2010");
            driver.FindElement(By.Id("rodzice")).Click();
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/13.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //imie i nazwisko(niepoprawne) data poprawna (14 lat) zgoda
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("123123");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            driver.FindElement(By.Id("dataU")).SendKeys("10/10/2014");
            driver.FindElement(By.Id("rodzice")).Click();
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/14.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //imie i nazwisko(niepoprawne) data poprawna (16 lat) zgoda
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("123123");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            driver.FindElement(By.Id("dataU")).SendKeys("10/10/2016");
            driver.FindElement(By.Id("rodzice")).Click();
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/14.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();
            //imie i nazwisko(niepoprawne) data poprawna (17 lat) zgoda
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("InputEmail3")).SendKeys("123123");
            driver.FindElement(By.Id("InputPassword3")).SendKeys("123123");
            driver.FindElement(By.Id("dataU")).SendKeys("10/10/2017");
            driver.FindElement(By.Id("rodzice")).Click();
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("H:/testySil/1/Sil/Sil/img/15.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath(".//*[@id='formma']/div[6]/div/button")).Click();
            driver.Quit();

        }
    }
}
