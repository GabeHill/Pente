using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PenteTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrintBoard()
        {
            Game g = new Game();

            string res = g.PrintBoard();

            string expected = "   a b c d e f g h i j k l m n o p q r s\n1 + + + + + + + + + + + + + + + + + + +\n2 + + + + + + + + + + + + + + + + + + +\n3 + + + + + + + + + + + + + + + + + + +\n4 + + + + + + + + + + + + + + + + + + +\n5 + + + + + + + + + + + + + + + + + + +\n6 + + + + + + + + + + + + + + + + + + +\n7 + + + + + + + + + + + + + + + + + + +\n8 + + + + + + + + + + + + + + + + + + +\n9 + + + + + + + + + + + + + + + + + + +\n10 + + + + + + + + + + + + + + + + + + +\n11 + + + + + + + + + + + + + + + + + + +\n12 + + + + + + + + + + + + + + + + + + +\n13 + + + + + + + + + + + + + + + + + + +\n14 + + + + + + + + + + + + + + + + + + +\n15 + + + + + + + + + + + + + + + + + + +\n16 + + + + + + + + + + + + + + + + + + +\n17 + + + + + + + + + + + + + + + + + + +\n18 + + + + + + + + + + + + + + + + + + +\n19 + + + + + + + + + + + + + + + + + + +";

            Assert.AreEqual(res, expected);
        }


        [TestMethod]
        public void TestPlacePiece()
        {
            Game g = new Game();

            string test = "b++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 0, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++) {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        [TestMethod]
        public void TestCapturePair()
        {

        }
        [TestMethod]
        public void TestWinCheckt()
        {

        }
    }
}
