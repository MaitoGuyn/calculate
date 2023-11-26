using System.IO;
using System.Linq;
using System.Linq.Expressions;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a mathematical expression:");
        string input = Console.ReadLine();

        double result = EvaluateExpression(input);
        Console.WriteLine("Result: " + result);
    }


    static int EvaluateExpression(string expression)
    {

        string[] parts = expression.Split(new char[] { '+', '-', '*', '/' });


        char[] operators = { '+', '-', '*', '/' };
        double result = double.Parse(parts[0]);
        int opertorindex = 0;
        for (int i = 1; i < parts.Length; i++)
        {


            while (opertorindex < expression.Length && !operators.Contains(expression[opertorindex]))
            {
                opertorindex++;
            }
            if (opertorindex == expression.Length)
            {
                Console.WriteLine("Invaliid operation");
                return 0;
            }
            double operand = double.Parse(parts[i]);
            char operation = expression[opertorindex];
            switch (operation)
            {
                case '+':
                    result += operand;
                    break;
                case '-':
                    result -= operand;
                    break;
                case '*':
                    result *= operand;
                    break;
                case '/':
                   
                    if(operand != 0)
                    {
                        result /= operand;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero");
                        return 0;
                    }
                    break;

            }

            opertorindex++;

        }

        return (int)result;


    }
}