using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.pages
{
    public class AddTocartbill
    {
        IPage page;

        public AddTocartbill(IPage page) {
            this.page = page;
        }

        public async Task SearchAndAddProduct(string productName)
        {
            await page.ClickAsync("//a[contains(text(),'Products')]");
            await page.FillAsync("//input[@id='search_product']", productName);
            await page.ClickAsync("//button[@id='submit_search']");
            await page.ClickAsync("(//a[contains(text(),'Add to cart')])[2]");
            await page.ClickAsync("//u[contains(text(),'View Cart')]");
        }

        public async Task Login(string email, string password)
        {
            await page.ClickAsync("//a[contains(text(),'Signup / Login')]");
            await page.FillAsync("//input[@data-qa='login-email']", email);
            await page.FillAsync("//input[@data-qa='login-password']", password);
            await page.ClickAsync("//button[@data-qa='login-button']");
        }

        public async Task ProceedToCheckout(string comment)
        {
            await page.ClickAsync("//a[contains(text(),'Cart')]");
            await page.ClickAsync("(//button[@class='disabled'])[1]");
            await page.ClickAsync("//a[contains(text(),'Proceed To Checkout')]");
            await page.FillAsync("//textarea[@name='message']", comment);
            await page.ClickAsync("//a[contains(text(),'Place Order')]");
        }

        public async Task FillPaymentDetails(string name, string card, string cvc, string month, string year)
        {
            await page.FillAsync("//input[@name='name_on_card']", name);
            await page.FillAsync("//input[@name='card_number']", card);
            await page.FillAsync("//input[@placeholder='ex. 311']", cvc);
            await page.FillAsync("//input[@placeholder='MM']", month);
            await page.FillAsync("//input[@placeholder='YYYY']", year);
            await page.ClickAsync("//button[contains(text(),'Pay and Confirm Order')]");
        }

        public async Task DownloadInvoice()
        {
            await page.RunAndWaitForDownloadAsync(async () =>
            {
                await page.ClickAsync("//a[contains(text(),'Download Invoice')]");
            });
        }

        public async Task ContinueAndLogout()
        {
            await page.ClickAsync("//a[contains(text(),'Continue')]");
            await page.ClickAsync("//a[contains(text(),'Logout')]");
        }



    }
}
