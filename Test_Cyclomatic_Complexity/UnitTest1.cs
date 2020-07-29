using System;
using System.Windows.Forms;
using Cyclomatic_Complexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Cyclomatic_Complexity
{
    [TestClass]
    public class UnitTest1
    {
        Cyclomatic_Complexity.Form1 _CycComTest = new Cyclomatic_Complexity.Form1();
        [TestMethod]
        public void TestClearCodeLine()
        {   
            string[] testString = { "#This is a test sentence",
                                    "input(This is a test sentence)",
                                    "print(This is a test sentence)",
                                    "This is a test sentence" };
            string sonuc = _CycComTest.ClearCodeLine(testString);
            int testValue = 1;

            if(sonuc.Contains("#"))
            {
                testValue = -1;
            }

            Assert.AreEqual(1, testValue);
        }

        [TestMethod]
        public void TestCountKeyword()
        {
            int testValue = -1;

            string testCode = "This is a representative test code.It contains these keyword: while for and or if def";
            string testIf = "if";
            testValue = _CycComTest.CountKeyword(testCode, testIf);
            Assert.AreEqual(1, testValue);

            string testWhile = "while";
            testValue = _CycComTest.CountKeyword(testCode, testWhile);
            Assert.AreEqual(1, testValue);

            string testFor = "for";
            testValue = _CycComTest.CountKeyword(testCode, testFor);
            Assert.AreEqual(1, testValue);

            string testAnd = " and ";
            testValue = _CycComTest.CountKeyword(testCode, testAnd);
            Assert.AreEqual(1, testValue);

            string testOr = " or ";
            testValue = _CycComTest.CountKeyword(testCode, testOr);
            Assert.AreEqual(1, testValue);

            string testDef = "def";
            testValue = _CycComTest.CountKeyword(testCode, testDef);
            Assert.AreEqual(1, testValue);

        }
        [TestMethod]
        public void TestCalculateCyclomaticComplexity()
        {
            int testValue = _CycComTest.CalculateCyclomaticComplexity();
            Assert.AreEqual(0, testValue);
        }

        [TestMethod]
        public void TestShowRisk()
        {
            _CycComTest.ShowRisk(0);
            _CycComTest.ShowRisk(10);
            _CycComTest.ShowRisk(20);
            _CycComTest.ShowRisk(40);
            _CycComTest.ShowRisk(50);
            Console.WriteLine("It worked smoothly with limit values");
        }

    }
}
