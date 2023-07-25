using System;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte number = 2;
            // int count = 10;
            // float totalPrice = 20.95f;
            // char character = 'A';
            // string firstName = "Andrew";
            // bool isWorking = false;

            // var number = 2;
            // var count = 10;
            // var totalPrice = 20.95f;
            // var character = 'A';
            // var firstName = "Andrew";
            // var isWorking = false;

            // System.Console.WriteLine(number);
            // System.Console.WriteLine(count);
            // System.Console.WriteLine(totalPrice);
            // System.Console.WriteLine(character);
            // System.Console.WriteLine(firstName);
            // System.Console.WriteLine(isWorking);


            // TODO Casting int to byte

            // int i = 1;
            // byte b = ((byte)i);
            // System.Console.WriteLine(b);

            // TODO: Casting string to int

            // string num = "250";
            // * convert method
            // int number = Convert.ToInt32(num);
            // * parse method
            // int number = int.Parse(num);
            // System.Console.WriteLine(number);

            // TODO: Conversion with try catch block

            // try
            // {
            //     string number = "1234";
            //     byte b = Convert.ToByte(number);
            //     System.Console.WriteLine(b);
            // }
            // catch (Exception)
            // {
            //     System.Console.WriteLine("does not convert");
            // }

            // TODO: accurately divide integers

            // int a = 10;
            // int b = 3;
            // System.Console.WriteLine((float)a / (float)b);

            Person Andrew = new Person();
            Andrew.FirstName = "Andrew";
            Andrew.LastName = "Neely";
            Andrew.Introduce();

            string resultAdd = Calculator.Add(1, 2);
            System.Console.WriteLine(resultAdd);
            string resultSubtract = Calculator.Subtract(4, 1);
            System.Console.WriteLine(resultSubtract);
        }
    }
}
