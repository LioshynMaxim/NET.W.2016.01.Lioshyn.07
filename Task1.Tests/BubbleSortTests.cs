using NUnit.Framework;
using static Task1.BubbleSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tests
{
    [TestFixture()]
    public class BubbleSortTests
    {
        public int[][] ArrForFirstTest = new[]
            {
                new []{6, -5, 3, 0, 10},
                new []{1, 2, 1, 0, 1},
                new []{0, 2, 0, 0, 30, 0},
                new []{0, 2, 0, 29, -1}
            };

        public int[][] ArrNewInts = new[]
            {
                new []{0, 2, 0, 0, 30, 0},
                new []{0, 2, 0, 29, -1},
                new []{6, -5, 3, 0, 10},
                new []{1, 2, 1, 0, 1}
            };
        [Test()]

        [TestCase()]
        public void BubbleSortAlgorithmTest()
        {
            BubbleSortAlgorithm(ArrForFirstTest, new SumUp());
            Assert.AreEqual(ArrForFirstTest, ArrNewInts);
        }
       

    }
}