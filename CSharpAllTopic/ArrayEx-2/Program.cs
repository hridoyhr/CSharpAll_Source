using System;

namespace ArrayEx_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Multidimention Array
            //int[,] n = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            //int i, j;

            //for (i = 0; i < 5; i++)
            //{
            //    for (j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine("The Element [{0}, {1}] = {2}", i, j, n[i, j]);
            //    }
            //}
            #endregion
            #region Example-1
            //int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach(var item in num)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Example-2
            //int[] a = new int[100];
            //int i, n;

            //Console.WriteLine("Input the number of elements to store in the array: ");
            //n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Input{0} number of elements in the array: ",n);
            //for(i = 0; i < n; i++)
            //{
            //    Console.Write("element -{0} = ",i);
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("The values store into the array\n");
            //for(i = 0; i < n; i++)
            //{
            //    Console.Write("{0} ",a[i]);
            //}

            //Console.WriteLine("\n\nThe values store into the array in reverse are: ");
            //for(i = n-1; i >= 0; i--)
            //{
            //    Console.Write("{0} ",a[i]);
            //}
            #endregion
            #region Sum of Array
            //int[] a = new int[100];
            //int i, n;
            //int sum = 0;

            //Console.WriteLine($"Input number stored in the array: ");
            //n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Input {0} elements in the array: ",n);
            //for(i = 0; i < n; i++)
            //{
            //    Console.Write("element - {0} : ", i);
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for(i =0; i < n; i++)
            //{
            //     sum += a[i];
            //}
            //Console.WriteLine("\n\nSum of all element = {0}   ", sum);

            #endregion

            #region Array copy
            //int[] n = new int[10];
            //int[] m = new int[9];

            //for (int i = 0; i < 10; i++)
            //    n[i] = i + 100;

            //Console.WriteLine("First array..");
            //foreach(var item in n)
            //    Console.WriteLine( item);

            //Array.Copy(n, 0, m, 0, 9);
            //Console.WriteLine("Copy from first array");
            //foreach(var item in m)
            //    Console.WriteLine(item);
            #endregion

            #region Another example Array Copy
            int[] f = new int[100];
            int[] s = new int[100];

            int i, n;

            #region another approach
            //Console.WriteLine("Input the number of array: ");
            //p = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Input {0} element inte arra: ", p);
            //for(q = 0; q < p; q++)
            //{
            //    Console.Write("Element - {0} : ",q);
            //    f[q] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("First array");
            //for(q = 0; q < p; q++)
            //    Console.WriteLine(f[q]);

            //Array.Copy(f, 0, s, 0, 10);
            //Console.WriteLine("\n\nCopy From First Array");
            //foreach(var item in s)
            //    Console.WriteLine(item);
            #endregion

            Console.WriteLine("Enter array number : ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array: ",n);
            for(i = 0; i < n; i++)
            {
                Console.Write("element-{0} = ",i);
                f[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(i = 0; i < n; i++)
            {
                s[i] = f[i];
            }

            Console.WriteLine("First array\n ");
            for(i = 0; i < n; i++)
                Console.Write("{0} ",f[i]);

            Console.WriteLine("\nCopy to First array:  ");
            for (i = 0; i < n; i++)
                Console.Write("{0} ",s[i]);

            #endregion
        }
    }
}
