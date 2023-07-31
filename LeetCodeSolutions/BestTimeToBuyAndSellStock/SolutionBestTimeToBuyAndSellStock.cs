using System;
using System.Diagnostics;
using System.Linq;

namespace LeetCodeSolutions.BestTimeToBuyAndSellStock
{
    public class SolutionBestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                    minPrice = prices[i];

                int profit = prices[i] - minPrice;

                if (profit > maxProfit)
                    maxProfit = profit;
            }

            return maxProfit;
        }
    }
}

//[7,1,5,3,6,4]
//[1,2,5,3,6,7]
//[1,7,2,5,3,6]


//var min = prices.Min();
//var minDay = Array.LastIndexOf(prices, min);
//return minDay;