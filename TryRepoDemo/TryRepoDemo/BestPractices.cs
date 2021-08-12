using System;

namespace BasicsOfCSharp
{
    //  The best practices of C#. class names and method name should be in pascal case
   /// <summary>
   /// This class is use to elaborate best practices
   /// </summary>
    class BestPractices
    {
        //  The methods name should be in pascal case
        //  The method argument and local variables should be in camelCase
        //  Constants should always be declared in UPPERCASE
        const double PI = 3.14;

        /// <summary>
        /// This function prints a message.
        /// </summary>
        /// <param name="firstName">This takes first name as string</param>
        /// <param name="lastName">This takes last name as string</param>
        public void PrintMessage(string firstName,string lastName)
        {
            //Avoid
            int Std_Age;
            //Correct
            int stdAge = 10;

            //Avoid
            //Int32 count;
            //Boolean flag = true;

            //Correct
            int count;
            bool flag = true;
        }

        public void PrintMessage1()
        {
            //  Block should be proper indented
            
            if (true)
            {
                for(int i=0;i<=10;i++)
                {

                }
                // Declare the variables as close as possible to thier usage.
                int sum = 100;
                Console.WriteLine(sum);
            }
        }
    }

    //  The interface name should have I prefix.
    interface IShape
    {

    }
}
