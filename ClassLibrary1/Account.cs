using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

namespace ClassLibrary1
{
    public class Account
    {
        static int count = 0;
        private string first_name;
        private string last_name;
        private DateTime dateofbirth;
        static readonly decimal minSum;
        public Account(string firstName, string lastName, DateTime date)
        {
            first_name = firstName;
            last_name = lastName;
            dateofbirth = date;
            count += 1;
        }
        static Account()
        {
            minSum = 1000;
        }
        public static decimal GetSum(decimal sum, int period, AccountState state)
        {
            if (minSum > 0)
            {
                for (int i = 0; i < period; i++)
                {
                    sum += sum * (int)state / 100;
                }
                return sum;
            }
            return 0;

        }
        public void Report()
        {
            Console.WriteLine($"first name = {first_name}" +
                $"last name = {last_name}" +
                $"date of birth {dateofbirth}");
        }

    }
}

