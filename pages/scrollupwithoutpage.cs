using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.pages
{
    public class scrollupwithoutpage
    {
        IPage page;
        public scrollupwithoutpage(IPage page)
        {
            this.page=page;
        }

        public async Task Homepagevisible()
        {
            await Assertions.Expect(page.Locator("//a[normalize-space()='Home']")).ToBeVisibleAsync();
        }

        public async Task verifyscoll()
        {
            var subscriptionHeader = page.Locator("//h2[normalize-space()='Subscription']");
            await subscriptionHeader.ScrollIntoViewIfNeededAsync();
            await Assertions.Expect(subscriptionHeader).ToBeVisibleAsync();
            var automationheader = page.Locator("//div[@class='item active']//h2[contains(text(),'Full-Fledged practice website for Automation Engin')]");
            await automationheader.ScrollIntoViewIfNeededAsync();
            await Assertions.Expect(automationheader).ToBeVisibleAsync();

        }


    }
}
