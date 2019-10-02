using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethoAssign2
{
    public static class TriangleSolver
    {
        public static string Analyze(int sideOfTriangles1, int sideOfTriangles2, int sideOfTriangles3)          //static analyze method
        {
            string TriangleType = string.Empty;

            if(sideOfTriangles1 + sideOfTriangles2 >= sideOfTriangles3 || sideOfTriangles1 + sideOfTriangles3 >= sideOfTriangles2 || sideOfTriangles2 + sideOfTriangles3 >= sideOfTriangles1)
            {
                Console.WriteLine("Triangle can be formed");                    //Triangle can be formed on the basis of above condition
                if (sideOfTriangles1 == sideOfTriangles2 && sideOfTriangles2 == sideOfTriangles3)
                {
                    TriangleType= "The triangle for given sides is Equilateral triangle";               //Condition for equilateral Triangle
                }

                else if (sideOfTriangles1 == sideOfTriangles2 || sideOfTriangles2 == sideOfTriangles3 || sideOfTriangles3 == sideOfTriangles1)
                {
                    TriangleType = "The triangle for given sides is Isoceles triangle";                    //Condition for Isoceles Triangle

                }

                else
                {
                    TriangleType= "The triangle for given sides is Scalene triangle";                       //Otherwise it will be a scalene Triangle
                }
            }
            else
            {
                TriangleType = "Triangle Cannot be formed ";                        //Triangle cannot be formed if condition not met
            }
            return (TriangleType);
        }
           

    }
}
    

