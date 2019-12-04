using System;
using System.Collections.Generic;

namespace ZipArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array_one = { 1, 5, 2 };
            int [] array_two = { 3, 6, 4 };

            var zipped_array = new List<int>();
            zipped_array.AddRange(array_one);
            zipped_array.AddRange(array_two);

            Console.WriteLine(zipped_array);
            
        }
    }
}
