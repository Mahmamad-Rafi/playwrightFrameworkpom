using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.ILoactor;

namespace Pagemodel.pages
{
    public  class Increasequailty
    {

        IPage page;

        public Increasequailty(IPage page)
        {
            this.page = page;
        }

        public async Task Homepagevisible()
        {
            await Assertions.Expect(page.Locator("//a[normalize-space()='Home']")).ToBeVisibleAsync();
        }

        public async Task viewproductincrease()
        {
            await page.Locator("a[href='/product_details/1']").ClickAsync();
            await Assertions.Expect(page.Locator("//div[@class='product-information']")).ToBeVisibleAsync();
            var input = page.Locator("//input[@id='quantity']");
            await input.ClickAsync();
            await input.PressAsync("ArrowUp");
            await input.PressAsync("ArrowUp");
            await input.PressAsync("ArrowUp");
            await page.Locator("//button[normalize-space()='Add to cart']").ClickAsync();
            await page.Locator("//u[normalize-space()='View Cart']").ClickAsync();
            await Assertions.Expect(page.Locator("//button[@class='disabled']")).ToHaveTextAsync("4");
            //Assertions.Expect(qualityText).ToEqual("4");





        }

    }
}
