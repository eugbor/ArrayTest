using System;
using System.Collections.Generic;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            char[] aArray = a.ToCharArray();
            char[] bArray = b.ToCharArray();

            if (aArray.Length > bArray.Length)
            {
                int[] fArray = new int[aArray.Length];

                for (int i = 0; i < bArray.Length / 2; i++)
                {
                    var p = bArray[i];
                    bArray[i] = bArray[bArray.Length - 1 - i];
                    bArray[bArray.Length - 1 - i] = p;
                }

                List<char> bArray3 = new List<char>(bArray);
                var c = aArray.Length - bArray.Length;
                for (int i = 0; i < c; i++)
                {
                    bArray3.Add('0');
                }
                char[] bArray2 =bArray3.ToArray();

                for (int i = 0; i < bArray2.Length / 2; i++)
                {
                    var p = bArray2[i];
                    bArray2[i] = bArray2[bArray2.Length - 1 - i];
                    bArray2[bArray2.Length - 1 - i] = p;
                }

                var t = 0;
                for (int i = fArray.Length - 1; i >= 0; i--)
                {
                    var aByte = byte.Parse(aArray[i].ToString());
                    var bByte = byte.Parse(bArray2[i].ToString());
                    var result = aByte + bByte + t;
                    if (result <= 9)
                    {
                        t = 0;
                        fArray[i] = result;
                    }
                    else if (i == 0)
                    {
                        t = 0;
                        fArray[i] = result;
                    }
                    else if (result > 9)
                    {
                        t = 0;
                        fArray[i] = result % 10;
                        t++;
                    }
                }
                Print(fArray);
            }
            else if (aArray.Length < bArray.Length)
            {
                int[] fArray = new int[bArray.Length];
                for (int i = 0; i < aArray.Length/2; i++)
                {
                    var p = aArray[i];
                    aArray[i] = aArray[aArray.Length - 1 - i];
                    aArray[aArray.Length - 1 - i] = p;
                }

                List<char> aArray3 = new List<char>(aArray);
                var c = bArray.Length - aArray.Length;
                for (int i = 0; i < c; i++)
                {
                    aArray3.Add('0');
                }
                char[] aArray2 = aArray3.ToArray();

                for (int i = 0; i < aArray2.Length/2; i++)
                {
                    var p = aArray2[i];
                    aArray2[i] = aArray2[aArray2.Length - 1 - i];
                    aArray2[aArray2.Length - 1 - i] = p;
                }

                var t = 0;
                for (int i = fArray.Length - 1; i >= 0; i--)
                {
                    var aByte = byte.Parse(aArray2[i].ToString());
                    var bByte = byte.Parse(bArray[i].ToString());
                    var result = aByte + bByte + t;
                    if (result <= 9)
                    {
                        t = 0;
                        fArray[i] = result;
                    }
                    else if (i == 0)
                    {
                        t = 0;
                        fArray[i] = result;
                    }
                    else if (result > 9)
                    {
                        t = 0;
                        fArray[i] = result % 10;
                        t++;
                    }
                }
                Print(fArray);
            }
            else
            {
                int[] fArray = new int[aArray.Length];
                var t = 0;
                for (int i = fArray.Length - 1; i >= 0; i--)
                {
                    var aByte = byte.Parse(aArray[i].ToString());
                    var bByte = byte.Parse(bArray[i].ToString());
                    var result = aByte + bByte + t;
                    if (result <= 9)
                    {
                        t = 0;
                        fArray[i] = result;
                    }
                    else if (i == 0)
                    {
                        t = 0;
                        fArray[i] = result;
                    }
                    else if (result > 9)
                    {
                        t = 0;
                        fArray[i] = result%10;
                        t++;
                    }
                }
                Print(fArray);
            }
            
    





            //int n = int.Parse(Console.ReadLine());

            //var a = new int[n];

            //SetArray(a);
            //Print(a);
            //Console.WriteLine();

            //for (int i = 0; i < n/2; i++)
            //{
            //    int b = a[i];
            //    a[i] = a[n - 1 - i];
            //    a[n - 1 - i] = b;
            //}

            //Print(a);

            //int sum = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    if (i%2 == 1)
            //        sum += a[i];
            //}

            //Console.WriteLine();
            //Console.Write(sum);

            Console.ReadKey();

        }

        
        private static void SetArray(int[] a)
        {
            var r = new Random();

            for (int i = 0; i < a.Length; i++)
                a[i] = r.Next(10);

        }

        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);

            //foreach (var item in a)
            //    Console.Write("{0} ", item);

            //Console.Write(String.Join(" ", a));

            //Console.Write(a.Aggregate(new StringBuilder(), (st, el) => st.AppendFormat("{0} ", el)));

        }

        //    static void Tmp()
        //    {
        //        ClassA a = new ClassA();
        //        a.Get(); // a.A = 1;

        //        ClassB b = new ClassB();
        //        b.Get(); //b.A = 2;

        //        a = b;
        //        a.Get(); //a.A = 4;

        //        ClassA c = new ClassB();
        //        c.Get(); // a.A = 2;

        //        ClassA[] arr = new ClassA[10];

        //        for(int i =0;i<10;i++)
        //            if (i%2 == 0)
        //                arr[i] = new ClassA();
        //            else
        //                arr[i] = new ClassB();

        //        for(int i = 0;i < 10;i++)
        //            arr[i].Get();
        //    }
        //}

        //public class ClassA
        //{
        //    public int A { get; set; }

        //    public virtual void Get()
        //    {
        //        A++;
        //    }
        //}

        //public class ClassB:ClassA
        //{
        //    public override void Get()
        //    {
        //        A += 2;
        //    }

        //    public void Print()
        //    {
        //        Get();
        //        Console.WriteLine(A);
        //    }

        //    public void Print2()
        //    {
        //        base.Get();
        //        Console.WriteLine(A);
        //    }
    }
}
