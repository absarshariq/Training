using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Send data for the required parameters only and check the output
            OrderDetails("Absar", "mobile");
            //Send data for the required and optional parameters and check the output
            OrderDetails("Absar", "mobile",4,"False");
            Console.ReadLine();

        }
        static void OrderDetails(string sName, string pName,int Quantity=1, string IsReturnable="True")
        {
            Console.WriteLine("Here is the order detail  \n{0} number of {1} by {2} is ordered. It’s returnable status is {3}",Quantity,pName,sName,IsReturnable);
            Console.WriteLine();
        }
    }
}
