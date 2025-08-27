using Pagemodel.pages;
using Pagemodel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.Testcases
{
    public  class Addtwoproductcarttest:BaseTest
    {

        [Test]

        public async Task addtwoproduct()
        {
            var addtwoproduct = new Addtwoproductincarts(page);
            await addtwoproduct.Homevisible();
            await addtwoproduct.AddTwoProductsToCartAndVerify();


        }
    }
}
