using Pagemodel.pages;
using Pagemodel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.Testcases
{
    public class viewproductTest : BaseTest
    {

        [Test]

        public async Task viewproducrdetails()
        {
            var view = new viewproductpage(page);
            await view.leftcatgorey();
        }
    }
}
