﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IOperator{
        double MustDoOperation(double number1, double number2);

        char NameOperator { get; }
    }
    internal interface ICalculation : IOperator
    {

        abstract void PrintOut(string words);


        abstract double Calculate();

       
        char Operator { get;
            }


    }

    public class MinusOperator: IOperator
    {
        public char NameOperator => '-';

        public double MustDoOperation(double input1, double input2)
        {

            double answer = input1 - input2;

            return answer;

        }

    }
    public class AddOperator:IOperator
    {
        public char NameOperator =>  '+';

        public double MustDoOperation(double input1, double input2)
        {

            double answer = input1 + input2;

            return answer;

        }

    }

    public class DivideOperator : IOperator
    {

        public char NameOperator => '/';

        public double MustDoOperation(double input1, double input2)
        {

            double answer = input1 / input2;

            return answer;

        }



    }

    public class MultiplyOperator : IOperator 
    {

        public char NameOperator => '*';

        public double MustDoOperation(double input1, double input2)
        {

            double answer = input1 * input2;

            return answer;

        }


        

    }






}
