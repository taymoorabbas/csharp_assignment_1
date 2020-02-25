using System;

namespace assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {   

            //part: 1
            int[] numbers = {80, 1, 56, 78, 45, 21, 69, 81, 55, 83, 32, 15};
            Console.WriteLine("2nd largest number in given 1D array is: " + get_largest(numbers));
            
            //part: 2
            int[][] jagged_array = new int[3][];
            jagged_array[0] = new int[]{1, 3, 5, 7, 9, 11};
            jagged_array[1] = new int[]{2, 4, 6, 8, 10, 12, 14, 16};
            jagged_array[2] = new int[]{10, 20, 30, 40, 50, 60, 70, 80, 90};

            Console.WriteLine("Sum of given jagged array is: " + get_sum(jagged_array));
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

        static double get_sum(int[][] array){

            int sum = 0;

            foreach(int[] arr in array){

                foreach(int value in arr){

                    sum += value;
                }
            }

            return sum;
        }
    }
}
