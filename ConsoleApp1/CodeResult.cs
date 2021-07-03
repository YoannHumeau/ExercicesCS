using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class CodeResult
    {
        public static void Demo()
        {
            // Result 4
            Console.WriteLine(1 << 2);

            #region Question
            // An abstract classes can contain concrete methods ?               True

            // type the operator used in lambda expression (2 char)             =>

            // which exception belong to the .Net API for C#

            // if two objects are equals then they have the same hashcode       False

            // private static class A {} ? When is it good ?                    Never ? For anonymous class ? For inner class ? Always ?

            // garbage collector ensure there is enough memory to run .net program

            // Among method declaration, wich is prefered ?                     public ArrayList GetOrders()? public IList GetOrders();

            // public unterface A : B, C, D {} - Interface is corretc if BCD are interfaces ?

            // C# strings are immutable ?                                       True

            // Among thiese primitives types exists in C#                       Boolean Byte SByte Int16 UInt16 Int32 UInt32 Int64 UInt64 IntPtr UIntPtr Char Double Single .


            //var m = new Dictionary<object, int>();
            //var o1 = new object();
            //var o2 = o1;                                                      2
            //m[o1] = 1;    
            //m[o2] = 2;
            //Console.WriteLine(m[o1]);


            //A a = new A();                                                    class B : A
            //A b = new B();

            //class A
            //{
            //    private string str;                                           str not visible from B
            //}
            //class B : A
            //{
            //}

            //var hashSet = new HashSet<int>();
            //hashSet.Add(1);
            //hashSet.Add(1);                                                   2
            //hashSet.Add(2);
            //Console.WriteLine(hashSet.Count);

            //var sd = new SortedDictionary<int, int>();
            //sd[3] = 3;
            //sd[2] = 1;                                                        2 1 3
            //sd[1] = 2;
            //foreach (var val in sd.Values)
            //    Console.WriteLine(val);

            //int i1 = 5;
            //int i2 = 2;                                                       2
            //int i3 = i1 / i2;

            #endregion
        }
    }
}
