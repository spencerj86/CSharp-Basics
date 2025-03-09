using System;
using System.Diagnostics.Contracts;
using Tester;

namespace FSPG1
{
    class Submission
    {
        private const string V = " ";

        /*
* This lab is NOT interactive - that means there should be no 
* calls to the Console class (no Write/WriteLine/ReadLine/ReadKey)
* 
* You cannot use multiple return statements any of these methods. 
* Additionally the use of var is not permitted
* 
*/

        // Test 1 – Convert char array to int array
        // Given an array of char, phrase, convert each element to an
        // equivalent int value and place in an int array.
        // Return the int array
        public static int[] Test1(char[] phrase)
        {
            int[] numArray = new int[phrase.Length];
            for(int i = 0; i < phrase.Length; i++)
            {
                numArray[i] = (int)phrase[i];
            }
            return numArray;
        }

        // Test 2 - Array statistics
        // Given an array of double, data, find the smallest element, 
        // the largest element and the numeric mean (average). Store the 
        // results in an array (in that order: smallest, largest, mean).
        // Return the array
        public static double[] Test2(double[] data)
        {
            double[] answer = new double[3];
            double min = data[0];
            double max = data[0];
            double ans = data[0];
            double sum = 0;

            for (int i = 1; i < data.Length; i++)
            {
                if (min > data[i])
                {
                    min = data[i];
                }

                if (max < data[i])
                {
                    max = data[i];
                }
            }
            answer[1] = max;
            answer[0] = min;
            for (int i = 0; i < data.Length; i++)
            {
                sum = data[i] + sum;
                ans = sum / data.Length;
            }
            answer[2] = ans;

            return answer;
        }

        // Test 3 - Normalize an array (of double)
        // Given an array of double, numbers, normalize the array. To 
        // normalize an array:
        // 1) Find the largest element stored in the array
        // 2) Divide each element in the array by the largest value
        //    and replace each array element with the result of the 
        //    division.
        // Since the array's contents are being modified, there is 
        // nothing to return
        public static void Test3(double[] numbers)
        {
            double max = numbers[0];
            double[] normalize = new double[numbers.Length];
            double answer = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            for(int i = 0; i < numbers.Length; i++)
            {
               answer = numbers[i] / max;
                numbers[i] = answer;
            }
        }

        // Test 4 - Uniqueness
        // Given an array of string, names, verify that each name is unique
        // mean that none of the names are duplicated within the array.
        // If the array is unique, return true; otherwise, return false
        //Detroit Dallas Denver Spokane Parker Orlando Waco Chicago Columbus
        public static bool Test4(string [] names)
        {
            bool unique = true;

            for(int outer = 0; outer < names.Length && unique; outer++)
            { 
                for(int i = (outer + 1); i < names.Length; i++)
                {
                    if(names[outer] == names[i])
                    {
                        unique = false;
                        break;
                    }
                    
                }
            }

            return unique;
        }

        // Test 5 - Acronym
        // Given an array of string, words, create a string that is the 
        // acronym (first letter of each word). Return the string
        public static string Test5(string [] words)
        {
            string result = "";
            for(int i = 0; i < words.Length; i++)
            {
                result += words[i][0];
            }
            return result;
        }

        // Test 6 - Array reverse
        // Given a char array, letters, create another array that has the
        // same elements but in reverse order. Return the array
        // 
        // You are not allowed to use Array.Reverse (or any existing
        // method) to reverse the array
        //
        public static char[] Test6(char[] letters)
        {
            char[] end = new char[letters.Length];
            for (int i = letters.Length - 1; i >= 0; i--)
            {
                end[i] = letters[letters.Length - 1 - i];
            }

            return end;
        }

        // Test 7 - Transpose array
        // Given a 2-Dimension array of int, table, create a new array that 
        // 'transposes' the original array. Transposing means that each row 
        // in the original array will be a column in the new array and each
        // column in the original array will be a row in the new array.
        // For example, given
        //   4   3   1   5
        //   2   7   0   8
        //
        // The transposed array would be
        //   4   2
        //   3   7
        //   1   0
        //   5   8
        //
        public static int[,] Test7(int [,] table)
        {
            int[,] grid = new int[table.GetLength(1), table.GetLength(0)];

            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    grid[col, row] = table[row, col];
                }
            }

            return grid;
        }

        // Test 8 – Return a 2D array
        // Given three arrays of the same type (int) and size, combine the 
        // arrays into a single 2D array. Return the 2D array
        // NOTE: This solution requires a single loop (not three)
        // 
        public static int [,] Test8(int [] mins, int [] maxes, int [] seeds)
        {
            int[,] answer = new int[3, mins.Length];
            for(int i = 0; i < 3; i++)
            {
                int[] notAnswer = new int[] { };
                switch (i)
                {
                    case 0:
                        notAnswer = mins;
                        break;
                    case 1:
                        notAnswer = maxes;
                        break;
                    case 2:
                        notAnswer = seeds;
                        break;
                }
                for (int j = 0; j < mins.Length; j++)
                {
                    answer[i, j] = notAnswer[j];
                }

            }
            return answer;
        }

        // Test 9 – Convert int array to char array
        // Given an array of int, ascii, convert each element to an
        // equivalent char value and place in a char array.
        // Return the char array
        public static char[] Test9(int[] ascii)
        {
            char[] answer = new char[ascii.Length];

            for(int i = 0; i < ascii.Length; i++)
            {
                answer[i] = (char)ascii[i];
            }

            return answer;
        }

        // Test 10 – Modify an existing array
        // Given an array of char (all uppercase), modify the array so
        // that every other element will be lowercase (even indexes are 
        // upper, odd indexes are lower)
        public static void Test10(char[] word)
        {
            int bump = 2;
            for(int i = bump - 1; i < word.Length; i += bump)
            {
                word[i] = char.ToLower(word[i]);
            }
        }
    }
}
