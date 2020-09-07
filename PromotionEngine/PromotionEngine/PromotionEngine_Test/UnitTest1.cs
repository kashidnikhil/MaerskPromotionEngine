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
        //3 A Product
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
        //2 B Product
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

        [TestMethod]
        //1 * C
        //1 C Product
        public void TestMethod3()
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < 1; i++)
            {
                PromotionEngine.Product p = new PromotionEngine.Product("C");
                products.Add(p);
            }
            PromotionEngine.Program.GetTotalPrice(products);
        }

        [TestMethod]
        //1 * D
        //1 D Product
        public void TestMethod4()
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < 1; i++)
            {
                PromotionEngine.Product p = new PromotionEngine.Product("D");
                products.Add(p);
            }
            PromotionEngine.Program.GetTotalPrice(products);
        }

    }
}
