using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_YourOrderPlease
{
    class Program
    {
        static void Main()
        {
            // https://www.codewars.com/kata/55c45be3b2079eccff00010f
            Console.WriteLine(Order("is2 Thi1s T4est 3a"));
            Console.WriteLine(Order("4of Fo1r pe6ople g3ood th5e the2"));
            Console.WriteLine(OrderTwo("is2 Thi1s T4est 3a"));
            Console.WriteLine(OrderTwo("4of Fo1r pe6ople g3ood th5e the2"));
            Console.ReadKey();
        }

        // First solution
        public static string Order(string words)
        {
            List<string> input = words.Split(' ').ToList();
            string[] output = new string[input.Count];

            foreach (string item in input)
            {
                foreach (char content in item)
                {
                    if(Char.IsNumber(content))
                    {
                        int index = (int)Char.GetNumericValue(content);
                        output[--index]= item;
                    }
                }
            }
            return String.Join(" ", output);
        }

        // Refactored solution
        public static string OrderTwo(string words)
        {
            return  string.IsNullOrEmpty(words) ? words :
                    string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
        }
    }
}
