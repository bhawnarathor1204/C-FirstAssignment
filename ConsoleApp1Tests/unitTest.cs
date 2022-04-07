using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class unitTest
    {
        [TestMethod()]
        public void GetReverseStringTest()
        {
            Reverse reverse = new Reverse();
            Assert.AreEqual("anwahb",reverse.GetReverseString("bhawna"));

        }
        [TestMethod()]
        public void testPrimeNumber()
        {
            PrimeOrNot primeNumber = new PrimeOrNot();
            Assert.AreEqual(true, primeNumber.isPrime(13));
        }
        [TestMethod()]
        public void testSumOfNNumber()
        {
            SumOfNNumber sumOfNNumber = new SumOfNNumber();
            Assert.AreEqual(15, sumOfNNumber.sumOfNumber(5));
               
        }
        [TestMethod()]
        public void testCheckAnagram()
        {
            CheckAnagram checkAnagram=new CheckAnagram();
            Assert.AreEqual(true, checkAnagram.isAnagram("ant","nat"));

        }
        [TestMethod()]
        public void testTwoSumProblem()
        {
            TwoSumProblem problem=new TwoSumProblem();
            int[] a = { 1, 2, 3, 4, 5, 6 };
            Assert.AreEqual(true, problem.twoSum(a,7));

        }

        [TestMethod()]
        public void testFactorial()
        {
            Factorial factorial = new Factorial();
            Assert.AreEqual(120, factorial.getFactorial(5));

        }

    }
}