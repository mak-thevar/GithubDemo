using NUnit.Framework;

namespace GithubDemo_DF003_04.Test
{
    public class CalcTests
    {

        private Calc calc;


        [OneTimeSetUp]
        public void Setup()
        {
            calc = new Calc();
        }

        [TestCase(20,20, ExpectedResult = 40)]
        [TestCase(20,-20, ExpectedResult = 0)]
        [TestCase(-20,-20, ExpectedResult = -40)]
        [TestCase(-100,-20, ExpectedResult = -120)]
        public int AddTest(int x, int y)
        {
            //Arrage
            

            //Act
            var result = calc.Add(x, y);

            //Assert
            return result;
        }


        [TestCase(20, 20, ExpectedResult = 400)]
        [TestCase(20, -20, ExpectedResult = -400)]
        [TestCase(-20, -20, ExpectedResult = 400)]
        [TestCase(-100, -20, ExpectedResult = 2000)]
        public int MultiplyTest(int x, int y)
        {
            //Arrage


            //Act
            var result = calc.Multiply(x, y);

            //Assert
            return result;
        }


        [TestCase(20, 20, ExpectedResult = 1)]
        [TestCase(20, -20, ExpectedResult = -1)]
        [TestCase(-20, -20, ExpectedResult = 1)]
        [TestCase(-100, -20, ExpectedResult = 5)]
        public int DivideTest(int x, int y)
        {
            //Arrage


            //Act
            var result = calc.Divide(x, y);

            //Assert
            return result;
        }


        [TestCase(20, 20, ExpectedResult = 0)]
        [TestCase(20, -20, ExpectedResult = 40)]
        [TestCase(-20, -20, ExpectedResult = 0)]
        [TestCase(-100, -20, ExpectedResult = -80)]
        public int SubtractTest(int x, int y)
        {
            //Arrage


            //Act
            var result = calc.Subtract(x, y);

            //Assert
            return result;
        }
    }
}