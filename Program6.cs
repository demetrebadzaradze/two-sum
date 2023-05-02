//two sum
using System;
using System.Collections;

namespace Csharpproject
{
    class Program
    {
        static void Main(string[] args)
        {
            int target;
            int[] Numbers = new int[15];

            Console.WriteLine("Enter target number");
            target = Convert.ToInt32(Console.ReadLine());

            ArrayFill(Numbers);

            int[] twoNums = TwoSum(Numbers, target);

            Console.WriteLine("numbers in array are:");
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(" " + Numbers[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine($"\n{twoNums[0]}, {twoNums[1]}");


            if (twoNums[0] == 0)
            {
                if (twoNums[1] == 0)
                {
                    if (target != 0)
                    {
                        Console.WriteLine($"\nthere is not two numbers that add up to {target} in this array");
                    }
                    else
                    {
                        Console.WriteLine($"\n{Numbers[twoNums[0]] } + {Numbers[twoNums[1]]} = {target}");
                    }
                }

            }
            else
            {
                Console.WriteLine($"\n{Numbers[twoNums[0]] } + {Numbers[twoNums[1]]} = {target}");
            }

        }

        static int[] TwoSum(int[] nums, int target)
        {
            int[] Null = { 0, 0 };
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            result[0] = i;
                            result[1] = j;

                            return result;
                        }
                    }

                }
            }
            if (result[0] + result[1] != target)
            {
                return Null;
            }
            else
            {
                return result;
            }

        }
        static void ArrayFill(int[] arr)
        {
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 9);
            }
        }
    }
}
