using Pagemodel.pages;
using Pagemodel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.Testcases
{
    public class RemoveproductTest : BaseTest
    {

        [Test]

        public async Task RemoveproductfromProduct()
        {
            var remove = new Removeproductpage(page);
            await remove.Homevisible();
            await remove.addtoproduct();
        }


    }
}
