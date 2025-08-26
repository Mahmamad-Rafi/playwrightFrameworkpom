using Pagemodel.pages;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Pagemodel.Utils;

namespace Pagemodel.Testcases
{
    public class contactusTest : BaseTest
    {
        [Test]
       public async Task contusform()
        {
            var cont = new contactus(page);
           await cont.ClickContactUs();
           await cont.VerifyGetInTouchVisible();
           await cont.FillContactForm("Rafi", "rafishai123@gmail.com", "product is are damge and i want return the product", "returnpolicy is having or not ");
            await cont.UploadFile("C:\\Users\\rafis\\OneDrive\\Pictures\\Saved Pictures\\certificate.png");
            await cont.HandleDialog();
            await cont.SubmitForm();
            await cont.VerifySuccessMessage();
            await cont.ClickHomeAndVerify();
        }



    }
}
