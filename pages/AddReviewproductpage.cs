using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.pages
{
    public class AddReviewproductpage
    {

        IPage page;

        public AddReviewproductpage(IPage page) {
            this.page = page;
           
        }

        public async Task clickproduct()
        {
            await page.Locator("//a[@href='/products']").ClickAsync();
            await Assertions.Expect(page.Locator("//h2[normalize-space()='All Products']")).ToBeVisibleAsync();
            await page.Locator("a[href='/product_details/1']").ClickAsync();
            await Assertions.Expect(page.Locator("//a[normalize-space()='Write Your Review']")).ToBeVisibleAsync();


        }

        public async Task filldetailsToReview(string name , string email ,string review)
        {
            await page.FillAsync("//input[@id='name']", name);
            await page.FillAsync("//input[@id='email']", email);
            await page.FillAsync("//textarea[@id='review']", review);
            await page.Locator("//button[@id='button-review']").ClickAsync();

        }

        public async Task verifyThank()
        {
            await Assertions.Expect(page.Locator("//span[normalize-space()=\"Thank you for your review.\"]")).ToBeVisibleAsync();

        }
    }
}
