﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PenteProject;

namespace PenteTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestPrintBoard() {
            Game g = new Game();

            char[,] board = g.printBoard();
            string res = "";

            for (int i = 0; i < board.Length; i++) {
                for (int j = 0; j < board.Length; i++) {
                    res += board[i, j];
                }
            }


            string expected = "   a b c d e f g h i j k l m n o p q r s\n1 + + + + + + + + + + + + + + + + + + +\n2 + + + + + + + + + + + + + + + + + + +\n3 + + + + + + + + + + + + + + + + + + +\n4 + + + + + + + + + + + + + + + + + + +\n5 + + + + + + + + + + + + + + + + + + +\n6 + + + + + + + + + + + + + + + + + + +\n7 + + + + + + + + + + + + + + + + + + +\n8 + + + + + + + + + + + + + + + + + + +\n9 + + + + + + + + + + + + + + + + + + +\n10 + + + + + + + + + + + + + + + + + + +\n11 + + + + + + + + + + + + + + + + + + +\n12 + + + + + + + + + + + + + + + + + + +\n13 + + + + + + + + + + + + + + + + + + +\n14 + + + + + + + + + + + + + + + + + + +\n15 + + + + + + + + + + + + + + + + + + +\n16 + + + + + + + + + + + + + + + + + + +\n17 + + + + + + + + + + + + + + + + + + +\n18 + + + + + + + + + + + + + + + + + + +\n19 + + + + + + + + + + + + + + + + + + +";

            Assert.AreEqual(res, expected);
        }

        #region TestPlacePiece

        [TestMethod]
        public void TestPlacePiece0_0_b()
        {
            Game g = new Game();

            string test = "b++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 0, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }


            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_0_b()
        {
            Game g = new Game();

            string test = "++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 0, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_1_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 1, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_1_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 1, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_2_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 2, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_2_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 2, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_3_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 3, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_3_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 3, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_4_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 4, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_4_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 4, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_5_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 5, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_5_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 5, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_6_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 6, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_6_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 6, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_7_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 7, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_7_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 7, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_8_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 8, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_8_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 8, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_9_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 9, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_9_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 9, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_10_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 10, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_10_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 10, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_11_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 11, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_11_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 11, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_12_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 12, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_12_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 12, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_13_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 13, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_13_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 13, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_14_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 14, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_14_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 14, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_15_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 15, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_15_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 15, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_16_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 16, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_16_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 16, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_17_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 17, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_17_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 17, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_18_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nb++++++++++++++++++";

            char[,] res = g.placePiece('a', 18, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_18_b()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++b";

            char[,] res = g.placePiece('s', 18, 'b'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++) {
                for (int j = 0; j < stringArr.Length; j++) {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);



        #endregion

        [TestMethod]
        public void TestCapturePair() {

        }
        [TestMethod]
        public void TestWinCheckt() {

        }
    }
}
