using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System.Collections.Generic;

namespace PromotionEngine_Test
{
    [TestClass]
    public class UnitTest1
    {
        //TTD Approch to Acceptance TDD & Developer TDD
        [TestMethod]
        //3 * A
        public void TestMethod1()
        {

            List<Product> products = new List<Product>();
            for (int i = 0; i < 3; i++)
            {
                PromotionEngine.Product p = new PromotionEngine.Product("A");
                products.Add(p);
            }
            PromotionEngine.Program.GetTotalPrice(products);
        }

        [TestMethod]
        //2 * B
        public void TestMethod2()
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < 2; i++)
            {
                PromotionEngine.Product p = new PromotionEngine.Product("B");
                products.Add(p);
            }
            PromotionEngine.Program.GetTotalPrice(products);
        }
    }
}
