using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixWalk.Tests
{
    [TestClass]
    public class MatrixPrinterTest
    {
        [TestMethod]
        public void MatrixPrintTest()
        {
            int[,] matrix = new int[4, 4] { {1, 0, 0, 0 },
                                           {0, 2, 0, 0 },
                                           {0, 0, 3, 0 },
                                           {0, 0, 0, 4 }
            };
            string matrixTostrng = "  1  0  0  0\r\n  0  2  0  0\r\n  0  0  3  0\r\n  0  0  0  4\r\n";
            StringBuilder sb = new StringBuilder();
            Console.SetOut(new System.IO.StringWriter(sb));
            MatrixPrinter.PrintMatrix(matrix);
            Assert.AreEqual(matrixTostrng, sb.ToString());
        }
    }
}
