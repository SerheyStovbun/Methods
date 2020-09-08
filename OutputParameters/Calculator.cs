using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    class Calculator
    {
        public int PerformCalculation(int x, int y) {
            if (x > 10 || y > 10)
            {
                throw new ArgumentOutOfRangeException();
            }
            else {
                return x * 10;
            }            
        }
        public bool TryPerformCalculation(int x, int y, out int result) {
            try
            {
                result = PerformCalculation(x, y);
                return true;
            }
            catch (ArgumentOutOfRangeException) {
                result = -1;
                return false;
            }
        }
        public int CalculateSum(params int[] numbers)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                result += i;
            }
            return result;
        }
        public int CalculateSum1(params int[] numbers) 
        {
            int result = 0;
            foreach (int i in numbers) 
            {
                result += 1;
            }
            return result;
        }
        static void Main(string[] args)
        {
        }
    }
    class Listing_14 {
        static void Main(string[] args) {
            // create a new instance of Calculator
            Calculator calc = new Calculator();

            // use the perform calc method directly
            int result = calc.PerformCalculation(5, 5);
            Console.WriteLine("Direct result: {0}", result);

            // use the tryXXX method
            int result2;
            bool success = calc.TryPerformCalculation(5, 5, out result2);
            Console.WriteLine("TryXXX first result: {0}, {1}", success, result2);

            success = calc.TryPerformCalculation(20, 5, out result2);
            Console.WriteLine("TryXXX second result: {0}, {1}", success, result2);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();

        }
    }

    class Listing_16 {
        static void Main(string[] args)
        {
            // create a new instance of calculator
            Calculator calc1 = new Calculator();

            // create an array of int values and pass them
            // as a parameter to the CalculateSum1 method to calculate quantity of parameters in array
            int[] data = {10, 34, 54, 124, 23};
            int result = calc1.CalculateSum1(data);
            Console.WriteLine("First: {0}", result);

            // call the CalculateSum method with one argument
            result = calc1.CalculateSum(10);
            Console.WriteLine("second result: {0}", result);

            // call with two arguments
            result = calc1.CalculateSum(40, 34);
            Console.WriteLine("Third result: {0}", result);

            // call with the same values that were in the array
            result = calc1.CalculateSum(10, 34, 54, 124, 23);
            Console.WriteLine("Fourth result: {0}", result);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();


        }
    }
}
