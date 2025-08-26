using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.pages
{
    public class Removeproductpage
    {

        IPage page;

        public Removeproductpage(IPage page)
        {
            this.page = page;
        }

        public async Task Homevisible()
        {
            await Assertions.Expect(page.Locator("//a[normalize-space()='Home']")).ToBeVisibleAsync();
        }

        public async Task addtoproduct()
        {
            await page.Locator("(//a[@class='btn btn-default add-to-cart'][normalize-space()='Add to cart'])[1]").ClickAsync();
            await page.Locator("//u[normalize-space()='View Cart']").ClickAsync();
            await Assertions.Expect(page.Locator("//tr[@id='product-1']")).ToBeVisibleAsync();
            await page.Locator("//i[@class='fa fa-times']").ClickAsync();
            await Assertions.Expect(page.Locator("//b[normalize-space()='Cart is empty!']")).ToBeVisibleAsync();



        }


    }
}
