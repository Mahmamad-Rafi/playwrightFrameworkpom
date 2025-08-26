using Pagemodel.pages;
using Pagemodel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.Testcases
{
    public class IncreasequailtyTest:BaseTest
    {
        [Test]

        public async Task increasequailtyofproduct()
        {
            var increase = new Increasequailty(page);
             await increase.Homepagevisible();
             await increase.viewproductincrease();
        }
    }
}
