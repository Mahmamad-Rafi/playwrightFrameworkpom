using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.Utils
{
    public class BaseTest
    {
      
        public IPage page;
        public IBrowser browser;
        public IPlaywright playwright;

        [SetUp]
        public async Task Instancemethod()
        {
            playwright = await Playwright.CreateAsync();

            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 500
            });

            var context = await browser.NewContextAsync();
            page = await context.NewPageAsync();

            await page.GotoAsync("https://automationexercise.com"); 
        }

        [TearDown]
        public async Task AfterClosing()
        {
            if (page != null)
                await page.CloseAsync();

            if (browser != null)
                await browser.CloseAsync();
        }

    }
}
