using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace test_2018
{
    // [TestClass]
    [TestFixture]
    public class UnitTest1
    {
        //[TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("start");
            //int i = 0;
            double i = 0;
            Console.WriteLine("(i + 1) / i = " + (i + 1) / i);
            Console.WriteLine("done");
            //throw new Exception("ha ha ha ");
        }

        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            Console.WriteLine("[OneTimeSetUp] BeforeAllMethods()");
        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            Console.WriteLine("[OneTimeTearDown] AfterAllMethods()");
        }


        [SetUp]
        public void SetUp()
        {
                Console.WriteLine("[SetUp] SetUp()");
        }

        [TearDown]
        public void TearnDoun()
        {
            Console.WriteLine("[TearnDoun] TearnDoun()");
        }

        [Test]
        public void TestMethod1(
            [Values("Hello", "World")]
            string s,
            [Random(1,10,5)]
            int x
            )
        {
            Console.WriteLine("Ok, s = " + s + " x = " + x);
        }

        [TestCase(5, ExpectedResult = true)]
        //[TestCase(-15, ExpectedResult = false)]
        public bool TestMethod2(int x)
        {
            return x > 0;
        }


        //DataProvider
        private static readonly object[] ConverterData =
        {
            new object[] { 65, 'A' },
            new object[] { 97, 'a'},
            new object[] { 98, 'b'}
        };

       // [Test, TestCaseSource(nameof(ConverterData))]
        public void TestMethod3(int x, char c)
        {
            char expexted = c;
            char actual = (char)x;
            Assert.AreEqual(expexted, actual);
        }
    }
}
