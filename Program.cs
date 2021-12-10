



// Another trial 



namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            
            List<IOperator> availableOperations = new List<IOperator>();
            availableOperations.Add(new AddOperator());
            availableOperations.Add(new MinusOperator());
            availableOperations.Add(new MultiplyOperator());
            availableOperations.Add(new DivideOperator());




            CalculatorBase calculator = new CalculatorBase();
            


            calculator.PrintOut("\n --------------------------" +
                        "\n Hello and Welcome to the Calculator! " +
                        "\n --------------------------");

            double num1 = double.NaN;
            double num2 = double.NaN;
            double result = double.NaN;

            bool userContinue = true;
            bool numDefined = false;


            while (userContinue == true)
            {
                

                if (numDefined == false)

                {

                    num1 = calculator.UserNumberInput(1);

                }
                else
                {
                    num1 = result;
                }

                IOperator foundOperator = calculator.UserOperatorInput(availableOperations);


                num2 = calculator.UserNumberInput(2);

                if (foundOperator != null) { 
                result = foundOperator.MustDoOperation(num1, num2);
                }

                calculator.PrintOut("\n  answer is "+ Convert.ToString(result));

                (numDefined, userContinue) = calculator.OperationContinue(out numDefined, out userContinue);
                

            }











        }
    }
}




   





















