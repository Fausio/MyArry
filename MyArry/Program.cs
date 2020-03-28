using System;
using System.Collections.Generic;

namespace MyArry
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Simple int arry
            //int[] arry = new int[5];
            //arry[0] = 56;
            //arry[1] = arry[2] = 78;
            //arry[3] = arry[0] + arry[1];

            //Console.WriteLine("Add the value of array cell[4]");
            //arry[4] = int.Parse(Console.ReadLine());


            //for (int i = 0; i < arry.Length; i++)
            //{
            //    Console.WriteLine("Array in cel {0} have value: " + arry[i].ToString(), i);
            //}
            #endregion
            #region adding value in simple array
            //int[] arry = new int[5];

            //Console.WriteLine("Add the value of array cells[0] and cell[4] ");


            //for (int i = 0; i < arry.Length; i++)
            //{
            //    Console.WriteLine("Add the value of array cells[{0}] ", i);
            //    arry[i] = int.Parse(Console.ReadLine());
            //}

            //Array.Sort(arry);
            //Console.WriteLine("________Array.Sort(arry)__________");
            //foreach (var item in arry)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Reverse(arry);
            //Console.WriteLine("________Array.Reverse(arry);________");
            //foreach (var item in arry)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("________Array.IndexOf(arry, 0)________");
            //Console.WriteLine(Array.IndexOf(arry, 0));

            #endregion
            #region Two-dimensional array

            //int[,] arrayBi = new int[2,3];

            //Console.WriteLine("Add the velue of the Two-dimensional array");


            //arrayBi[0, 0] = 4;
            //arrayBi[0, 1] = 65;
            //arrayBi[0, 2] = 6;

            //arrayBi[1, 0] = 3;
            //arrayBi[1, 1] = 67;
            //arrayBi[1, 2] = 2;



            // for (int i = 0; i < 2 ; i++)
            // {
            //     for (int j = 0; j < 3; j++)
            //     {
            //         Console.WriteLine("Two-dimensional array[{0},{1}] = "+arrayBi[i, j],i,j);
            //     }
            // }
            #endregion
            #region insert values in two-dimensional array
            int[,] arrayBi = new int[2, 3];

            Console.WriteLine("Add the velue of the Two-dimensional array");


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Adding value in array [{0},{1}]", i, j);
                    arrayBi[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("The result of value in array [{0},{1}] is :" + arrayBi[i,j] , i, j);

                }
            }


            #endregion

            Console.ReadKey();

        }
    }
}
