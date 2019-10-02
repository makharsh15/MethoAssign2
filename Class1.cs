using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethoAssign2;
using NUnit.Framework;

namespace TestCase3
{
    [TestFixture]
    public class Class1
    {
        [Test]                                                                      //test1
        public void Analyze_Side1Equals9_Side2Equals8_Side3Equals7_ExpectedScaleneTriangle()
        {
            //Arrange
            int sideOfTriangle1 = 9;
            int sideOfTriangle2 = 8;
            int sideOfTriangle3 = 7;

            //Act
            string equi = TriangleSolver.Analyze(sideOfTriangle1, sideOfTriangle2, sideOfTriangle3);

            //Assign
            Assert.AreEqual(equi, "The triangle for given sides is Scalene triangle");
        }
        [Test]                                                                                                          //Test2
        public void Analyze_Side1Equals4_Side2Equals7_Side3Equals6_ExpectedScaleneTriangle()
        {
            //Arrange
            int sideOfTriangle1 = 4;
            int sideOfTriangle2 = 7;
            int sideOfTriangle3 = 6;

            //Act
            string equi = TriangleSolver.Analyze(sideOfTriangle1, sideOfTriangle2, sideOfTriangle3);

            //Assign
            Assert.AreEqual(equi, "The triangle for given sides is Scalene triangle");
        }
        [Test]                                                                                                                //Test3
        public void Analyze_Side1Equals11_Side2Equals11_Side3Equals11_ExpectedEquilateralTriangle()
        {
            //Arrange
            int sideOfTriangle1 = 11;
            int sideOfTriangle2 = 11;
            int sideOfTriangle3 = 11;

            //Act
            string equi = TriangleSolver.Analyze(sideOfTriangle1, sideOfTriangle2, sideOfTriangle3);

            //Assign
            Assert.AreEqual(equi, "The triangle for given sides is Equilateral triangle");
        }
        [Test]
        public void Analyze_Side1Equals3_Side2Equals3_Side3Equals3_ExpectedEquilateralTriangle()                            //Test4
        {
            //Arrange
            int sideOfTriangle1 = 3;
            int sideOfTriangle2 = 3;
            int sideOfTriangle3 = 3;

            //Act
            string equi = TriangleSolver.Analyze(sideOfTriangle1, sideOfTriangle2, sideOfTriangle3);

            //Assign
            Assert.AreEqual(equi, "The triangle for given sides is Equilateral triangle");
        }
        [Test]
        public void Analyze_Side1Equals5_Side2Equals5_Side3Equals5_ExpectedIsocelesTriangle()                       //Test5
        {
            //Arrange
            int sideOfTriangle1 = 6;
            int sideOfTriangle2 = 9;
            int sideOfTriangle3 = 6;

            //Act
            string equi = TriangleSolver.Analyze(sideOfTriangle1, sideOfTriangle2, sideOfTriangle3);

            //Assign
            Assert.AreEqual(equi, "The triangle for given sides is Isoceles triangle");
        }
        [Test ]                                                                                             //Test6
        public void Analyze_Side1Equals11_Side2Equals5_Side3Equals5_ExpectedIsocelesTriangle()
        {
            //Arrange
            int sideOfTriangle1 = 11;
            int sideOfTriangle2 = 5;
            int sideOfTriangle3 = 5;

            //Act
            string equi = TriangleSolver.Analyze(sideOfTriangle1, sideOfTriangle2, sideOfTriangle3);

            //Assign
            Assert.AreEqual(equi, "The triangle for given sides is Isoceles triangle");
        }
        [Test]                                                                                                                 //Test7
        public void Analyze_Side1Equals5_Side2Equals1_Side3Equals1_ExpectedNotATriangle()
        {
            //Arrange
            int sideOfTriangle1 = 5;
            int sideOfTriangle2 = 1;
            int sideOfTriangle3 = 1;

            //Act
            string equi = TriangleSolver.Analyze(sideOfTriangle1, sideOfTriangle2, sideOfTriangle3);

            //Assign
            Assert.AreEqual(equi, "The triangle for given sides is Isoceles triangle");
        }
        [Test]                                                                                                                    //Test8
        public void Analyze_Side1Equals7_Side2Equals4_Side3Equals12_ExpectedNotATriangle()
        {
            //Arrange
            int sideOfTriangle1 = 7;
            int sideOfTriangle2 = 4;
            int sideOfTriangle3 = 12;

            //Act4
            string equi = TriangleSolver.Analyze(sideOfTriangle1, sideOfTriangle2, sideOfTriangle3);

            //Assign
            Assert.AreEqual(equi, "The triangle for given sides is Scalene triangle");
        }

    }
}