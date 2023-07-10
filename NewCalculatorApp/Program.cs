﻿using System;

namespace NewCalculatorApp
{
    class Program
    {

        private const double _MIN_VALUE_Double = -1000;
        private const double _MAX_VALUE_Double = 1000;
        private const int _MIN_QTY_Int = 2;
        private const int _MAX_QTY_Int = 12;

        static void Main(string[] args)
        {
            double inputDouble = 0;
            double totalDouble = 0;
            bool OKBool = true;
            int quantityInt;

            double[] _inputValuesDoubleArray;


            Console.WriteLine("Calculator App");

            Console.Write("\nHow many numbers do you want to add together? (Enter a value between 2 and 12): ");
            quantityInt = int.Parse(Console.ReadLine());

            if ((quantityInt < _MIN_QTY_Int) || (quantityInt > _MAX_QTY_Int))
            {
                Console.WriteLine(
                    "\nQuantity, {0}, is not within range of {1} and {2}. Re-enter the value.\n",
                    quantityInt, _MIN_QTY_Int, _MAX_QTY_Int);
            }
            else
            {
                _inputValuesDoubleArray = new double[quantityInt];

                for (int indexInt = 0; indexInt < quantityInt; indexInt++)
                {
                    OKBool = false;
                    do
                    {
                        Console.Write("\nEnter a number value: ");
                        inputDouble = double.Parse(Console.ReadLine());

                        if ((inputDouble < _MIN_VALUE_Double) || (inputDouble > _MAX_VALUE_Double))
                        {
                            Console.WriteLine(
                                "\nInput number, {0}, is not within range of {1} and {2}. Re-enter value.\n",
                                inputDouble, _MIN_VALUE_Double, _MAX_VALUE_Double);
                            OKBool = false;
                        }
                        else
                        {
                            _inputValuesDoubleArray[indexInt] = inputDouble;
                            OKBool = true;
                        }
                    } while (OKBool == false);
                }

                for (int indexInt = 0; indexInt < quantityInt; indexInt++)
                {
                    totalDouble += _inputValuesDoubleArray[indexInt];
                }

                Console.WriteLine("\nTotal: {0}\n", totalDouble);
            }

            Console.Write("Press ENTER end program.");
            Console.ReadLine();
        }
    }
}
