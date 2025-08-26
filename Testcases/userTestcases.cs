using Microsoft.Playwright;
using Pagemodel.pages;
using Pagemodel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pagemodel.Testcases
{
    public  class userTestcases : BaseTest
    {
        [Test]
        [TestCase("rafi.shaik63056@gmail.com", "123456")] 
        public async Task loginwithdetails(string username, string password)
        {
            var login = new loginpage(page);
            await login.loginpagenew(username, password);

            //  var userLocator = page.Locator("//b[normalize-space()='Shaik Mahmamad Rafi']");
            //await Assertions.Expect(userLocator).ToHaveTextAsync("Shaik Mahmamad Rafi");

            var loggedInText = page.Locator("//a[contains(text(), 'Logged in as')]");
            await Assertions.Expect(loggedInText).ToBeVisibleAsync();

            // await Assertions.Expect(page).ToHaveTitleAsync("Automation Exercise");

        }    

    }
}
