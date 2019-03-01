using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PenteProject;

namespace PenteTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrintBoard()
        {
            Game g = new Game();

            string res = g.printBoard().ToString();

            string expected = "   a b c d e f g h i j k l m n o p q r s\n1 + + + + + + + + + + + + + + + + + + +\n2 + + + + + + + + + + + + + + + + + + +\n3 + + + + + + + + + + + + + + + + + + +\n4 + + + + + + + + + + + + + + + + + + +\n5 + + + + + + + + + + + + + + + + + + +\n6 + + + + + + + + + + + + + + + + + + +\n7 + + + + + + + + + + + + + + + + + + +\n8 + + + + + + + + + + + + + + + + + + +\n9 + + + + + + + + + + + + + + + + + + +\n10 + + + + + + + + + + + + + + + + + + +\n11 + + + + + + + + + + + + + + + + + + +\n12 + + + + + + + + + + + + + + + + + + +\n13 + + + + + + + + + + + + + + + + + + +\n14 + + + + + + + + + + + + + + + + + + +\n15 + + + + + + + + + + + + + + + + + + +\n16 + + + + + + + + + + + + + + + + + + +\n17 + + + + + + + + + + + + + + + + + + +\n18 + + + + + + + + + + + + + + + + + + +\n19 + + + + + + + + + + + + + + + + + + +";

            Assert.AreEqual(res, expected);
        }

        #region Test Place Piece
        [TestMethod]
        public void TestPlacePiece0_0_b()
        {
            Game g = new Game();

            string test = "b++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 0, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_0_b()
        {
            Game g = new Game();

            string test = "++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 0, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_1_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 1, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_1_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 1, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_2_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 2, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_2_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 2, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_3_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 3, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_3_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 3, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_4_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 4, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_4_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 4, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_5_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 5, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_5_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 5, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_6_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 6, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_6_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 6, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_7_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 7, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_7_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 7, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_8_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 8, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_8_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 8, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_9_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 9, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_9_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 9, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_10_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 10, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_10_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 10, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_11_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 11, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_11_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 11, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_12_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 12, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_12_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 12, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_13_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 13, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_13_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 13, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_14_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 14, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_14_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 14, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_15_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 15, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_15_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 15, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_16_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 16, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_16_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 16, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_17_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.placePiece(0, 17, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_17_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++";

            char[][] res = g.placePiece(18, 17, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_18_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++";

            char[][] res = g.placePiece(0, 18, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_18_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b";

            char[][] res = g.placePiece(18, 18, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);

        }
        #endregion
        
        [TestMethod]
        public void TestCapturePair(char col, int row, char player)
        {
            Game g = new Game();

            

        }

        [TestMethod]
        public void TestWinCheck()
        {

        }
    }
}
