using Microsoft.Playwright;
using Pagemodel.pages;
using Pagemodel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pagemodel.Testcases
{
    public class AddtocartbillTest :BaseTest
    {
        [Test]
        public async Task Adddingdetailstocart()
        {
            var cartPage = new AddTocartbill(page);
            await cartPage.SearchAndAddProduct("winter top");
            await cartPage.Login("rafishaik25@gmail.com", "123456");
            await cartPage.ProceedToCheckout("it is awesome looking good product ");
            await cartPage.FillPaymentDetails("rafishaik", "12346789455", "123", "25", "29");
            await cartPage.DownloadInvoice();
            await cartPage.ContinueAndLogout();


        }
    }
}
