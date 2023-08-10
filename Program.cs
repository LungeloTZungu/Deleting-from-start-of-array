using System;

namespace DeletingfromStartofArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int[] intArray = new int[6];
            Console.WriteLine("Original Array: ");
            for (int i = 0; i < 6; i++)
            {
                intArray[length] = i;
                length++;

            }

            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }
            // this means that one array has been populated we decrement the value length by 1 nd then we will will see that the last index has been removed 
        
            // looping with the new value for Lengnth
            for (int i = 1; i < length; i++)
            {
                intArray[i - 1] = intArray[i];
            }
            length--;

            Console.WriteLine("New Array: ");

            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }




        }
    }
}
