using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorBase : ICalculation
    {
        public void PrintOut(string words)
        {

            Console.WriteLine(words);

        }


        public string Read()
        {
            string inp = Console.ReadLine();

            return inp;
        }

        public double Calculate(IOperator operationType, double input1, double input2)
        {
            double answer = operationType.MustDoOperation(input1, input2);
            PrintOut(answer.ToString());

            return answer;
        }
        public double ReadCheck(string numberToCheck)
        {
            string rawNumber = numberToCheck;

            try
            {
                double readyNumber = Convert.ToDouble(rawNumber);
                return readyNumber;
            }
            catch (Exception ex)
            {
                PrintOut("Error, enter the number!");
                return double.NaN;
            }
        }

        public double Calculate()
        {
            throw new NotImplementedException();
        }

        public char Operator
        {
            get;
        }

        public char NameOperator => throw new NotImplementedException();

        public double UserNumberInput (int inputNumber = 1)
        {
            double num = double.NaN;
            while (double.IsNaN(num))
            {
                PrintOut($"\n Enter {inputNumber} number ...");
                string number = Read();
                num = ReadCheck(number);

            }
            return num;
        }

        public IOperator UserOperatorInput(List<IOperator> availableOperations)
        {
            PrintOut("\n Enter arithmetic operator (+, -, *, /) ...");

            bool withoutError = false;
            char sampleOperator;
            IOperator findedOperator = null;

            while (withoutError == false)
            {


                try
                {

                    sampleOperator = Convert.ToChar(Read());
                    findedOperator = availableOperations.FirstOrDefault(ao => ao.NameOperator == sampleOperator);

                    if (findedOperator != null)
                    {
                        withoutError = true;
                    }
                    else
                    {
                        PrintOut("\n Wrong operation type, please type again!");
                    }


                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);

                }
            }

            return findedOperator;

        }

        public (bool, bool) OperationContinue(out bool userContinue, out bool numDefined)
        {
            PrintOut("\n Continue Operation? yes/no");
            string userAnswer = Read();
            userContinue = false;
            numDefined = false;

            if (userAnswer == "yes")
            {

                numDefined = true;
                userContinue = true;

            }
            else
            {
                userContinue = false;
                PrintOut("\n --------------------------" +
                    "\n Good bye! " +
                    "\n --------------------------");

            }
            return (numDefined, userContinue);



        }

        public double MustDoOperation(double number1, double number2)
        {
            throw new NotImplementedException();
        }
    }

}

