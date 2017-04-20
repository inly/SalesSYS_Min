﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;
using SalesSYS_Min;

namespace SalesSYS_Min.Tests
{

    public class DAO_Tests
    {
        [Test]
        public void GetByCategoryTest()
        {
            string category = "Hat";
            DAO dao = new DAO();

            DataTable table = dao.GetByCategory(category);

            bool isHat = true;
            foreach (DataRow row in table.Rows)
            {
                string value = row.ItemArray[2].ToString();
                MessageBox.Show(value);
                if ((row.ItemArray[2].ToString().CompareTo("Hat")) == 1)
                {
                    MessageBox.Show(row.ItemArray[2].ToString());
                }
                else
                {
                    MessageBox.Show("False: " + row.ItemArray[2].ToString());

                    isHat = false;
                    break;
                }
            }
            Assert.IsTrue(isHat);


        }
    }
}
