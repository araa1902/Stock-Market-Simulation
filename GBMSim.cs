using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace STOCKUI2
{
    internal class GenerateRandomNums
    {
        private int SimDays;
        private int NumOfSims;
        private double[,] RandomNumArray;
        private Random RandomVal;

        public GenerateRandomNums(int NumofSimulationDays, int NumofSimulations)
        {
            SimDays = NumofSimulationDays - 1;
            NumOfSims = NumofSimulations;
            RandomVal = new Random();

        }
        private static double GenerateRandomNum(double u1, double u2)
        {
            return Math.Sqrt(-2.0 * Math.Log(1 - u1)) * Math.Sin(2.0 * Math.PI * (1 - u2)); // Box-Muller Transform
        }
        public double[,] RandomNumbersGeneration()
        {
            RandomNumArray = new double[SimDays, NumOfSims];
            for (int Column = 1; Column < NumOfSims; Column++)
            {
                for (int Row = 1; Row < SimDays; Row++)
                {
                    double randval1 = 1.0 - RandomVal.NextDouble(); // Generates two uniform random numbers
                    double randval2 = 1.0 - RandomVal.NextDouble();
                    RandomNumArray[Row - 1, Column - 1] = GenerateRandomNum(randval1, randval2); // Asigns the standard normal random number to every index in the 2d array.
                }
            }
          return RandomNumArray;
        }

    }
    
    internal class SimulateGBM
    {
        private double Price0;
        private double Mu;
        private int SimulationDays;
        private int SimulationNum;
        private double[,] RandNumArray;
        private double Sigma;
        private double[,] SimulatedStockPrices;

        private double initaliseMu(double mu)
        {
            return mu / 100 / Math.Sqrt(252); // anualises the drift constant
        
        }
        private double initialiseSigma(double voltality)
        {
            return voltality / 100 / Math.Sqrt(252); // annualises the volatility constant.
        
        }
        public SimulateGBM(double[,] RandArray, double PriceAt0, double drift, double volatlity)
        {
            SimulationDays = RandArray.GetLength(0); // Gets interval points for both the sim days and number of sims
            SimulationNum = RandArray.GetLength(1);
            RandNumArray = RandArray; // Has new instance of the 2d array to be assigned to the random array generated earlier.
            SimulatedStockPrices = new double[SimulationDays + 1, SimulationNum];
            this.Price0 = PriceAt0;
            Mu = initaliseMu(drift); // Initliased the drift and voltatlity constants entered by users to be annualised for use
            Sigma = initialiseSigma(volatlity);

            for (int column = 1; column < SimulationNum+1; column++)
            {
                SimulatedStockPrices[0, column - 1] = Price0; // Sets the first simulation as the initial price so each simulation starts on the same data specified by user.
            
            }
        }
        public void GBMSimulation()
        {
            for (int sim = 0; sim < SimulationNum; sim++)
            {
                for (int day = 1; day <= SimulationDays; day++)
                {
                    SimulatedStockPrices[day, sim] = Math.Round( SimulatedStockPrices[day - 1, sim] + SimulatedStockPrices[day - 1, sim] * Mu + SimulatedStockPrices[day - 1, sim] * Sigma * RandNumArray[day - 1, sim], 2); // Stochastic diffrential process.
                    // follows the Geometric Brownian Motion equation.
                }
            }
        }
        public double[,] returnGBMSimulation()
        {
            return SimulatedStockPrices;
        }
    }
}
