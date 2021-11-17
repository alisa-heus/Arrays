using System;
using Calculator;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[9] { 3, 6, 5, 7, 13, 12, 9, 10, 6};
            int[] arr = ArrayTasks.BubbleSortReverse(numbers);
            

            foreach(int number in arr)
            {
                Console.WriteLine(number);
            }


            //Console.WriteLine(result);
           
            
        }
    }
}
