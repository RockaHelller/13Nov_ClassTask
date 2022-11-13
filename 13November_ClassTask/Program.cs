using System;
using System.Collections.Generic;

namespace _13November_ClassTask
{
    class Program
    {
        //public delegate void Power(int a, int b);

        static void Main(string[] args)
        {
            //List<int> nums = new List<int>() { 1, 42, 21 };
            //Console.WriteLine(Sum(CheckNums, nums));
            //Action<int, int> action = new Action<int, int>();
            //GetPower(CalculatePower, 2, 3);//1

            //Action<int, int> action = CalculatePower;
            //action.Invoke(2, 3);

            ShowFactorial(GetFactorial, 5);

            Func<int, int> func = GetFactorial;
            Console.WriteLine(func.Invoke(5));

        }

        #region
        //public static bool CheckNums(int number)
        //{
        //    return (number % 3 == 0) && (number % 7 == 0);
        //}

        //public static int Sum(Predicate<int> predicate, List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
        #endregion



        public static int GetFactorial(int a)
        {
            int sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
            return sum;
        }

        public static void ShowFactorial(Func<int, int> func, int num)
        {
            Console.WriteLine(func(num));
        }




        //public static void CalculatePower(int a, int b)
        //{
        //    Console.WriteLine(Math.Pow(a,b));
        //}



        //public static void GetPower(Action<int, int> math, int num1, int num2)
        //{
        //    math(num1, num2);
        //}





    }
}
