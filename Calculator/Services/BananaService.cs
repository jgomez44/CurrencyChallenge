using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Services
{
    public class BananaService
    {
        public double BananaPrice(DateTime startDate, int numberOfDays)
        {

            int day = startDate.Day;
            int iterations = day + numberOfDays;

            double totalCost = 0;

            for (int i = day; i < iterations; i++)
            {

                if (i <= 6)
                {
                    totalCost += 0.05;
                }
                else if (i >= 7 && day <= 13)
                {
                    totalCost += 0.10;
                }
                else if (i >= 14 && day <= 20)
                {
                    totalCost += 0.15;
                }
                else if (i >= 21 && day <= 28)
                {
                    totalCost += 0.20;
                }
                else if (i > 29)
                {
                    totalCost += 0.25;
                }
            }
            return totalCost;
        }
    }
}