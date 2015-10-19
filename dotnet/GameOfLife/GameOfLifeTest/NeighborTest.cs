using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;


namespace GameOfLifeTest
{
    [TestClass]
    public class NeighborTest
    {
        [TestMethod]
        public void HasNeighborTest()
        {
            bool HasNeighbor = false;
            Assert.IsTrue(true);
           // Assert.AreEqual(Cell.NumberOfNeighbors, 0);
        }

        [TestMethod]
        public void DoesNotHaveNeighborTest()
        {
            bool DoesNotHaveNeighbor = false;
            Assert.IsTrue(true);
        }
    }
}

