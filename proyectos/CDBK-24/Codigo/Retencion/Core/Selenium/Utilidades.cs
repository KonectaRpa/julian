using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selenium
{
    public class Utilidades
    {
        IWebDriver nav;
        public void CrearNav()
        {
            try
            {
                nav = new ChromeDriver();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
