using System;

namespace NamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Send all the parameters in the order of that in the method and check the output
            GetCohortDetails("Absar Shariq", 20, ".Net", "OBL", "Asynchronous");

            //Send the parameters in incorrect order and check the output
            GetCohortDetails("Absar Shariq", 20, "OBL", ".Net", "Asynchronous");

            //Use Named parameters to send the input data, NOT in the order in the method and check the output
            GetCohortDetails(cName:"Absar Shariq",Track:".Net", GencCount:20,Mode:"OBL", CurrentModule:"Asynchronous");
            Console.ReadLine();
        }
        static void GetCohortDetails(string cName, int GencCount, string Track, string Mode, String CurrentModule)
        {
            Console.WriteLine("It is {0} with {1} GenCs undergoing training for {2} thru {3}. The current module of training is {4}",cName,GencCount, Track,Mode,CurrentModule);
            Console.WriteLine();
        }
    }
}
