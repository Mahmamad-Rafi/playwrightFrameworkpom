using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.pages
{
    public  class Addtwoproductincarts
    {

        IPage page;

        public Addtwoproductincarts(IPage page)
        {
            this.page = page;
        }

        public async Task Homevisible()
        {
            await Assertions.Expect(page.Locator("//a[normalize-space()='Home']")).ToBeVisibleAsync();
        }

        public async Task AddTwoProductsToCartAndVerify()
        {
           

           
            // Go to Products page
            await page.Locator("//a[@href='/products']").ClickAsync();
            await Assertions.Expect(page.Locator("//h2[normalize-space()='All Products']")).ToBeVisibleAsync();

            // Add first product
           await page.Locator("(//div[@class='product-overlay'])[1]").HoverAsync();
            await page.Locator("//div[@class='col-sm-9 padding-right']//div[2]//div[1]//div[1]//div[2]//div[1]//a[1]").ClickAsync();
            await page.Locator("//button[normalize-space()='Continue Shopping']").ClickAsync();

            // Add second product
            await page.Locator("(//div[@class='product-overlay'])[2]").HoverAsync();
            await page.Locator("//div[3]//div[1]//div[1]//div[2]//div[1]//a[1]").ClickAsync();

            // View Cart
            await page.Locator("//u[normalize-space()='View Cart']").ClickAsync();

            // Verify both products are in cart
            var cartItems = page.Locator("//tr[contains(@id, 'product')]");
            int count = await cartItems.CountAsync();
            if (count < 2) throw new Exception("Less than 2 products found in cart.");

            // Verify price, quantity, and total for each product
            for (int i = 0; i < count; i++)
            {
                var price = await cartItems.Nth(i).Locator(".cart_price").InnerTextAsync();
                var quantity = await cartItems.Nth(i).Locator(".cart_quantity").InnerTextAsync();
                var total = await cartItems.Nth(i).Locator(".cart_total").InnerTextAsync();

                Console.WriteLine($"Product {i + 1}: Price = {price}, Quantity = {quantity}, Total = {total}");
            }
        }







    }
}
