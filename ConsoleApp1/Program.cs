﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            var exercice = 35;

            switch (exercice)
            {
                case 32:
                    #region 32 Closest To Zero
                    Console.WriteLine(ClosestToZero(new int[] { 12, 30, 11, 99, 5, 10 })); // 5
                    Console.WriteLine(ClosestToZero(new int[] { 12, 30, 11, 99, -5, 10 })); // -5
                    Console.WriteLine(ClosestToZero(new int[] { -12, 30, -11, 99, 5, -4, 65, 4, 16 })); //4
                    Console.WriteLine(ClosestToZero(new int[] { -12, 30, -11, 99, 5, 4, 65, -4, 16 })); //4
                    #endregion
                    break;
                case 33:
                    #region 33 Tree Exercice
                    Node small = new Node
                    {
                        value = 9,
                        left = new Node
                        {
                            value = 7,
                            left = new Node
                            {
                                value = 5,
                                left = new Node
                                {
                                    value = 2
                                },
                                right = new Node
                                {
                                    value = 6
                                }
                            },
                            right = new Node
                            {
                                value = 8
                            }
                        },
                        right = new Node
                        {
                            value = 13,
                            right = new Node
                            {
                                value = 17,
                                left = new Node
                                {
                                    value = 16
                                }
                            }
                        }
                    };

                    var listTest = new int[] { 8, 15, 16, 7, 9, 13};

                    foreach (var i in listTest)
                    {
                        var nodeResult = small.Find(i);
                        Console.WriteLine($"Node:[{nodeResult?.value}] \t L:[{nodeResult?.left?.value}] R:[{nodeResult?.right?.value}]");
                    }

                    Console.Read();
                    #endregion
                    break;
                case 35:
                    #region 35 Count Pi
                    var rands = new Point[100000];
                    Random random = new Random();
                    for (int i=0; i < rands.Length; i++)
                    {
                        rands[i] = new Point
                        {
                            x = random.NextDouble(),
                            y = random.NextDouble()
                        };
                    }

                    Console.WriteLine(Pi.Approx(rands));
                    #endregion
                    break;
                case 36:
                    #region 36 Ascii Exercice
                    var asciiArt = new AsciiArt();
                    Console.WriteLine("Result for A: [" + asciiArt.ScanChar(asciiArt.PrintChar('A')) + "]");
                    Console.WriteLine("Result for B: [" + asciiArt.ScanChar(asciiArt.PrintChar('B')) + "]");
                    Console.WriteLine("Result for C: [" + asciiArt.ScanChar(asciiArt.PrintChar('C')) + "]");
                    Console.WriteLine("Result for Z: [" + asciiArt.ScanChar(asciiArt.PrintChar('Z')) + "]");
                    Console.WriteLine("Result for W: [" + asciiArt.ScanChar(asciiArt.PrintChar('W')) + "]");
                    #endregion
                    break;
                case 999:
                    #region 999 Exo Simple
                    // Exercice 1
                    Console.WriteLine("Exercice 1");
                    PrintPicsou();

                    // Just put some spaces
                    Console.WriteLine("\n\n\n");

                    //Exercice 2
                    Console.WriteLine("Exercice 2");
                    var result = MultiplyMe(new List<int> { 1, 2, 5, 7 });
                    foreach (var elem in result)
                    {
                        Console.WriteLine(elem);
                    }
                    #endregion;
                    break;
                default:
                    break;
            }

            Console.Read();
        }

        #region 32 Closest To Zero

        public static int ClosestToZero(int[] numbers)
        {
            if (!numbers.Any())
                return 0;

            int result = numbers[0];
            int positiveResult = (result < 0) ? result * -1 : result;
            int positiveNumber;

            foreach(var number in numbers)
            {
                positiveNumber = (number < 0) ? number * -1 : number;

                if (positiveNumber <= positiveResult)
                {
                    if (number == -result)
                    {
                        result = positiveResult = positiveNumber;
                    }
                    else
                    {
                        result = number;
                        positiveResult = (result < 0) ? result * -1 : result;
                    }
                }
            }

            return result;
        }

        #endregion

        #region 35 Count Pi

        public class Point
        {
            public double x, y;
        }

        class Pi
        {
            public static double Approx(Point[] pts)
            {
                double insidePoint = 0;
  
                foreach(var point in pts)
                {
                    if ((point.x * point.x) + (point.y * point.y) <= 1)
                        insidePoint++;
                }

                return 4 * insidePoint / pts.Length;
            }
        }

        #endregion

        #region 36 Ascii Exercice

        public class AsciiArt
        {
            public char ScanChar(string ascii)
            {
                var listeChar = "ABCZ";
                
                foreach (char c in listeChar)
                {
                    if (PrintChar(c) == ascii)
                        return c;
                }

                return '?';
            }

            public string PrintChar(char c)
            {
                string result = null;

                switch(c)
                {
                    case 'A':
                        result =
                            " ## " +
                            "\n#  #" +
                            "\n####" +
                            "\n#  #" +
                            "\n#  #";
                        break;
                    case 'B':
                        result =
                            "### " +
                            "\n#  #" +
                            "\n###" +
                            "\n#  #" +
                            "\n### ";
                        break;
                    case 'C':
                        result =
                            " ###" +
                            "\n#   " +
                            "\n#   " +
                            "\n#   " +
                            "\n ###";
                        break;
                    case 'Z':
                        result =
                            "####" +
                            "\n   #" +
                            "\n  # " +
                            "\n #  " +
                            "\n####";
                        break;
                    case ')':
                        result =
                            "" +
                            "" +
                            "" +
                            "" +
                            "";
                        break;
                }

                return result;
            }
        }

        #endregion

        #region 33 Tree Exercice
        public class Node
        {
            public Node left, right;

            public int value;

            public Node Find(int value)
            {
                Result = null;
                Steps = 0; // Count the steps (This one is just for dev, used to optimize code)

                AnalyseTree(this, value, Result);

                Console.Write($"Test:{value}   \t Steps:[{Steps}] \t");
                return Result;
            }

            #region Private Recurcive
            private void AnalyseTree(Node node, int value, Node result)
            {
                Steps += 1;

                if (node.value == value)
                {
                    Result = node;
                    return;
                }

                if (node.left != null && Result == null)
                    AnalyseTree(node.left, value, Result);

                if (node.right != null && Result == null)
                    AnalyseTree(node.right, value, Result);
            }

            private Node Result { get; set; }

            /// <summary>
            /// not in the exercice but I added it to see process optimisation
            /// </summary>
            public int Steps { get; set; }
            #endregion
        }
        #endregion

        #region 999 Exo Simple
        /// <summary>
        /// riri fifi and loulou function
        /// </summary>
        /// 
        public static void PrintPicsou()
        {
            for (int i = 1; i <= 100; i++)
            {
                // Loulou
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Loulou");
                    continue;
                }

                // Riri
                if (i % 3 == 0)
                {
                    Console.WriteLine("Riri");
                    continue;
                }

                //// Fifi
                if (i % 5 == 0)
                {
                    Console.WriteLine("Fifi");
                    continue;
                }

                // In case of nothing print the number
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Multiply function
        /// </summary>
        /// <param name="list"></param>
        /// <returns>List of int</returns>
        public static List<int> MultiplyMe(List<int> list)
        {

            for (int i = 0; i < list.Count(); i++)
            {
                list[i] = list[i] * 2;
            }

            return list;
        }
        #endregion
    }
}