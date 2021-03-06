﻿using System;
using System.Globalization;

namespace Lab1Console
{
    internal class FooCalculator
    {
        private static readonly IFormatProvider RussianCulture = new CultureInfo("ru-RU");


        private static void Main(string[] args)
        {
            var variants = new string[]
            {
                "Exit",
                "Foo 1",
                "Foo 2"
            };

            while (true)
            {
                var choice = ReadVariantFromConsole(variants);

                switch (choice)
                {
                case 0:
                    return;

                case 1:
                    DoFirstFoo();
                    break;

                case 2:
                    DoSecondFoo();
                    break;
                }
            }
        }
        

        private static double ReadDoubleFromConsole(string inputPrompt)
        {
            while (true)
            {
                Console.Write(inputPrompt);
                var read = Console.ReadLine();

                double number;
                try
                {
                    number = double.Parse(read ?? throw new InvalidOperationException(), NumberStyles.Float,
                        RussianCulture);
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input, try again");
                    continue;
                }

                return number;
            }
        }

        private static int ReadVariantFromConsole(string[] variants)
        {
            while (true)
            {
                for (var i = 0; i < variants.Length; ++i)
                    Console.WriteLine("{0}. {1}", i + 1, variants[i]);

                var userInput = Console.ReadLine();
                int choice;
                try
                {
                    choice = int.Parse(userInput);
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input, try again");
                    continue;
                }

                if (0 < choice && choice <= variants.Length)
                    return choice - 1;

                Console.WriteLine("Wrong input, try again");
            }
        }


        private static void DoFirstFoo()
        {
            while (true)
            {
                var x = ReadDoubleFromConsole("X = ");
                var y = ReadDoubleFromConsole("Y = ");
                var z = ReadDoubleFromConsole("Z = ");


                var validationErrors = ValidateFirstFooArgs(x, y, z);

                if (null == validationErrors)
                {
                    Console.WriteLine("Result = {0}", CalculateFirstFoo(x, y, z));
                    return;
                }

                Console.WriteLine(validationErrors);
            }
        }

        private static double CalculateFirstFoo(double x, double y, double z)
        {
            return Math.Pow(2, -x) *
                   Math.Sqrt(x + Math.Pow(Math.Abs(y), 1.0 / 4)) *
                   Math.Pow(Math.Exp((x - 1) / Math.Sin(z)), 1.0 / 3);
        }

        private static string ValidateFirstFooArgs(double x, double y, double z)
        {
            if (x + Math.Pow(Math.Abs(y), 1.0 / 4) < 0)
                return "X + abs(Y) ^ 4 should be >= 0";

            return null;
        }


        private delegate double F(double x);

        private static void DoSecondFoo()
        {
            while (true)
            {
                var functionIndex = ReadVariantFromConsole(new[]
                {
                    "sh(x)",
                    "x^2",
                    "e^x"
                });

                var x = ReadDoubleFromConsole("X = ");
                var q = ReadDoubleFromConsole("Q = ");

                var functions = new F[3]
                {
                    Math.Sinh,
                    arg => arg * arg,
                    Math.Exp
                };

                var validationErrors = ValidateSecondFooArgs(x, q, functions[functionIndex]);

                if (null == validationErrors)
                {
                    Console.WriteLine("Result = {0}", CalculateSecondFoo(x, q, functions[functionIndex]));
                    return;
                }

                Console.WriteLine(validationErrors);
            }
        }

        private static double CalculateSecondFoo(double x, double q, F f)
        {
            var abs = Math.Abs(x * q);

            if (Math.Abs(10 - abs) < double.Epsilon)
                return f(x) + q;

            if (abs > 10)
                return Math.Log(Math.Abs(f(x)) + Math.Abs(q));

            return Math.Exp(f(x) + q);
        }

        private static string ValidateSecondFooArgs(double x, double q, F f)
        {
            var result = CalculateSecondFoo(x, q, f);

            if (double.IsNaN(result) || double.IsInfinity(result))
                return "Cannot calculate function with current arguments";

            return null;
        }
    }
}
