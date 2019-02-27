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
            string res = Game.PrintBoard();
            string expected = "   a b c d e f g h i j k l m n o p q r s\n1 + + + + + + + + + + + + + + + + + + +\n2 + + + + + + + + + + + + + + + + + + +\n3 + + + + + + + + + + + + + + + + + + +\n4 + + + + + + + + + + + + + + + + + + +\n5 + + + + + + + + + + + + + + + + + + +\n6 + + + + + + + + + + + + + + + + + + +\n7 + + + + + + + + + + + + + + + + + + +\n8 + + + + + + + + + + + + + + + + + + +\n9 + + + + + + + + + + + + + + + + + + +\n10 + + + + + + + + + + + + + + + + + + +\n11 + + + + + + + + + + + + + + + + + + +\n12 + + + + + + + + + + + + + + + + + + +\n13 + + + + + + + + + + + + + + + + + + +\n14 + + + + + + + + + + + + + + + + + + +\n15 + + + + + + + + + + + + + + + + + + +\n16 + + + + + + + + + + + + + + + + + + +\n17 + + + + + + + + + + + + + + + + + + +\n18 + + + + + + + + + + + + + + + + + + +\n19 + + + + + + + + + + + + + + + + + + +";

            Assert.Equals(res, expected);
        }


        [TestMethod]
        public void TestPlacePiece()
        {
            string test = "abcdefghijklmnopqrs\n1+++++++++++++++++++\n2+++++++++++++++++++\n3+++++++++++++++++++\n4+++++++++++++++++++\n5+++++++++++++++++++\n6+++++++++++++++++++\n7+++++++++++++++++++\n8+++++++++++++++++++\n9+++++++++++++++++++\n10+++++++++++++++++++\n11+++++++++++++++++++\n12+++++++++++++++++++\n13+++++++++++++++++++\n14+++++++++++++++++++\n15+++++++++++++++++++\n16+++++++++++++++++++\n17+++++++++++++++++++\n18+++++++++++++++++++\n19+++++++++++++++++++";
            char[,] res = Game.PlacePiece(0, 0, 'b'); //[x][y][piece color]
            string[] stringArr = test.Split('\n');
            char[][] expected = null;

            Assert.Equals(res, expected);
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
