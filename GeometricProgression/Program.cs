﻿using System;

namespace ArithmeticProgression
{
    class Program
    {
       
            static void Main(string[] args)
            {
                ArithmeticProgression ap = new ArithmeticProgression();
                GeometricProgression gp = new GeometricProgression();
                Console.WriteLine("Арифметическая прогрессия: \n");
                PrintSeries(ap, 7);
                Console.WriteLine("Геометрическая прогрессия: \n");
                PrintSeries(gp, 7);
            }

            public static void PrintSeries(ISeries series, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    series.MoveNext();
                    Console.WriteLine(series.GetCurrent());
                }
            }
        
    }
}
