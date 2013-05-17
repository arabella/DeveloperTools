using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixWalk.Tests
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void TestChangeDirectionTopLeftDiagonal()
        {
            int dx = 1;
            int dy = 1;
            Matrix.ChangeDirection(ref dx, ref dy);
            Assert.AreEqual(1, dx);
            Assert.AreEqual(0, dy);
        }

        [TestMethod]
        public void TestChangeDirectionLeftDiagonal()
        {
            int dx = 1;
            int dy = 0;
            Matrix.ChangeDirection(ref dx, ref dy);
            Assert.AreEqual(1, dx);
            Assert.AreEqual(-1, dy);
        }

        [TestMethod]
        public void TestChangeDirectionLeftBottomDiagonal()
        {
            int dx = 1;
            int dy = -1;
            Matrix.ChangeDirection(ref dx, ref dy);
            Assert.AreEqual(0, dx);
            Assert.AreEqual(-1, dy);
        }

        [TestMethod]
        public void TestChangeDirectionRightTopDiagonal()
        {
            int dx = -1;
            int dy = 1;
            Matrix.ChangeDirection(ref dx, ref dy);
            Assert.AreEqual(0, dx);
            Assert.AreEqual(1, dy);
        }

        [TestMethod]
        public void TestChangeDirectionRightDiagonal()
        {
            int dx = -1;
            int dy = 0;
            Matrix.ChangeDirection(ref dx, ref dy);
            Assert.AreEqual(-1, dx);
            Assert.AreEqual(1, dy);
        }

        [TestMethod]
        public void TestChangeDirectionRightBottomDiagonal()
        {
            int dx = -1;
            int dy = -1;
            Matrix.ChangeDirection(ref dx, ref dy);
            Assert.AreEqual(-1, dx);
            Assert.AreEqual(0, dy);
        }

        [TestMethod]
        public void IsTrappedTrueTest()
        {
            int x = 1;
            int y = 1;
            int[,] matrix = new int[4, 4] 
            {
                {1, 10, 11, 12},
                {9, 2, 15, 13},
                {8, 3, 3, 14},
                {7, 6, 5, 4}
            };
            Assert.IsTrue(Matrix.IsTrapped(matrix, x, y));
        }

        [TestMethod]
        public void IsTrappedFalseTest()
        {
            int x = 1;
            int y = 1;
            int[,] matrix = new int[4, 4] 
            {
                {1, 10, 11, 12},
                {9, 0, 0, 13},
                {8, 3, 3, 14},
                {7, 6, 5, 4}
            };
            Assert.IsFalse(Matrix.IsTrapped(matrix, x, y));
        }

        [TestMethod]
        public void IsTrappedAllFalseTest()
        {
            int x = 1;
            int y = 1;
            int[,] matrix = new int[4, 4] 
            {
                {1, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 0}
            };
            Assert.IsFalse(Matrix.IsTrapped(matrix, x, y));
        }

        [TestMethod]
        public void IsNotVisitedFalseTest()
        {
            int x = 1;
            int y = 1;
            int[,] matrix = new int[4, 4] 
            {
                {1, 10, 11, 12},
                {9, 2, 15, 13},
                {8, 3, 3, 14},
                {7, 6, 5, 4}
            };
            Assert.IsFalse(Matrix.IsNotVisited(matrix, out x,out y));
        }

        [TestMethod]
        public void IsNotVisitedTrueTest()
        {
            int x = 2;
            int y = 1;
            int[,] matrix = new int[4, 4] 
            {
                {1, 10, 11, 12},
                {9, 2, 0, 13},
                {8, 3, 3, 14},
                {7, 6, 5, 4}
            };
            Assert.IsTrue(Matrix.IsNotVisited(matrix, out x, out y));
        }

        [TestMethod]
        public void IsNotVisitedTrueEmptyMatrixTest()
        {
            int x = 2;
            int y = 1;
            int[,] matrix = new int[4, 4] 
            {
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 0}
            };
            Assert.IsTrue(Matrix.IsNotVisited(matrix, out x, out y));
        }
    }
}
