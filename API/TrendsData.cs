using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOCKUI2
{
    internal class Trends : API
    {

        private static double smoothconst;
        private const double bullishThreshold = 0.1; // Creates constants for both bullish and bearish scenarios - used in comparing the confidence of buying or selling a stock.
        private const double bearishThreshold = -0.1;


        public Trends(List<Values> values)
        {
            smoothconst = 2 / (1 + values.Count);
        }
        #region TrendsCode
        public override List<string> Initalise_timeseries(List<string> timeseries, string interval, int type)
            // Overriding method from API class to intitalise dates for API retrieval of data.
        {

            string dateTime = DateTime.Now.ToString(); 
            string now = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
            string minustime = DateTime.Today.AddDays(-150).ToString();
            string time = Convert.ToDateTime(minustime).ToString("yyyy-MM-dd");
            timeseries.Add(now);
            timeseries.Add(time);
            return timeseries;

        }

        private static double FindSimpleMovingAverage(List<Values> prices)
        {
            // Method used to retrieve the first value for calculating the expotential moving average of stock data
            // Used simple moving average algorithm
            double total = 0;
            for (int j = 0; j < prices.Count; j++)
            {
                total += prices[j].GetClose();
            
            }
            double avg = total / prices.Count;
            return avg;

        }
        public static double FindPercentConfidence(double MACD)
        {
            // Method of calculating the percent confidence of stock by calculating the absolute distance the MACD value is from threshold value.
            // Threshold value differs depending on its trend status.
            if (MACD > 0)
            {
                double distance = Math.Abs(MACD - bullishThreshold);
                return distance;
            }
            else
            {
                double distance = Math.Abs(MACD - bearishThreshold);
                return  distance;
            }
           
        }
        private static double FindExpotentialMovingAverage(double todayPrice, double currentEMA)
        {
            return (todayPrice * smoothconst) + (currentEMA * (1 - smoothconst));
            // Exponential Moving Average algorithm
        }

        public static double EMAPrices(List<Values> Prices, int interval)
        {
            // Method of looping through each price in the Prices list via API. Uses SMA value as the beginning value. 
            double EMAVal = FindSimpleMovingAverage(Prices);
            for (int i = interval; i < Prices.Count; i++)
            {
                // Changes the exponential moving average model depending on the previous value of the EMA and current price at index i
                EMAVal = FindExpotentialMovingAverage(Prices[i].GetClose(), EMAVal);
                
            }
            return EMAVal;
        }

  
        public static Decision BuyOrSell(List<Values> Prices) // Create method of form 'Decision' linking with the enumeration
        {
           
            // MACD = 12 - 26
            double MACD = GetMACDval(Prices); // Retrieves MACD value through the equation of calculating the EMA value of the 12 day period - 26 day period
            
            if (MACD > 0)
            {
                return Decision.Buy; // Uses MACD model to provide outcome of analysis

            }
            else if (MACD < 0)
            {
                return Decision.Sell; 

            }
            else
            {
                return Decision.Hold;
            }
        
        }
        public static double GetMACDval(List<Values> prices)
        {
            return EMAPrices(prices, 12) - EMAPrices(prices, 26);
        
        }

        #endregion
    }
    

    public enum Decision // Use of class enumeration. Since there are three different outcomes to a price prediction, an enum is suitable to provide a definive outcome of the analysis in a readable way.
    {
        Buy,
        Sell,
        Hold
    }
       
    }

    


  
   


