using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Person
    {
        public Person(string name) {
            Name = name;
        }
        public string Name { get; set; }
    }

    class MyClass1 {
        public void MyMethod(ref Person employee, ref int count) {
            // print out the values of the parameters
            Console.WriteLine("MyMethod - parameter values: {0}, {1}",
                employee.Name, count);

            // modify the parameters
            employee = new Person("Joe Smith");
            count = 20;

            // print out the values again
            Console.WriteLine("MyMethod - modified parameter value: {0}, {1}",
                employee.Name, count);
        }
    }

    class Listing_10 {
        static void Main(string[] args) {
            // define local variables to use as parameters
            Person myperson = new Person("Jone Doe");
            int mycount = 10;

            // print out the values of the variables
            Console.WriteLine("Main Method - variables value before: {0}, {1}",
                myperson.Name, mycount);

            // create a new instance of MyClass and call the method
            MyClass1 mc = new MyClass1();
            mc.MyMethod(ref myperson, ref mycount);

            // print out the value of the variables again
            Console.WriteLine("Main Method - variable value after: {0}, {1}",
                myperson.Name, mycount);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
