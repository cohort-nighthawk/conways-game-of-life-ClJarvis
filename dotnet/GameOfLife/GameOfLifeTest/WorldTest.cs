using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;


namespace GameOfLifeTest
{
    [TestClass]
    public class WorldTest
    {
        [TestMethod]
        public void TestWorldHeight()
        {
            World World = new World();
            Assert.AreEqual(World.WorldHeight, 10);
            Assert.AreEqual(World.WorldWidth, 10);

        }

    }
}
