
using NUnit.Framework;
using SalesSYS_Min;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSYS_Min.Tests
{
    
    public class Form1_Tests
    {
        [Test]
        public void getTotalPriceTest()
        {
            Form1 form = new Form1();
            String actual = form.getTotalPrice("4.00", "4.00");
            string expected = "8.00";
            Assert.AreEqual(expected, actual);
        }
    }
}