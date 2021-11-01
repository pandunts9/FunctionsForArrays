using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two-dimensional array and print
            //Client1
            Console.WriteLine("Write please the height and the width you want to create array!");
            int height1 = Convert.ToInt32(Console.ReadLine());
            int width1 = Convert.ToInt32(Console.ReadLine());
            int[,] myArr = CreateArr(height1, width1);
            Print(myArr);
            //Find maximum element of given array and print
            //Client2
            Console.WriteLine("Write please the height and the width you want to create array, to find maximum!");
            int height2 = Convert.ToInt32(Console.ReadLine());
            int width2 = Convert.ToInt32(Console.ReadLine());
            int[,] arr2 = CreateArr(height2, width2);
            Print(arr2);
            Console.WriteLine();
            int max = GetMax(arr2);
            Print(max);
            //Find min element of given array and print
            //Client3
            Console.WriteLine("Write please the height and the width you want to create array, to find minimum!");
            int height3 = Convert.ToInt32(Console.ReadLine());
            int width3 = Convert.ToInt32(Console.ReadLine());
            int[,] arr3 = CreateArr(height3, width3);
            Print(arr3);
            Print(GetMin(arr3));
            //FInd minimum element of given array and print
            //Clienet4
            Console.WriteLine("Write please the size you want to create array,to finde minimum!");
            int size4 = Convert.ToInt32(Console.ReadLine());
            int[] arr4 = CreateArr(size4);
            Print(arr4);
            Print(GetMin(arr4));
            //Find the diagonal of given array, find the place of max element of the same array and
            // print array,diagonal and ID of max element
            //Client5
            Console.WriteLine("Write please the height and the width you want to create array,to find diagonal and max element ID!");
            int height5 = Convert.ToInt32(Console.ReadLine());
            int width5 = Convert.ToInt32(Console.ReadLine());
            int[,] arr5 = CreateArr(height5, width5);
            Print(arr5);
            Console.WriteLine();
            int[] diagonal = GetDiagonal(arr5);
            Print(diagonal);
            Console.WriteLine();
            int[] maxId = GetMaxID(arr5);
            Print(maxId);
            //Swap max and min of given array
            //Client6
            Console.WriteLine("Write please the height and the width you want to create array,for swaping max and min elements!");
            int height6 = Convert.ToInt32(Console.ReadLine());
            int width6 = Convert.ToInt32(Console.ReadLine());
            int[,] arr6 = CreateArr(height6, width6);
            Print(arr6);
            Console.WriteLine();
            Print(GetMax(arr6));
            Print(GetMin(arr6));
            Console.WriteLine();
            Swap(arr6, GetMaxID(arr6), GetMinID(arr6));
            Console.WriteLine();
            Print(arr6);
            //Find the Id of minimum element of given array and print them
            //Client7
            Console.WriteLine("Write please thes size you want to create array for finding min element Id!");
            int size7 = Convert.ToInt32(Console.ReadLine());
            int[] arr7 = CreateArr(size7);
            Print(arr7);
            Print(GetMinID(arr7));
        }
        /// <summary>
        /// Creates array with given height and width of random numbers from 0 to 10 
        /// </summary>
        /// <param name="height">given any Int32 value</param>
        /// <param name="width">given any Int32 value </param>
        /// <returns>Returnes two-diimensional array of Int32 values</returns>
        public static int[,] CreateArr(int height, int width)
        {
            Random rnd = new Random();
            int[,] arr = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    arr[i, j] = rnd.Next(10);
                }
            }
            return arr;
        }
        /// <summary>
        /// Creates array of given size of random numbers from 0-10
        /// </summary>
        /// <param name="size">given any Int32 value</param>
        /// <returns>Returnes array of Int32 values </returns>
        public static int[] CreateArr(int size)
        {
            Random rnd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10);
            }
            return array;
        }
        /// <summary>
        /// findes maximum  element of given Two-Dimensional array
        /// </summary>
        /// <param name="arr">given any array of Int32</param>
        /// <returns>Returns max element of given array</returns>
        public static int GetMax(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                        max = arr[i, j];
                }
            }
            return max;
        }
        /// <summary>
        /// Findes minmum element of given  Two-Dimensional array
        /// </summary>
        /// <param name="arr">given any array of Int32</param>
        /// <returns>Returnes min  element of given array</returns>
        public static int GetMin(int[,] arr)
        {
            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                        min = arr[i, j];
                }
            }
            return min;
        }
        /// <summary>
        /// findes maximum  element of given  array
        /// </summary>
        /// <param name="arr">given any array of Int32</param>
        /// <returns>Returnes maximum element of given array</returns>
        public static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        /// <summary>
        /// FInds minimum element of given array
        /// </summary>
        /// <param name="arr">given any array of Int32</param>
        /// <returns>Returnes minimum element of given array</returns>
        public static int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
        /// <summary>
        /// Findes diagonal form left-right of given array
        /// </summary>
        /// <param name="arr">Given any array of Int32</param>
        /// <returns>Returnes diagonal L-R</returns>
        public static int[] GetDiagonal(int[,] arr)
        {
            int[] diagonal = new int[arr.GetLength(0)];
            if (arr.GetLength(0) == arr.GetLength(1))
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {

                    diagonal[i] = arr[i, i];

                }
            }
            return diagonal;
        }
        /// <summary>
        /// Findes diagonal form right-left of given array
        /// </summary>
        /// <param name="arr">Given any array of Int32</param>
        /// <returns>Returnes diagonal R-L</returns>
        public static int[] GetDiagonalRL(int[,] arr)
        {
            int[] diagonal = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = arr[i, arr.GetLength(0) - 1]; j < arr.GetLength(1); j--)
                {
                    diagonal[i] = arr[i, j];
                }
            }
            return diagonal;
        }
        /// <summary>
        /// Finds the ID of maximum element of given array
        /// </summary>
        /// <param name="arr">Given array of Int32 </param>
        /// <returns>Returnes array(the ID of maximum element of given array)</returns>
        public static int[] GetMaxID(int[,] arr)
        {
            int idX = 0;
            int idY = 0;
            int max = arr[0, 0];
            int[] coordinates = new int[2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        idX = i;
                        idY = j;
                    }
                }
            }
            coordinates[0] = idX;
            coordinates[1] = idY;
            return coordinates;
        }
        /// <summary>
        /// Findes the ID of maximum element of given array
        /// </summary>
        /// <param name="arr">Given Int32 array</param>
        /// <returns>Returnes value Int32</returns>
        public static int GetMaxID(int[] arr)
        {
            int max = arr[0];
            int id = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    id = i;
                }
            }
            return id;
        }
        /// <summary>
        /// Findes the ID of minimum element of given array
        /// </summary>
        /// <param name="arr">Given Int32 array</param>
        /// <returns>Returnes Int32 value</returns>
        public static int GetMinID(int[] arr)
        {
            int min = arr[0];
            int id = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    id = i;
                }
            }
            return id;
        }
        /// <summary>
        /// FIndes the ID of minimum element of given array
        /// </summary>
        /// <param name="arr">Given array of Int32</param>
        /// <returns>Returnes array(the Id of minimum element of given array)</returns>
        public static int[] GetMinID(int[,] arr)
        {
            int idX = 0;
            int idY = 0;
            int min = arr[0, 0];
            int[] coordinates = new int[2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        idX = i;
                        idY = j;
                    }
                }
            }
            coordinates[0] = idX;
            coordinates[1] = idY;
            return coordinates;
        }
        /// <summary>
        /// Prints given two-dimensional array elements
        /// </summary>
        /// <param name="array">Given any array of Int32</param>
        public static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Prints given array elements
        /// </summary>
        /// <param name="arr">Given any array of Int32</param>
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
        /// <summary>
        /// Prints given value
        /// </summary>
        /// <param name="value">Given Int32 value</param>
        public static void Print(int value)
        {
            Console.WriteLine(value);
        }
        /// <summary>
        ///  Swaps given two elements of given two-dimensional array
        /// </summary>
        /// <param name="arr">given two-dimensional arary of Int32</param>
        /// <param name="coord1">given arary for first element coordinates (length is 2)</param>
        /// <param name="coord2">given arary for secondelement coordinates (length is 2)</param>
        public static void Swap(int[,] arr, int[] coord1, int[] coord2)
        {
            int temp;
            temp = arr[coord1[0], coord1[1]];
            arr[coord1[0], coord1[1]] = arr[coord2[0], coord2[1]];
            arr[coord2[0], coord2[1]] = temp;
        }
        /// <summary>
        /// Swaps given elements of array
        /// </summary>
        /// <param name="arr">given array of Int32</param>
        /// <param name="coord1">given Int32 value for first  element</param>
        /// <param name="coord2">given Int32 value for second element</param>
        public static void Swap(int[] arr, int coord1, int coord2)
        {
            int temp;
            temp = arr[coord1];
            arr[coord1] = arr[coord2];
            arr[coord2] = temp;
        }

    }
}
