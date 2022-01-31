using System;
namespace Assignment1_ISM6225
{
    class Assignment1_ISM6225
    {
        static void Main(string[] args)
        {
            //Question 1
            //Input from user
            Console.Write("Enter the string:");
            string s = Console.ReadLine();
            //Invokes the function RemoveVowels stated below
            string output = RemoveVowels(s);
            //Outputs the string after removal of vowels
            Console.WriteLine("Final string after removing the Vowels: {0}", output);
            Console.WriteLine();


            //Question 2
            //Console.WriteLine("Enter string1 for array comparison:");
            //Console.WriteLine();
            //Console.WriteLine("Enter string2 for array comparison:");
            //string[] bulls_string1 = Console.ReadLine();
            //string[] bulls_string2 = Console.ReadLine();

            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Array Comparison");
            if (flag)
            {
                Console.WriteLine("Yeah,both strings are same");
            }
            else
            {
                Console.WriteLine("Nah, the strings are different ");
            }
            Console.WriteLine();

            //Question 3
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int sum_of_unique = SumOfUnique(bull_bucks);
            Console.WriteLine("Sum of unique elements:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", sum_of_unique);
            Console.WriteLine();


            //Question 4
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Sum of diagonal elemnts:");
            int Sum_of_diagonals = Sumofdiagonals(bulls_grid);
            Console.WriteLine("The sum of the diagonal elements in the bulls grid is {0}:", Sum_of_diagonals);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("String shuffle:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String shuffled_string = ShuffleString(bulls_string, indices);
            Console.WriteLine("The  output string after rotation is {0} ", shuffled_string);
            Console.WriteLine();

            //Quesiton 6
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Character Reverse:");
            Console.WriteLine("Resultant string after reversing the character:{0}", reversed_string);
            Console.WriteLine();

        }


        //Function to check if any vowels are present in a given string and remove them if present and return the rest of the string.

        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here
                String output_string = "";
                foreach (char x in s)
                {
                    if (x != 'A' & x != 'E' & x != 'I' & x != 'O' & x != 'U' & x != 'a' & x != 'e' & x != 'i' & x != 'o' & x != 'u')
                    {
                        output_string = output_string + x;
                    }
                }
                return output_string;
            }
            catch (Exception)
            {
                Console.WriteLine("Uh Ohhhh!");
                throw;
            }

        }


        //Fucntion to compare two given strings
        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                // write your code here.
                if (string.Join("", bulls_string1) == string.Join("", bulls_string2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Fuction to output the sum of unique numbers in a given array
        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                // write your code here
                int s = 0;
                //Gets the length of the array
                int len = bull_bucks.Length;
                foreach (int a in bull_bucks)
                {
                    int count = 0;
                    for (int i = 0; i < len; i++)
                    {
                        if (a == bull_bucks[i])
                        {
                            count = count + 1;
                        }
                    }
                    if (count == 1)
                    {
                        s = s + a;
                    }
                }
                return s;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to find the sum of diagonal elements in a given set of matrix array
        private static int Sumofdiagonals(int[,] bulls_grid)
        {
            try
            {
                // write your code here.
                int a = bulls_grid.Length;
                int b = Convert.ToInt32(Math.Sqrt(a));
                int sum = 0;
                for (int i = 0; i < a; i++)
                {
                    sum = sum + bulls_grid[i, i] + bulls_grid[i, a - i - 1];
                }
                if (a % 2 != 0)
                {
                    return sum - bulls_grid[(a - 1) / 2, (a - 1) / 2];
                }
                else
                {
                    return sum;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Uhh ohh!");
                throw;
            }

        }




        //Shuffles String based on indices
        private static string ShuffleString(string bulls_string, int[] indices)
        {
            try
            {
                // write your code here.
                string[] a = new string[bulls_string.Length];
                string c = "";
                for (int i = 0; i < bulls_string.Length; i++)
                {
                    int b = indices[i];
                    a[b] = Convert.ToString(bulls_string[i]);
                }
                for (int i = 0; i < bulls_string.Length; i++)
                {
                    c = c + a[i];
                }
                return c;
            }
            catch (Exception)
            {
                Console.WriteLine("Uhh ohh!");
                throw;
            }

        }


        //Reverses string based on character specified
        private static string ReversePrefix(string bulls_string, char ch)
        {
            try
            {
                string[] m = new string[bulls_string.Length];
                for (int i = 0; i < bulls_string.Length; i++)
                {
                    if (bulls_string[i] == ch)
                    {
                        m = bulls_string.Split(ch);
                    }
                }
                string p = "";
                for (int j = m[0].Length - 1; j >= 0; j--)
                {
                    p = p + bulls_string[j];
                }
                String prefix_string = ch + p + m[1];
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}