using NUnit.Framework;
using Calculator;


namespace CalculatorTest
{
    public class CalculatorTest

        
    {
        AddOperator add = new AddOperator();
        MinusOperator minus = new MinusOperator();
        DivideOperator divide = new DivideOperator();
        MultiplyOperator multiply = new MultiplyOperator();

        double number1, number2, number3;
        double answer;


        [SetUp]

        public void Setup()
        {
            
            number1= 15;
            number2 = 3;
            number3 = 0;
        }
        
        [Test]
        public void SumCheck()

        {
            // ACT
            answer = add.MustDoOperation(number1, number2);

            // ASSERT

            Assert.AreEqual(18, answer);
            
        }

        [Test]
        public void SubtractionCheck()
        {
            double answer_1 = minus.MustDoOperation(number1, number2);
            double answer_2 = minus.MustDoOperation(number2, number1);


            Assert.Multiple(() =>
            {
                Assert.AreEqual(12, answer_1);
                Assert.AreEqual(-12, answer_2);

            });

            
        }

        [Test]
        public void MultiplicationCheck()
        {
            double answer_1 = multiply.MustDoOperation(number1, number2);
            double answer_2 = multiply.MustDoOperation(number1, number3);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(45, answer_1);
                Assert.AreEqual(0, answer_2);

            });

            
        }



        [Test]
        public void DivisionCheck()
        {
            double answer_1 = divide.MustDoOperation(number1, number2);
            double answer_2 = divide.MustDoOperation(number1, number3);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(5, answer_1);

                // Division on zero prints error and returns first number for operation continuation
                Assert.AreEqual(15, answer_2);

            });
        }



    }
}