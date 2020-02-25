using System;

namespace assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {80, 1, 56, 78, 45, 21, 69, 81, 55, 83, 32, 15};
            Console.WriteLine("2nd largest number in given 1D array is: " + get_largest(numbers));
        }

        static int get_largest(int[] array){

            int largest = array[0];
            int second_largest = array[0];

            foreach(int item in array){

                if(item > largest){

                    second_largest = largest;
                    largest = item;
                }
            }

            return second_largest;
        }
    }
}
