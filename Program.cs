using System;
using HelloWorld.Math;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

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

            // TODO: access objects in a class

            // Person Andrew = new Person();
            // Andrew.FirstName = "Andrew";
            // Andrew.LastName = "Neely";
            // Andrew.Introduce();

            // string resultAdd = Calculator.Add(1, 2);
            // System.Console.WriteLine(resultAdd);
            // string resultSubtract = Calculator.Subtract(4, 1);
            // System.Console.WriteLine(resultSubtract);

            // System.Console.WriteLine("");
            // System.Console.WriteLine("Numbers array");

            // var numbers = new int[3] { 1, 2, 3 };

            // * for loop
            // for (int i = 1; i <= numbers.Length; i++)
            // {
            //     System.Console.WriteLine(i);
            // }

            // * presents all the numbers as a string
            // string list = string.Join(",", numbers);
            // System.Console.WriteLine(list);

            // TODO: format strictly
            // string path = @"./Math/NonPrimitives.cs";
            // System.Console.WriteLine(path);

            // var method = ShippingMethod.Express;
            // System.Console.WriteLine((int)method);

            var methodId = 3;
            // System.Console.WriteLine((ShippingMethod)methodId);

            // * convert enum to string
            // System.Console.WriteLine(method.ToString());

            // * convert string to enum
            // var methodName = "Express";
            // var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            // System.Console.WriteLine(shippingMethod);
        }
    }
}
