using Pagemodel.pages;
using Pagemodel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagemodel.Testcases
{
    public class AddReviewproductsTest:BaseTest
    {
        [Test]

        public async Task Addreviewtoproducts()
        {
            var review = new AddReviewproductpage(page);
            await review.clickproduct();
            await review.filldetailsToReview("rafi","rafi12@gmail.com","product is good in quailty");
            await review.verifyThank();
        }
        
    }
}
