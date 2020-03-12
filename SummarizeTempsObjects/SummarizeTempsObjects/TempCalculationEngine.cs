using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int sumOfTemps = 0;

            // looop through all temps in list
            foreach (int temp in _temperatures)
            {
                sumOfTemps += temp;

            }

            int averageTemps = sumOfTemps / _temperatures.Count;
            return averageTemps;
                

          
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            int countTemps = 0;
            foreach (int temp in _temperatures)
            {
                if (temp > threshold)
                {
                    countTemps += 1;
                    //countTemps = countTemps + 1;
                }
                
            }
            return countTemps; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            int countTemps = 0;
            // add logic to calculate and return temps below the threshold
            foreach (int temp in _temperatures)
            {
                if (temp < threshold)
                {
                    countTemps += 1;
                }
            }
            return countTemps; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            int countTemps = 0;
            // add logic to calculate and return temps at the threshold
            foreach (int temp in _temperatures)
            {
                if (temp == threshold)
                {
                    countTemps += 1;
                }
            }
            return countTemps ; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
