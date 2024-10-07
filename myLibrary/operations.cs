using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class operations
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public double AddDecima(double number1, double number2)
        {
            return number1 + number2;
        }

        public IList<int> GetEvenNumbers(int start, int end)
        {
            //List<int> numbers = new List<int>();
            //for (int i = start; i <= end; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        numbers.Add(i);
            //    }


            //}
            //return numbers;

            return Enumerable.Range(start, end)
                .Where(IsEven).ToList();
        }
    }
}
