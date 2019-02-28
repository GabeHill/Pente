﻿using System;
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

            string res = g.PrintBoard();

            string expected = "   a b c d e f g h i j k l m n o p q r s\n1 + + + + + + + + + + + + + + + + + + +\n2 + + + + + + + + + + + + + + + + + + +\n3 + + + + + + + + + + + + + + + + + + +\n4 + + + + + + + + + + + + + + + + + + +\n5 + + + + + + + + + + + + + + + + + + +\n6 + + + + + + + + + + + + + + + + + + +\n7 + + + + + + + + + + + + + + + + + + +\n8 + + + + + + + + + + + + + + + + + + +\n9 + + + + + + + + + + + + + + + + + + +\n10 + + + + + + + + + + + + + + + + + + +\n11 + + + + + + + + + + + + + + + + + + +\n12 + + + + + + + + + + + + + + + + + + +\n13 + + + + + + + + + + + + + + + + + + +\n14 + + + + + + + + + + + + + + + + + + +\n15 + + + + + + + + + + + + + + + + + + +\n16 + + + + + + + + + + + + + + + + + + +\n17 + + + + + + + + + + + + + + + + + + +\n18 + + + + + + + + + + + + + + + + + + +\n19 + + + + + + + + + + + + + + + + + + +";

            Assert.AreEqual(res, expected);
        }


        [TestMethod]
        public void TestPlacePiece0_0()
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
        public void TestPlacePiece18_0()
        {
            Game g = new Game();

            string test = "++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 0, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_1()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 1, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_1()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 1, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_2()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 2, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_2()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 2, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_3()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 3, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_3()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 3, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_4()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 4, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_4()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 4, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_5()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 5, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_5()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 5, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_6()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 6, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_6()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 6, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_7()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 7, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_7()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 7, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_8()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 8, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_8()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 8, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_9()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 9, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_9()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 9, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_10()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 10, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_10()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 10, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_11()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 11, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_11()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 11, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_12()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 12, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_12()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 12, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_13()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 13, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_13()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 13, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_14()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 14, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_14()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 14, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_15()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 15, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_15()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 15, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_16()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 16, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_16()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 16, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_17()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 17, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_17()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++";

            char[][] res = g.PlacePiece(18, 17, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }

        public void TestPlacePiece0_18()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++";

            char[][] res = g.PlacePiece(0, 18, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
        }
        public void TestPlacePiece18_18()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b";

            char[][] res = g.PlacePiece(18, 18, 'b'); //[x][y][piece color]

            string[] stringArr = test.Split('\n');

            char[][] expected = new char[stringArr.Length][];

            for (int i = 0; i < stringArr.Length; i++)
            {
                expected[i] = stringArr[i].ToCharArray();
            }

            Assert.AreEqual(res, expected);
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
