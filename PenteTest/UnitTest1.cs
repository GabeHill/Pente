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

            string test = "B++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 0, 'B'); //[x,y,piece color]

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

            string test = "++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 0, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 1, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 1, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 2, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 2, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 3, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 3, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 4, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 4, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 5, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 5, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 6, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 6, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 7, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 7, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 8, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 8, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 9, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 9, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 10, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 10, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 11, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 11, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 12, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 12, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 13, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 13, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 14, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 14, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 15, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 15, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 16, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 16, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 17, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 17, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++";

            char[,] res = g.placePiece('a', 18, 'B'); //[x,y,piece color]

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

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B";

            char[,] res = g.placePiece('s', 18, 'B'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);


        }

        [TestMethod]
        public void TestPlacePiece0_0_w()
        {
            Game g = new Game();

            string test = "B++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 0, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }


            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_0_w()
        {
            Game g = new Game();

            string test = "++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 0, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_1_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 1, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_1_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 1, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_2_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 2, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_2_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 2, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_3_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 3, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_3_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 3, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_4_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 4, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_4_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 4, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_5_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 5, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_5_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 5, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_6_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 6, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_6_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 6, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_7_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 7, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_7_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 7, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_8_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 8, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_8_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 8, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_9_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 9, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_9_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 9, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_10_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 10, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_10_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 10, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_11_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 11, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_11_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 11, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_12_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 12, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_12_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 12, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_13_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 13, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_13_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 13, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_14_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 14, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_14_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 14, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_15_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 15, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_15_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 15, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_16_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 16, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_16_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 16, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_17_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++\n+++++++++++++++++++";

            char[,] res = g.placePiece('a', 17, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_17_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B\n+++++++++++++++++++";

            char[,] res = g.placePiece('s', 17, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece0_18_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\nB++++++++++++++++++";

            char[,] res = g.placePiece('a', 18, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void TestPlacePiece18_18_w()
        {
            Game g = new Game();

            string test = "+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n+++++++++++++++++++\n++++++++++++++++++B";

            char[,] res = g.placePiece('s', 18, 'W'); //[x,y,piece color]

            string[] stringArr = test.Split('\n');

            char[,] expected = new char[stringArr.Length, stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = 0; j < stringArr.Length; j++)
                {
                    expected[i, j] = stringArr[i].ToCharArray()[j];
                }
            }

            Assert.AreEqual(res, expected);


        }

        #endregion

        [TestMethod]
        public void TestCapturePair() {
            Game g = new Game();

            g.createBoard();
            char[,] expected = new char[19, 19];
            char[,] result = new char[19, 19];

            string expected1 = "B++B+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++";

            //expected1.Replace('\n', '\0');

            string result1 = "";

            char p1 = 'B';
            char p2 = 'W';

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    expected[i, j] = '+';
                }
            }

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    result[i, j] = '+';
                }
            }

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    result1 += result[i, j];
                }
            }

            g.capturePair('a', 0, p1);
            g.placePiece('a', 0, p1); // (column, row, player)
            g.capturePair('b', 0, p2);
            g.placePiece('b', 0, p2); // (column, row, player)
            g.capturePair('c', 0, p2);
            g.placePiece('c', 0, p2); // (column, row, player)
            g.capturePair('d', 0, p1);
            g.placePiece('d', 0, p1); // (column, row, player)

            string res = "";

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    res += g.board[i, j];
                }
            }
            
            Assert.AreEqual(expected1, res);
        }

        [TestMethod]
        public void TestWinCheckt() {

        }
    }
}
