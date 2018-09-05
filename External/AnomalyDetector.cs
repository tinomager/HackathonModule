using System;

namespace AzureIoTEdgeAnomalyDetectModule
{
    public class AnomalyDetector{
        private double tempMean;
        private double humMean;

        private double tempStdDev;

        private double humStdDev;

        public AnomalyDetector(double tempMean, double tempStdDeviation, double humMean, double humStdDeviation)
        {
            this.tempMean = tempMean;
            this.humMean = humMean;
            this.tempStdDev = tempStdDeviation;
            this.humStdDev = humStdDeviation;
        }

        public bool IsAnomaly(double temp, double hum){
            return Math.Abs(temp-tempMean) > (3 * tempStdDev) || 
                Math.Abs(hum - humMean) > (3 * humStdDev);
        }
    }
}