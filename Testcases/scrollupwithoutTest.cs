using Pagemodel.pages;
using Pagemodel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.Testcases
{
     public class scrollupwithoutTest:BaseTest
    {

        [Test]

        public async Task scrolluppage()
        {
            var scroll = new scrollupwithoutpage(page);
            await scroll.Homepagevisible();
            await scroll.verifyscoll();
        }
    }
}
