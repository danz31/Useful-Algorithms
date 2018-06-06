using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        //Binary search with targeted number and index it's found at. Enter in your Array or List.  Both must be sorted, which is part of this BinarySearch method.
        public static void Main(string[] args)
        {

            int[] arr = new int[] { }; //You can use a list here instead of Array. List<var> list = new List<var>();

            Console.WriteLine("Enter the value to search");
            int key = int.Parse(Console.ReadLine()); 
            int index = BinarySearch(arr, 0, arr.Length - 1, key);
            if (index == -1)
            {
                Console.WriteLine("key not found");
            }
            else
            {
                {
                    Console.WriteLine("key {0} found at index {1}", key, index);
                }
            }
        }

        static int BinarySearch(int[] arr, int left, int right, int key)
        {
            Array.Sort(arr); //enter your list here with: list.sort(listname);


            while (left <= right)
            {
                int mid = (left + right) / 2;  //Finds the left and right limits and divides by 2 to find the middle
                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (key > arr[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

    }
}
