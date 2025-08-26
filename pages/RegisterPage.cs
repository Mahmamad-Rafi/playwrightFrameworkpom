using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pagemodel.pages
{
    public class RegisterPage 
    {

        IPage page;

        public RegisterPage(IPage page)
        {
            this.page = page;
        }

        public async Task NavigateToHomePageclicksingup()
        {
            await page.Locator("//a[normalize-space()='Signup / Login']").ClickAsync();
        }

        public async Task Newuservisible()
        {
            await Assertions.Expect(page.Locator("text=New User Signup!")).ToBeVisibleAsync();

        }

        public async Task EnterNameAndEmail(string name, string email)
        {
            await page.FillAsync("input[data-qa='signup-name']", name);
            await page.FillAsync("input[data-qa='signup-email']", email);
        }

        public async Task ClickSignupButton()
        {
            await page.ClickAsync("button[data-qa='signup-button']");
        }

        public async Task VerifyEnterAccountInfoVisible()
        {
            var Info = page.GetByText("Enter Account Information");
            await Assertions.Expect(Info).ToBeVisibleAsync();


        }

        public async Task FillAccountDetails(string password, string Day, string Month, string Year)
        {
            await page.CheckAsync("#id_gender1");
            await page.FillAsync("#password", password);
            await page.SelectOptionAsync("//select[@data-qa='days']", Day);
            await page.SelectOptionAsync("//select[@data-qa='months']", Month);
            await page.SelectOptionAsync("//select[@data-qa='years']", Year);
        }

        public async Task SelectNewsletterAndOffers()
        {
            await page.CheckAsync("#newsletter");
            await page.CheckAsync("#optin");
        }

        public async Task FillAddressDetails()
        {
            await page.FillAsync("#first_name", "Shaik");
            await page.FillAsync("#last_name", "Tester");
            await page.FillAsync("#company", "TestCorp");
            await page.FillAsync("#address1", "123 Test Street");
            await page.FillAsync("#address2", "Suite 456");
            await page.SelectOptionAsync("#country", "India");
            await page.FillAsync("#state", "Telangana");
            await page.FillAsync("#city", "Hyderabad");
            await page.FillAsync("#zipcode", "500008");
            await page.FillAsync("#mobile_number", "9876543210");
        }

        public async Task ClickCreateAccount()
        {
            await page.ClickAsync("button[data-qa='create-account']");

        }

        public async Task VerifyAccountCreated()
        {
           
            await Assertions.Expect(page.Locator("text=Account Created!")).ToBeVisibleAsync();
         
        }

        public async Task ClickContinue()
        {
            await page.ClickAsync("text=Continue");
        }

        public async Task VerifyLoggedInAs()
        {

            var loggedInText = page.Locator("//a[contains(text(), 'Logged in as')]");
            await Assertions.Expect(loggedInText).ToBeVisibleAsync();
        }
        public async Task ClickDeleteAccount()
        {
            await page.ClickAsync("text=Delete Account");
        }

        public async Task VerifyAccountDeleted()
        {
            await Assertions.Expect(page.Locator("text=Account Deleted!")).ToBeVisibleAsync();
            await page.ClickAsync("text=Continue");
        }




    }
}
