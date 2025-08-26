using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.pages
{
    public  class viewproductpage
    {

        IPage page;

        public viewproductpage(IPage page)
        {
            this.page = page;
        }

        public async Task leftcatgorey()
        {
            await Assertions.Expect(page.Locator("//h2[normalize-space()='Category']")).ToBeVisibleAsync();
            await page.Locator("//a[normalize-space()='Women']").ClickAsync();
            await page.Locator("//div[@id='Women']//a[contains(text(),'Dress')]").ClickAsync();
            await Assertions.Expect(page.Locator("//h2[normalize-space()='Women - Dress Products']")).ToBeVisibleAsync();
            await page.Locator("//a[normalize-space()='Men']").ClickAsync();
            await page.Locator("//a[normalize-space()='Tshirts']").ClickAsync();
            await Assertions.Expect(page.Locator("//h2[normalize-space()='Men - Tshirts Products']")).ToBeVisibleAsync();






        }
    }
}
