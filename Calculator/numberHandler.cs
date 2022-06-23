using System;

namespace Calculator
{
    public class numberHandler
    {


        public static float firstNumber { get; private set; }
        public static float secondNumber { get; private set; }
        private static bool first = true;
        public static char op { get; private set; }

        public static float computeEquation(float num1, char oper, float num2)
        {
            if(first) { return 404f; }
            
            float answer = 404f;
            switch (oper)
            {
                case '+':
                    answer = num1 + num2;
                    break;
                case '-':
                    answer = num1 - num2;
                    break;
                case '*':
                    answer = num1 * num2;
                    break ;
                case '/':
                    answer = num1 / num2;
                    break;
                default:
                    break;
            }
            first = true;
            resetNumbers();
            return answer;
        }

        public static void operation(char operation)
        {
            op = operation;
            first = false;
        }

        public static void setNumbers(float number)
        {
            if (first)
            {
                firstNumber = firstNumber * 10 + number;
                Calculator.Instance.displayNumber(firstNumber);
            } else if (!first) {
                secondNumber = secondNumber * 10 + number;
                Calculator.Instance.displayNumber(secondNumber);
            }
            
        }

        public static void resetNumbers()
        {
            firstNumber = 0;
            secondNumber = 0;
            Calculator.Instance.resetDisplay();
        }
    }
}