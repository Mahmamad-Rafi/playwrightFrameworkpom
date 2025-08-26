using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.pages
{
    public class loginpage
    {

        IPage page;

        public loginpage(IPage page) {
            this.page = page;
        }

        public async Task loginpagenew(string username, string password)
        {
            await page.Locator("//a[normalize-space()='Signup / Login']").ClickAsync();
            await page.Locator("//input[@data-qa='login-email']").FillAsync(username);
            await page.Locator("//input[@placeholder='Password']").FillAsync(password);
            await page.Locator("//button[normalize-space()='Login']").ClickAsync();
        }

    }
}
