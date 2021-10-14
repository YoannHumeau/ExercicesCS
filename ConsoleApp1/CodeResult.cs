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

            // garbage collector ensure there is enough memory to run .net program no

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

            //Struct struct1;
            //struct1.foo = 5;

            //Struct struct2 = struct1;                                         5
            //struct2.foo = 10;

            //Console.WriteLine(struct1.foo);

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

            //Console.WriteLine($"{i}.5   => {Math.Round(i + 0.5)}");
            //1.5     => 2
            //2.5     => 2
            //3.5     => 4
            //4.5     => 4
            //5.5     => 6
            //6.5     => 6
            //7.5     => 8
            //8.5     => 8
            //9.5     => 10
            //10.5    => 10
            //11.5    => 12
            //12.5    => 12
            //13.5    => 14
            //14.5    => 14
            //15.5    => 16
            //16.5    => 16
            //17.5    => 18
            //18.5    => 18
            //19.5    => 20
            //20.5    => 20



            //public static void Main(string[] args)
            //{
            //    int[] i = new int[0];
            //    Console.WriteLine(i[0]);
            //}
            // RETURNS =>  IndexOutOfRangeException

            #endregion
        }
    }
}
