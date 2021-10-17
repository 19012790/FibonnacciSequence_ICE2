using System;
using System.Collections.Generic;

namespace FibonnacciSequence_ICE2
{
    class Program
    {
        static Dictionary<int, long> _memo = new Dictionary<int, long>() { { 0, 0 }, { 1, 1 } }; //dictonary created

            static void Main(string[] args)
            {
                Console.WriteLine("Press 1 to create fibonnaci without memoization or press 0 to generate fibonnaci using memoization");//prints message instrctuing user what option to choose 
                int option = Convert.ToInt32(Console.ReadLine());  
                if (option == 1) // if the user selects 1 
                {
                    for (int i = 0; i < 75; i++)
                    {
                        Console.WriteLine($"Fib({i}) = {Fib(i)}"); //prints fibbonaci without memoization
                    }
                }
                else //else statment
                {
                    if (option == 0) //if user selects option 0 
                    {
                        for (int i = 0; i < 75; i++)
                        {
                            Console.WriteLine($"FibM({i}) = {FibM(i)}");//prints fibbonaci with memoization
                        }
                    }

                }
            }

            static long Fib(int n)  //fibonnaci without memoization method 
            {
                if (n < 2) return n;

                return Fib(n - 1) + Fib(n - 2); //returns fibbaonci without the use of memoization
            }

            static long FibM(int n) //fibbaonci with memoization method
            {
                if (_memo.ContainsKey(n)) //if statment created
                    return _memo[n];

                var value = FibM(n - 1) + FibM(n - 2);

                _memo[n] = value;

                return value; //returns fibbanoci with memoization 
            }

           
        }
    }

