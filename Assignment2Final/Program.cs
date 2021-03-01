using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine();

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine();

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 2;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            // I believe there is a flaw in the method in this question msking it unsolvable
            // I believe method needs to not be void but return a value

            // This is my attempt on it

            // try block
            try
            {
                // create new integer array
                int[] outcome = new int[nums.Length];

                // for loop, if b is less than n outcome integer containing b *2 is equal to array nums containing b
                for (int b = 0; b < n; b++)
                {
                    outcome[b * 2] = nums[b];
                }

                // for loop. IF c is less than n, array outcome containing c * 2 minus 1 is equal to array nums containing n plus c minus 1
                for (int c = 1; c < n + 1; c++)
                {
                    outcome[(c * 2) - 1] = nums[n + c - 1];
                }


            }

            // catch block
            catch (Exception)
            {

                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            // Could not get this to work. I suspect there is a flaw in the method
            // I believe a value needs to be returned

            // This is my attempt at it

            // try block
            try
            {


                // Declare variables
                int count = 0;
                int c = 0;

                // For loop to find 0's in array
                for (int b = 0; b < c; b++)
                {
                    // If statement. If b in the integer is not equal to 0.couunt and put array in declaration
                    if (ar2[b] != 0)
                    {
                        ar2[count++] = ar2[b];

                    }

                }
                // While loop if count is less than c add 0's
                while (count < c)
                {
                    ar2[count++] = 0;
                }





            }
            // catch statement
            catch (Exception)
            {

                throw;
            }

            return;
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            // Was also unable to solve this one as I believe there is an error in the method
            // I believe it needs to return a value

            // This is my attempt at it

            // Try block
            try
            {
                // Declare count variable
                int count = 0;

                // For loop testing if b is less than array nums
                for (int b = 0; b < nums.Length; b++)
                {
                    // nested for loop testing if c is equal to b plus 1 and if c is less than array nums length
                    for (int c = b + 1; c < nums.Length; c++)
                    {
                        // Increment count
                        count++;
                    }
                }
            }

            // Catch block
            catch (Exception)
            {

                throw;
            }

            return;
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            // Unable to solve as I again suspect method in this problem is flawed due to it not returning a value

            // Here is my attempt on it

            // Try block
            try
            {
                // Create new dictionary
                Dictionary<int, int> numberDicionary = new Dictionary<int, int>();

                // For loop to test if b is less than lenght of array nums
                for (int b = 0; b < nums.Length; b++)
                {
                    // declare integer variable nums
                    int number = nums[b];

                    // if statement to get values of of dictionary
                    if (numberDicionary.TryGetValue(target - number, out int index))
                    {
                        int[] c = { index, b };
                    }

                    numberDicionary[number] = b;
                }


            }

            // Catch block
            catch (Exception)
            {

                throw;
            }

            return;
        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            // Was unable to solve as I believe the method in thos problem is also flawed due to it not returning a value

            // Here is my attempt aat it

            // Try block
            try
            {
                // creation of a char dicitonary populated by length of indicies array
                char[] b = new char[indices.Length];


                // for loop testing if c is less than lenght of indices array
                // if so b array containting indicies array and variable c equals string s containing variable c
                for (int c = 0; c < indices.Length; c++)
                {
                    b[indices[c]] = s[c];
                }



            }
            catch (Exception)
            {

                throw;
            }

            return;
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            // Declare size
            int size = 256;

            try
            {
                // Declare variables based on string lengths given in method declaration
                int b = s1.Length;
                int c = s2.Length;


                // If variable b is not eqaul to variable c, return false
                if (b != c)
                {
                    return false;
                }

                // Bool array declared based on size variable
                bool[] marker = new bool[size];


                // For loop if j is less than size array with j is false
                for (int j = 0; j < size; j++)
                {
                    marker[j] = false;
                }

                // integer array declared based on size variable
                int[] mapping = new int[size];


                // For loop if j is less than size array with j is -1
                for (int j = 0; j < size; j++)
                {
                    mapping[j] = -1;
                }


                // For loop testing if j is less than c
                for (int j = 0; j < c; j++)
                {
                    // if statement for mapping array containg s1 and j is true
                    if (mapping[s1[j]] == -1)
                    {
                        // if statement testing if mapping array containing s2 and j is true it returns false
                        if (marker[s2[j]] == true)
                        {
                            return false;
                        }
                        // declares marker containing s2 and j is true
                        marker[s2[j]] = true;

                        // mapping containing s1 and j is equal to s2 containing j
                        mapping[s1[j]] = s2[j];

                    }

                    // else if statement stating that if mapping containing s1 and j is not equal to s2 containing j it will return false
                    else if (mapping[s1[j]] != s2[j])
                    {
                        return false;
                    }
                }


                // returns true for boolean expression
                return true;
            }

            // catch statement
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            // Unable to solve this problem. I also believe the method is flawed. 
            // I believe a value needs to be returned in method declaration
            try
            {


            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                // create a list
                List<int> bag = new List<int>();

                // declare sum variable
                int sum = 0;

                // while loop if n does not equal 1 and if bad contains in it will return false
                while (n != 1)
                {
                    if (bag.Contains(n))
                    {
                        return false;

                    }

                    // adds n to bag
                    bag.Add(n);

                    // while loop if n does not equal to 0
                    while (n != 0)
                    {
                        // calculations
                        int number = n % 10;
                        sum += number * number;
                        n /= 10;
                    }

                    n = sum;
                    sum = 0;
                }

                // return boolean true
                return true;
            }

            // catch statement
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {

            // Try block
            try
            {
                // declare max and min price variables
                int maxPrice = 0;
                int minPrice = 0;

                // for loop checking if b i less than length of prices array
                for (int b = 0; b < prices.Length; b++)
                {
                    // if statement that declares if prices index contains b is less than prices index containing min price
                    // min price will be equal to b
                    if (prices[b] < prices[minPrice])
                    {

                        minPrice = b;
                    }


                    // if statement declaring if prices index containing b minus prices index containing minimum price is grater than max price
                    // max price will be equal to prices index containing b minus prices index containing min price
                    if (prices[b] - prices[minPrice] > maxPrice)
                    {
                        maxPrice = prices[b] - prices[minPrice];
                    }
                }
                // returns max price variable
                return maxPrice;
            }

            // catch block
            catch (Exception)
            {

                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            // Unable to solve, I belive method is flawed as there is no return, it is only void

            try
            {



            }
            catch (Exception)
            {

                throw;
            }


        }





    }
}
