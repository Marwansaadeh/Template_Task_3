using System;
using System.Collections.Generic;
using System.Text;
using Template_Task_3.DemoClasses;

namespace Template_Task_3.Helpers
{
    internal static class CheckHelper
    {
        public static Product CheckProductByCode(string productCode, Dictionary<string, Product> products)
        {

            Product selectedProduct;
            bool isProductExsist = products.TryGetValue(productCode.ToUpper(), out selectedProduct!);
            return selectedProduct;

        }
    }
}
