using System;

namespace HelloWorld.Math
{
    public class Calculator
    {
        public static string Add(int a, int b)
        {
            string result = $"{a} + {b} = {a + b}";
            return result;
        }

        public static string Subtract(int a, int b)
        {
            string result = $"{a} - {b} = {a - b}";
            return result;
        }

        public static string Divide(int a, int b)
        {
            string result = $"{a} / {b} = {a / b}";
            return result;
        }

        public static string Multiply(int a, int b)
        {
            string result = $"{a} * {b} = {a * b}";
            return result;
        }
    }
}
