using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LateLads;
using NUnit.Framework;

namespace LateLadsTest
{
    [TestFixture]
    public class Class1
    {
        static float myExpectedResult;
        static Program p1;
        
        [SetUp]
        public static void Init()
        {
            p1 = new Program();
        }



        [Test]
        public static void Premium_For_Male1()
        {
            // Arrange, Act, Assert
            myExpectedResult = 0.0f;
            float actualResult = p1.CalcPremium(16, "male");

            Assert.AreEqual(myExpectedResult, actualResult);
        }
        [Test]
        public static void Premium_For_Male2()
        {
            // Arrange, Act, Assert
            myExpectedResult = 6.0f;
            float actualResult = p1.CalcPremium(20, "male");

            Assert.AreEqual(myExpectedResult, actualResult);
        }
        [Test]
        public static void Premium_For_Male3()
        {
            // Arrange, Act, Assert
            myExpectedResult = 5.0f;
            float actualResult = p1.CalcPremium(36, "male");

            Assert.AreEqual(myExpectedResult, actualResult);
        }
        [Test]
        public static void Premium_For_Male4()
        {
            // Arrange, Act, Assert
            myExpectedResult = 2.5f;
            float actualResult = p1.CalcPremium(51, "male");

            Assert.AreEqual(myExpectedResult, actualResult);
        }
        [Test]
        public static void Premium_For_Female1()
        {
            // Arrange, Act, Assert
            myExpectedResult = 0.0f;
            float actualResult = p1.CalcPremium(12, "female");
            Assert.AreEqual(myExpectedResult, actualResult);
        }
        [Test]
        public static void Premium_For_Female2()
        {
            // Arrange, Act, Assert
            myExpectedResult = 5.0f;
            float actualResult = p1.CalcPremium(26, "female");
            Assert.AreEqual(myExpectedResult, actualResult);
        }
        [Test]
        public static void Premium_For_Female3()
        {
            // Arrange, Act, Assert
            myExpectedResult = 3.5f;
            float actualResult = p1.CalcPremium(35, "female");
            Assert.AreEqual(myExpectedResult, actualResult);
        }
        [Test]
        public static void Premium_For_Female4()
        {
            // Arrange, Act, Assert
            myExpectedResult = 1.75f;
            float actualResult = p1.CalcPremium(90, "female");
            Assert.AreEqual(myExpectedResult, actualResult);
        }

        [Test]
        public static void Premium_Error()
        {
            // Arrange, Act, Assert
            myExpectedResult = 0.0f;
            float actualResult = p1.CalcPremium(20, "femla");
            Assert.AreEqual(myExpectedResult, actualResult);
        }
    }
}
