using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var exercice = 31;

            switch (exercice)
            {
                case 29:
                    #region 29 Pascal Triangle
                    Console.WriteLine(GetValueInTriangle(0, 0));
                    Console.WriteLine(GetValueInTriangle(50, 50));
                    Console.WriteLine(GetValueInTriangle(0, 0));
                    //Console.WriteLine(GetValueInTriangle(67, 34));
                    #endregion
                    break;
                case 31:
                    #region 31 Nodes
                    // Good in orders
                    int[] fromIds = { 1, 7, 3, 4, 2, 6, 9 };
                    int[] toIds = { 3, 3, 4, 6, 6, 9, 5 };

                    // Good but with other orders
                    //int[] fromIds = { 6, 2, 7, 3, 4, 9, 1 };
                    //int[] toIds =   { 9, 6, 3, 4, 6, 5, 3 };

                    //// Loop 1 returns
                    //int[] fromIds = { 1, 7, 3, 4, 2, 6, 9, 5 };
                    //int[] toIds =   { 3, 3, 4, 6, 6, 9, 5, 4 };

                    //// Loop 2 returns 4
                    //int[] fromIds = { 1, 7, 3, 4, 2, 6, 9 };
                    //int[] toIds =   { 3, 3, 4, 1, 6, 9, 5 };

                    //// Loop 3 returns 7
                    //int[] fromIds = { 1, 7, 3, 4, 2, 6, 9 };
                    //int[] toIds =   { 3, 3, 4, 7, 6, 9, 5 };

                    int startNodeId = 1;

                    Console.WriteLine(FindNetworkEndpoint(startNodeId, fromIds, toIds));
                    #endregion
                    break;
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

                    var listTest = new int[] { 8, 15, 16, 7, 9, 13 };

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
                    for (int i = 0; i < rands.Length; i++)
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
                case 38:
                    #region 38 Pairs Chess Tournament
                    Console.WriteLine(CountPairs(4));
                    Console.WriteLine(CountPairs(10000));
                    #endregion
                    break;
                case 601:
                    #region 601 Count Numbers In Array
                    int[] array = { 0, 1, 2, 3, 4, 5, 3 };
                    Console.WriteLine(CountNumbersInArray(array, 0, 1)); // 1
                    Console.WriteLine(CountNumbersInArray(array, 0, 5)); // 15
                    Console.WriteLine(CountNumbersInArray(array, 0, 0)); // 0
                    Console.WriteLine(CountNumbersInArray(array, 0, 6)); // 18
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
                case 1000:
                    CodeResult.Demo();
                    break;
                default:
                    break;
            }

            Console.Read();
        }

        #region 29 Pascal Triangle

        public static ulong GetValueInTriangle(int l, int c)
        {
            var values = new List<ulong>();
            values.Add(1); // Add value base
            values.Add(1); // Add value second turn

            // Optimize : the values we knows result is 1 (one) whatever are c and l
            if (c - l == 0)
                return 1;

            // Optimize : the value we knows equal "l" (l argument)
            if (c == 1 || l - c == 1)
                return Convert.ToUInt64(l);

            // Count the line values and if l equals actual line return the value for c
            for (int i = 1; i <= Int32.MaxValue; i++)
            {
                if (i == l)
                    return values[c];

                //for (int j = 0; j < i; j += 1)
                //{
                //    Console.Write($" {values[j]}");
                //}

                for (int j = i; j > 0; j--)
                {
                    values[j] += values[j - 1];
                }

                values.Add(1);
            }

            return 0;
        }

        #endregion

        #region 31 Nodes

        public static int FindNetworkEndpoint(int startNodeId, int[] fromIds, int[] toIds)
        {
            var dictionnaryNodes = new Dictionary<int, int>();
            var visitedNodes = new HashSet<int>();

            for (int i = 0; i < fromIds.Length; i++)
            {
                dictionnaryNodes.Add(fromIds[i], toIds[i]);
            }

            //getNode(startNodeId);
            var node = startNodeId;
            int nodeOut;

            while (dictionnaryNodes.TryGetValue(node, out nodeOut))
            {
                if (visitedNodes.Contains(nodeOut))
                    break;

                visitedNodes.Add(node);
                node = nodeOut;
            }

            return node;
        }

        private static int? getNode(int nodeId)
        {
            

            return null;
        }

        #endregion

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
                    //if ((point.x * point.x) + (point.y * point.y) <= 1)
                    if ((Math.Pow(point.x, 2)) + (Math.Pow(point.y, 2)) <= 1)
                        insidePoint++;
                }

                // insidePoint / total * 4 = Pi
                return insidePoint / pts.Length * 4;
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

        #region 38 Pairs Chess Tournament
        public static int CountPairs(int players)
        {
            var result = (players - 1) * players / 2;

            return result;
        }
        #endregion

        #region 601 Count Numbers In Array
        public static int CountNumbersInArray(int[] array, int n1, int n2)
        {
            int result = 0;

            for (int i = n1; i<= n2; i++)
            {
                result += array[i];
            }

            return result;
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
