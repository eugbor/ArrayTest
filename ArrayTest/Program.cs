using System;
using System.Linq;
/// <summary>
/// Сложение двух многозначных чисел.
/// Заполнение массива случайными числами.
/// Вывод массива на консоль (4 способа).
/// Полиморфизм.
/// </summary>
namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {   
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            
            byte[] aByte;
            byte[] bByte;
            aByte = new byte[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                aByte[a.Length - i - 1] = byte.Parse(a[i].ToString());
            }
            bByte = new byte[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                bByte[b.Length - i - 1] = byte.Parse(b[i].ToString());
            }

            byte min = 0;
            byte max = 0;
            byte[] maxArray;
            if (aByte.Length < bByte.Length)
            {
                min = (byte) aByte.Length;
                max = (byte) bByte.Length;
                maxArray = bByte;
            }
            else
            {
                min = (byte) bByte.Length;
                max = (byte) aByte.Length;
                maxArray = aByte;
            }
            
            var c = new byte[max + 1];
            
            for (int i = 0; i < min; i++)
            {
                c[i] +=(byte)(aByte[i] + bByte[i]);
                c[i + 1] = (byte) (c[i]/10);
                c[i] = (byte)(c[i] % 10);
            }
            
            for (int i = min; i < max; i++)
            {
                c[i] += maxArray[i];
                
                c[i+1] = (byte) (c[i]/10);
                c[i] = (byte) (c[i]%10);
            }
            
            for (int i = 0; i < c.Length / 2; i++)
            {
                var p = c[i];
                c[i] = c[c.Length - 1 - i];
                c[c.Length - 1 - i] = p;
            }

            Print(c.SkipWhile(el => el == 0).ToArray()); // Печатает все кроме нулей.
            
            Console.ReadKey();

        }


        //private static void SetArray(int[] a)
        //{
        //    var r = new Random();

        //    for (int i = 0; i < a.Length; i++)
        //        a[i] = r.Next(10);

        //}

        static void Print(byte[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0}", a[i]);
            Console.WriteLine();
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
