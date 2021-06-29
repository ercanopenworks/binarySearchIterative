using System;

namespace binarySearch
{
    class Program
    {
        private static bool binarySearchIterative(int[] arr, int search)
        {
            Array.Sort(arr);

            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + ((right - left) / 2);
                if (arr[mid] == search)
                    return true;
                else if (search < arr[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 57, 888, 444, 22, 2243, 33, 55, 66 };
            Console.Write("Enter search : ");
            int search = Convert.ToInt32(Console.ReadLine());

            bool res = binarySearchIterative(arr, search);

            Console.WriteLine(res ? $"{search} Found" : $"{search} Not found");
        }
    }
}
