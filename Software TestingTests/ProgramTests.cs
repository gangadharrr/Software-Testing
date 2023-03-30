using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Software_Testing.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public static FileStream file = new FileStream("D:/TestCases.txt", FileMode.Open, FileAccess.Read);
        public static StreamReader sr = new StreamReader(file);
        [TestMethod()]
        public void FactorialTest()
        {

            string outp = Program.Factorial(Convert.ToInt32(sr.ReadLine())).ToString();
            Assert.AreEqual(sr.ReadLine(), outp);

        } [TestMethod()]
        public void FactorialTest1()
        {

            string outp = Program.Factorial(Convert.ToInt32(sr.ReadLine())).ToString();
            Assert.AreEqual(sr.ReadLine(), outp);

        }
        [TestMethod()]
        public void FactorialTest2()
        {

            string outp = Program.Factorial(Convert.ToInt32(sr.ReadLine())).ToString();
            Assert.AreEqual(sr.ReadLine(), outp);
            sr.Close();
            file.Close();
        }
        [TestMethod()]
        public void MainTest()
        {
            try 
            {
                Program.Main(new string[] { "hi"});
                Assert.IsTrue(true);

            }
            catch (Exception ex) 
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}