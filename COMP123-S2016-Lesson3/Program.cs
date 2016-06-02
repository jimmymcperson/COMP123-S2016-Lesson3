using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson3
{
    /**
    * This class is the "driver" class for our Program
    *
    * @class Program
    */
    public class Program
    {
        /**
        * The main method for our driver class Program
        *
        * @method Main
        * @param {string[]} args
        */
        public static void Main(string[] args)
        {
            // create a new instance of the Person class
            Person person = new Person("tom");

            Console.WriteLine(person.Name); // shows the constructor triggering

            // set a value in the Name property of the Person class
            person.Name = "Tom";

            // get the Name value and print to console
            Console.WriteLine(person.Name);

            
        }
    }
}
