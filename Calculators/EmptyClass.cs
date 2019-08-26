using System;
namespace Calculators
{
    public class EmptyClass
    {


        private double firstnumber;
        private double secondnumber;
        private double result;
        private char operation;


        public EmptyClass(double first, double second, char oop)
        {
            firstnumber      = first;
            secondnumber     = second;
            operation        = oop;
            Switching();

        }

        private void Switching()
        {
            switch (operation)
            {
                case '+':
                    result = firstnumber + secondnumber;

                   Console.WriteLine("The sum of {0} and {1} is {2}",firstnumber,secondnumber,result);
                    startover();
                    break;

                case '-':
                    result = firstnumber - secondnumber;
                    Console.WriteLine("The diference {0} and {1} is {2}", firstnumber, secondnumber,result);
                    startover();
                    break;
                case '*':
                    result = firstnumber * secondnumber;
                    Console.WriteLine("The product of {0} and {1} is {2}", firstnumber, secondnumber,result);
                    startover();
                    break;
                case '/':
                    result = firstnumber / secondnumber;
                    Console.WriteLine("The division of {0} and {1} is {2}", firstnumber, secondnumber,result);
                    startover();
                    break;
                case '%':
                    result = firstnumber % secondnumber;
                    Console.WriteLine("The procent of {0} and {1} is {2}", firstnumber, secondnumber,result);
                    startover();
                    break;
                default:
                    Console.WriteLine("Invalid operation.Please enter valid operation in next time");
                    End();
                    break;
              
            }
        }
        private void startover()
        {
            Console.WriteLine("You want to do more? If \'yes\' then press enter (Y)." +
                "Else enter any key");
            string YesorNo = Console.ReadLine();
            bool mybool = (YesorNo == "y" || YesorNo == "Y");
            if(mybool == true)
            {
                repeat();

            }
            else
            {
                End();
            }
           
        }
        private void repeat()
        {
            firstnumber = result;
            Console.WriteLine("Input Second Number");
            secondnumber= double.Parse(Console.ReadLine());

            Console.WriteLine("choose an operation :  (+, -, *, /, %, ^)");
            operation = char.Parse(Console.ReadLine());

        }

        private void End()
        {
            Console.WriteLine("Final Result is {0}", result);
            Console.Write("Press any key to Exit the calculator");
            Console.ReadKey();

        }
        }
    }

