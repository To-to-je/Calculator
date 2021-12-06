
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
   

            string oneMoreTime = "yes"; // the variable for looping the program unless you will want to stop



            while (oneMoreTime == "yes")
            {

                Console.WriteLine("Hello and welcome to the Calculator");

                // declare variable to use it in try/catch
                double answer = 1;
                
                Console.WriteLine("\n Please type the 1st number: \n");

                // looping condition
                bool statement1 = false;

                // declare variable to use it in try/catch
                double input1 = 1;

                // looping unless you enter the right value
                while (statement1 == false)
                {
                    try
                    {
                        input1 = Convert.ToDouble(Console.ReadLine());
                        statement1 = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error occured, type the number...\n");
                    }

                }

                Console.WriteLine("\n Please type the 2nd number: \n");


                // the same procedure as for 1st number

                bool statement2 = false;
                double input2 = 1;
                while (statement2 == false)
                {
                    try
                    {
                        input2 = Convert.ToDouble(Console.ReadLine());
                        statement2 = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error occured, type the number...\n");
                    }

                }

                Console.WriteLine("\n Please, type the arithmetic operator " +
                    "\n (+, -, /, *) \n");



                // thanks to this string we will check if the operator is right one

                string[] symbols = { "+", "-", "*", "/" };

                bool statement3 = false;

                
                // loop for the right input and switch for different arithmetic operations

                while (statement3 == false)
                {

                    string arithOper = Console.ReadLine();

                    if (symbols.Contains(arithOper))
                    {
                        switch (arithOper)
                        {
                            case "+":
                                answer = input1 + input2;
                                statement3 = true;
                                break;

                            case "-":
                                answer = input1 - input2;
                                statement3 = true;
                                break;

                            case "*":
                                answer = input1 * input2;
                                statement3 = true;
                                break;

                            case "/":
                                answer = input1 / input2;
                                statement3 = true;
                                break;

                            default:

                                Console.WriteLine("No operation executed");
                                break;

                        }


                    }

                    else
                    {
                        Console.WriteLine("Please, type valid operator");
                    }

                    Console.WriteLine("\n The answer is " + answer);

                }

                


                bool statement4 = false;


                // lets check if the user wants to continue having fun

                while (statement4 == false)
                {
                    Console.WriteLine("\n Do you want to continue? (type 'yes' or 'no' )");
                    string again = Console.ReadLine();

                    if (again.Contains("yes") || again.Contains("no"))
                    {
                        oneMoreTime = again;
                        statement4 = true;
                        Console.Clear();

                    }
                    else
                    {

                        Console.WriteLine("\n Please, type 'yes' or 'no'... ");
                        
                    }

                }

                


                

                

            }


        }
    }

}








