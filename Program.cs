using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethoAssign2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string takeUserInput = "";
            bool MenuSelection = false;
            int sideOfTriangle1;
            int sideOfTriangle2;
            int sideOfTriangle3;

            int x1;
            string value1;

            while (MenuSelection == false)                                                         
            {
                do
                {

                    Console.WriteLine("1. Get triangle Dimensions ");                           //Created menu
                    Console.WriteLine("2. Exit \n");

                    Console.Write("Please select an option by entering a number: ");                  //Takes input from the user for the menu
                    takeUserInput = Console.ReadLine();
                    
                    if (takeUserInput != "1" &&
                        takeUserInput != "2")
                    {
                        Console.WriteLine("Thats not a correct Menu option, please try again: \n");
                    }
                    else
                    {
                        MenuSelection = true;
                    }
                    Console.WriteLine();

                    if (MenuSelection == true && takeUserInput == "1")
                    {
                        do
                        {
                            Console.Write("Please enter the first side of the triangle: ");             //enter side1
                            int.TryParse(Console.ReadLine(), out sideOfTriangle1);
                        } while (!(sideOfTriangle1 > 0));

                        do
                        {
                            Console.Write("Please enter the second side of the triangle: ");
                            int.TryParse(Console.ReadLine(), out sideOfTriangle2);                          //enter side2                           
                        } while (!(sideOfTriangle2 > 0));

                        do
                        {
                            Console.Write("Please enter the third side of the triangle: ");                 //enter side3
                            int.TryParse(Console.ReadLine(), out sideOfTriangle3);
                        } while (!(sideOfTriangle3 > 0));

                        Console.WriteLine(TriangleSolver.Analyze(sideOfTriangle1, sideOfTriangle2, sideOfTriangle3));

                        value1 = Console.ReadLine();

                        int.TryParse(value1, out x1);

                    }
                    else
                    {
                        Environment.Exit(0);                            //To exit the menu
                    }

                } while (takeUserInput == "1");


            } 

        }

    }

}
