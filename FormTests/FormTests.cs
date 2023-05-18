using Microsoft.VisualStudio.TestTools.UnitTesting;
using DBServerAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServerAPI.Tests
{
    [TestClass()]
    public class FormTests
    {
        [TestMethod()]
        public void showFormTest()
        {
            string expectedInput1 = "C:\\Users\\alift\\Downloads\\test.png";
            string expectedInput2 = "C:\\Users\\alift\\Downloads\\test.png";
            string expectedInput3 = "C:\\Users\\alift\\Downloads\\test.png";

            string[] inputArr = { expectedInput1, expectedInput2, expectedInput3 };
            using (StringReader sr = new StringReader(string.Join(Environment.NewLine, inputArr)))
            {
                Console.SetIn(sr);

                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    Form.showForm("PENGGANTIAN_KTM");

                    string consoleOutput = sw.ToString().Trim();
                    string[] outputArr = consoleOutput.Split(Environment.NewLine);
                    Assert.AreEqual("Input KSM: " + expectedInput1, outputArr[0]);
                    Assert.AreEqual("Input Surat kehilangan: " + expectedInput2, outputArr[1]);
                    Assert.AreEqual("Input Bukti Pembayaran: " + expectedInput3, outputArr[2]);
                }
            }
        }
    }
}