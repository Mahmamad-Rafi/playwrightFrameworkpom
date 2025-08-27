using Pagemodel.pages;
using Pagemodel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.Testcases
{
    public class validateproductstest:BaseTest
    {

        [Test]

        public async Task vliadateproduct()
        {
            var validatepro = new validateproducts(page);

            await validatepro.Homevisible();
            await validatepro.productclick("tshrit");
        }
    }
}
