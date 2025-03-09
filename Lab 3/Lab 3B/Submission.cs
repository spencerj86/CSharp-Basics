using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSPG1
{
    class Submission
    {
        /*
         * This lab is NOT interactive - that means there should be no 
         * calls to the Console class (no Write/WriteLine/ReadLine/ReadKey)
         * 
         */

        private string greeting;
        private int rendezvous;

        public Submission()
        {
            greeting = "Good day";
            rendezvous = 7;
        }

        // Test 1 - write an overloaded constructor that will accept 
        // a string value (only a string) to intialize greeting. Do 
        // not accept an int and do not initialize rendezvous
        public Submission(string mongoose)
        {
            greeting = mongoose;

        }

        // Test 2 - Write a getter for greeting (GetGreeting)
        // Getters return the data type matching the field they are
        // 'getting' and do not accept parameters (for now)

        public string GetGreeting()
        {
            return greeting;
        }

        // Test 3 - Write a setter for greeting (SetGreeting)
        // Setters don't return anything and accept a parameter that
        // matches the member field they are 'setting'

        public void SetGreeting(string llama)
        {
            greeting = llama;
        }
        

        // Test 4 - Write a property for rendezvous named Rendezvous
        // The property must update/access the rendezvous member 
        // field

        public int Rendezvous
        {
            get { return rendezvous; }
            set { rendezvous = value; }
        }


        // Test 5 - Write a method named GreetingMe that accepts
        // no parameters and returns the value of greeting as 
        // all capital letters - Use the ToUpper method. ToUpper is
        // a member of the string class (so use the dot operator 
        // to access it from any string. The definition of ToUpper is:
        // public string ToUpper()

        public string GreetingMe()
        {
            
            return greeting.ToUpper();
        }


        // Test 6 - Complete the method so that it returns 
        // the input value raised to the 3rd power (use  
        // Math.Pow and cast the returned value to int)
        public static int Test6(int input)
        {

            int num = (int)Math.Pow(input, 3);
            return num;
        }

        // Test 7 - Complete the method so that it returns
        // the square root of the input value as a double
        // Use Math.Sqrt to find the square root
        // Math.Sqrt returns a double, so there is no
        // need to cast the result
        public static double Test7(float input)
        {
            double num = Math.Sqrt(input);
            return num;
        }

        // Test 8 - Complete the method so that it returns 
        // the quotient when number1 is divided by number2

        public static int Test8(int number1, int number2)
        {
            int num = number1 / number2;
            return num;
        }

        // Test 9 - Complete the method so that it return
        // the remainder when number1 is divided by number2

        public static int Test9(int number1, int number2)
        {
            int num = number1 % number2;
            return num;
        }

        // Test 10 - Complete the method so that it returns
        // a random int based on the seed provided, The return
        // value must be between min (inclusive) and max 
        // (exclusive). To complete this Test, you need to
        // create a Random object, passing the seed provided
        // the Random's constructor

        public static int Test10(int min, int max, int seed)
        {

            Random rng = new Random(seed);
            int num = rng.Next(min, max);
            return num;
        }
    }
}
