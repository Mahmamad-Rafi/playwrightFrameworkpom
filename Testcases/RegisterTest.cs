using Pagemodel.pages;
using Pagemodel.Utils;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.Testcases
{
    public class RegisterTest : BaseTest
    {
        [Test]

        public async Task registeruser()
        {
            var Rsuser = new RegisterPage(page);

            await Rsuser.NavigateToHomePageclicksingup();
            await Rsuser.Newuservisible();

            await Rsuser.EnterNameAndEmail("Rafi", "rafishaik123@gmail.com");
            await Rsuser.ClickSignupButton();
            await Rsuser.VerifyEnterAccountInfoVisible();
            await Rsuser.FillAccountDetails("123456", "14", "5", "2003");
            await Rsuser.SelectNewsletterAndOffers();
            await Rsuser.FillAddressDetails();
            await Rsuser.ClickCreateAccount();
            await Rsuser.VerifyAccountCreated();
            await Rsuser.ClickContinue();
            await Rsuser.VerifyLoggedInAs();
            await Rsuser.ClickDeleteAccount();
            await Rsuser.VerifyAccountDeleted();
        }
    }
}
