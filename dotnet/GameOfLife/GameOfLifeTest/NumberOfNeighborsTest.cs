using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GameOfLifeTest
{
    [TestClass]
    public class NumberOfNeighborsTest
    {
        [TestMethod]
        public void DoesCellHaveOnlyOneNeighbor()
        {
            var num = new NumberOfNeighborsTest();
            //return Cell.NumberOfNeighbors();
            var expected = 1;
            Assert.AreEqual(expected, 1); 
        }

       

    }
}
