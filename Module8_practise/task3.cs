using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8_practise
{
    public class task3
    {
        double[] salesData = { 100, 120, 130, 140, 150 };
        int[] months = { 1, 2, 3, 4, 5, 6, 7, 8 };
        static void CalculateLinearTrend(double[] x, double[] y, out double a, out double b)
        {
            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sumX += x[i];
                sumY += y[i];
                sumXY += x[i] * y[i];
                sumX2 += x[i] * x[i];
            }

            a = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            b = (sumY - a * sumX) / n;

        }
        
}
    class Task
    {
        private static object salesData;
        private static object months;

        static void Main() 
        {
            double a, b;
            CalculateLinearTrend(months, salesData, out a, out b);
            double[] forecastedSales = new double[3];
            for (int i = 0; i < 3; i++)
            {
                forecastedSales[i] = a * (i + 6) + b;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Monthly forecast {i + 6}: {forecastedSales[i]}");
            }
        }

        private static void CalculateLinearTrend(object months, object salesData, out double a, out double b)
        {
            throw new NotImplementedException();
        }
    }
}
