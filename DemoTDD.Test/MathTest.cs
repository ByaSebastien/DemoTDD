using DemoTDD.Services;

namespace DemoTDD.Test
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void Addition()
        {
            //Arrange
            IMathService mathService = new MathService();
            int nb1 = 5;
            int nb2 = 3;
            int expected = 8;

            //Action
            int actual = mathService.Addition(nb1, nb2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionLimit()
        {
            //Arrange
            IMathService mathService = new MathService();
            int nb1 = int.MaxValue;
            int nb2 = 5;

            //Action and Assert
            Assert.ThrowsException<OutOfRangeMathException>
                (() => mathService.Addition(nb1, nb2));
        }

        [TestMethod]
        public void Soustraction()
        {
            //Arrange
            IMathService mathService = new MathService();
            int nb1 = 5;
            int nb2 = 3;
            int expected = 2;

            //Action
            int actual = mathService.Soustraction(nb1, nb2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SoustractionLimit()
        {
            //Arrange
            IMathService mathService = new MathService();
            int nb1 = int.MinValue;
            int nb2 = 5;

            //Action and Assert
            Assert.ThrowsException<OutOfRangeMathException>
                (() => mathService.Soustraction(nb1, nb2));
        }

        [TestMethod]
        public void Division()
        {
            //Arrange
            IMathService mathService = new MathService();
            int nb1 = 10;
            int nb2 = 2;
            int expected = 5;

            //Action
            int actual = mathService.Division(nb1, nb2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivisionByZero()
        {
            //Arrange
            IMathService mathService = new MathService();
            int nb1 = 5;
            int nb2 = 0;

            //Action and Assert
            Assert.ThrowsException<DivideByZeroException>
                (() => mathService.Division(nb1, nb2));
        }

        [TestMethod]
        public void Multiplication()
        {
            //Arrange
            IMathService mathService = new MathService();
            int nb1 = 10;
            int nb2 = 2;
            int expected = 20;

            //Action
            int actual = mathService.Multiplication(nb1, nb2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplicationLimitMax() 
        {
            //Arrange
            IMathService mathService = new MathService();
            int nb1 = int.MaxValue;
            int nb2 = 2;

            //Action and Assert
            Assert.ThrowsException<OutOfRangeMathException>
                (()=>mathService.Multiplication(nb1,nb2));
        }

        [TestMethod]
        public void MultiplicationLimitMin()
        {
            //Arrange
            IMathService mathService = new MathService();
            int nb1 = int.MaxValue;
            int nb2 = -2;

            //Action and Assert
            Assert.ThrowsException<OutOfRangeMathException>
                (() => mathService.Multiplication(nb1, nb2));
        }

        [TestMethod]
        public void Puissance()
        {
            //Arrange
            IMathService mathService = new MathService();
            int nb = 10;
            int puissance = 2;
            int expected = 100;

            //Action
            int actual = mathService.Puissance(nb,puissance);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PuissanceNegative()
        {
            //Assert
            IMathService mathService = new MathService();
            int nb = 5;
            int puissance = -0;
            int expected = 1;

            //Action
            int actual = mathService.Puissance(nb,puissance);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PuissanceLimit()
        {
            //Assert
            IMathService mathService = new MathService();
            int nb = int.MaxValue;
            int puissance = 2;

            //Action and Assert
            Assert.ThrowsException<OutOfRangeMathException>
                (() => mathService.Puissance(nb, puissance));
        }

        [TestMethod]
        public void PuissanceZeroByNegative()
        {
            //Assert
            IMathService mathService = new MathService();
            int nb = 0;
            int puissance = -2;

            //Action and Assert
            Assert.ThrowsException<DivideByZeroException>
                (() => mathService.Puissance(nb,puissance));
        }

        [TestMethod]
        public void Racine()
        {
            //Arrange
            IMathService mathService = new MathService();
            int nb = 25;
            int racine = 5;
            double exepted = 5;

            //Action
            double actual = mathService.Racine(nb, racine);

            //Assert
            Assert.AreEqual(exepted, actual);
        }
        [TestMethod]
        public void RacineDouble()
        {
            //Arrange
            IMathService mathService = new MathService();
            int nb = 12;
            int racine = 2;
            double exepted = 3.4641016151377544;

            //Action
            double actual = mathService.Racine(nb, racine);

            //Assert
            Assert.AreEqual(exepted, actual);
        }

        [TestMethod]
        public void IsEven()
        {
            //Assert
            IMathService mathService = new MathService();
            int nb = 10;

            //Action
            bool actual = mathService.isEven(nb);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsEvenFalse()
        {
            //Assert
            IMathService mathService = new MathService();
            int nb = 5;

            //Action
            bool actual = mathService.isEven(nb);

            //Assert
            Assert.IsFalse(actual);
        }
    }
}