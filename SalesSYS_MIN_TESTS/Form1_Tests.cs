using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesSYS_Min;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSYS_Min.Tests
{
    [TestClass()]
    public class Form1_Tests
    {
        [TestMethod()]
        public void getTotalPriceTest()
        {
            Form1 form = new Form1();
            String actual = form.getTotalPrice("4.00", "4.00");
            string expected = "8.00";
            Assert.AreEqual(expected, actual);
        }
    }
}