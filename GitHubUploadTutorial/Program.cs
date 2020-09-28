using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubUploadTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            age = DisplayGetUserAge();


        }

        static int DisplayGetUserAge()
        {
            int age;
            string userResponse;
            bool validResponse;


            do
            {
                validResponse = true;

                Console.Write("Hello human, how old are you?");
                userResponse = Console.ReadLine();

                if (!int.TryParse(userResponse, out age))
                {
                    Console.WriteLine("Please enter a proper age as a number.");
                    validResponse = false;
                }
            } while (!validResponse);

            return age;
        }
    }
}
