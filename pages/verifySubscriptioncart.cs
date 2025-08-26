using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.pages
{
    public class verifySubscriptioncart
    {

        IPage Page;
        public verifySubscriptioncart(IPage page)
        {
            this.Page = page;
        }

        public async Task Homepagevisible()
        {
            await Assertions.Expect(Page.Locator("//a[normalize-space()='Home']")).ToBeVisibleAsync();
        }

        public async Task clickoncart()
        {
            await Page.Locator("//a[normalize-space()='Cart']").ClickAsync();
        }

        public async Task subscriptionverification()
        {
            var subcriptionvalues = Page.Locator("//h2[normalize-space()='Subscription']");
            await subcriptionvalues.ScrollIntoViewIfNeededAsync();
            await Assertions.Expect(subcriptionvalues).ToBeVisibleAsync();

        }

        public async Task Fillemaildetailsub(string email)
        {
            await Page.FillAsync("//input[@id='susbscribe_email']", email);
            await Page.Locator("//button[@id='subscribe']").ClickAsync();
        }

        public async Task visbilethanksubscription()
        {
            await Assertions.Expect(Page.Locator("//div[@class=\"alert-success alert\"]")).ToBeVisibleAsync();
        }


    }
}
