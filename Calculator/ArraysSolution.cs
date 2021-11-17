using System;

namespace Calculator
{
    static public class ArrayTasks
    {
        public static int FindMinimum(int[] arr)
        {
            int min = arr[0];
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }

            return min;
        }
        
        public static int FindMaximum(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public static int FindIndexOfMinimum(int[] arr)
        {
            int minIndex = 0;
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static int FindIndexOfMaximum(int[] arr)
        {
            int maxIndex = 0;
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public static int SumNumbersOfOddIndices(int[] arr)
        {
            int sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if(i%2 != 0)
                {
                    sum = sum + arr[i];
                }
            }

            return sum;
        }

        public static int[] ReverseArray(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            int j = 0;
            for(int i = arr.Length-1; i>=0; i--)
            {
                reversed[j] = arr[i];
                j++;
            }

            return reversed;
        }

        public static int CountOdds(int[] arr)
        {
            int count = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]%2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] SwapArrayParts(int[] arr)
        {   
            int mid = arr.Length / 2;
            int j = mid+arr.Length%2;
            for(int i=0; i<mid;i++,j++)
            {
                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;   
            }

            return arr;
        }

        public static int[] BubbleSort(int[] arr)
        {
            int temp;
            for(int i = 0; i<=arr.Length-2; i++)
            {
                for(int j=0; j<=arr.Length-2;j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                         
                    }
                }
            }

            return arr;
        }

        public static int[] BubbleSortReverse(int[] arr)
        {
            int temp;
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp; 
                    }
                }
            }

            return arr;
        }
    }
}
