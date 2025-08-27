using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.pages
{
    public class validateproducts
    {
        IPage page;

        public validateproducts(IPage page)
        {
            this.page = page;
        }


        public async Task Homevisible()
        {
            await Assertions.Expect(page.Locator("//a[normalize-space()='Home']")).ToBeVisibleAsync();
        }

        public async Task productclick(string productname)
        {
            await page.Locator("//a[@href='/products']").ClickAsync();
            await Assertions.Expect(page.Locator("//h2[@class='title text-center']")).ToBeVisibleAsync();

            await page.Locator("//input[@id='search_product']").FillAsync(productname);
            await page.Locator("//button[@id='submit_search']").ClickAsync();

            await Assertions.Expect(page.Locator("//h2[normalize-space()='Searched Products']")).ToBeVisibleAsync();

            var productTitles = page.Locator("//div[@class='productinfo text-center']/p");
            int count = await productTitles.CountAsync();

            for (int i = 0; i < count; i++)
            {
                var title = await productTitles.Nth(i).InnerTextAsync();
                if (!title.ToLower().Contains(productname.ToLower()))
                {
                    throw new Exception($"Product '{title}' does not match search keyword '{productname}'");
                }
            }
        }
    }
}
