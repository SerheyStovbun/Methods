using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class ProductResult
    {
        public int FirstParam { get; set; }
        public int SecondParam { get; set; }
        public int Result { get; set; }
    }

    class MyClass {

        public ProductResult CalculateProduct(int num1, int num2) {
            // compute the product
            return new ProductResult()
            {
                FirstParam = num1,
                SecondParam = num2,
                Result = num1 * num2
            };
        }
        
        public int CalculateProduct1(int num1, int num2) {
            // check that the parameters are valid
            CheckRange(num1, num2);
            {
                // number is valid - perform calculation
                return num1 * num2;
            }
            
        }

        public int CalculateSum(int num1, int num2) {
            // check that the parameters are valid
            CheckRange(num1, num2);
            {
                return num1 + num2;
            }
            
        }

        public float CalculateRatio(int num1, int num2) {
            // check that the parameters are valid
            CheckRange(num1, num2);
            {
                // number is valid - perform calculatio and cast int to float type
                return (float)num1 / (float)num2;
            }
           
        }

        private void CheckRange(int num1, int num2)
        {
         if(!(num1 > 0 && num1 < 100 && num2 > 0 && num2 < 100)){
                throw new ArgumentOutOfRangeException();
         }
        }

        class Listing_08 {
            static void Main(string[] args)
            {
                // create a new instance of my class
                MyClass mc = new MyClass();

                // call the method in the MyClass instance
                int result1 = mc.CalculateProduct1(10, 50);
                int result2 = mc.CalculateSum(10, 50);
                float result3 = mc.CalculateRatio(10, 50);
                
                // print out the results
                Console.WriteLine("Product: {0}", result1);
                Console.WriteLine("Sum: {0}", result2);
                Console.WriteLine("Ratio: {0}", result3);

                // wait for input before exiting
                Console.WriteLine("Press enter before finish");
                Console.ReadLine();
            }
        }
    }
}
