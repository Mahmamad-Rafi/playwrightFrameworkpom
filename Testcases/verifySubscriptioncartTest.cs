using Pagemodel.pages;
using Pagemodel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.Testcases
{
    public  class verifySubscriptioncartTest :BaseTest
    {

        [Test]

        public async Task verifycartsub()
        {
            var verifycart = new verifySubscriptioncart(page);
            await verifycart.Homepagevisible();
            await verifycart.clickoncart();
            await verifycart.subscriptionverification();
            await verifycart.Fillemaildetailsub("rafi.shai12@gmail.com");
            await verifycart.visbilethanksubscription();

        }
    }
}
