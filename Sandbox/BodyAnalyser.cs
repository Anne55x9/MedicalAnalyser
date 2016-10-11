using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class BodyAnalyser
    {
        // Given the weight and height of a person, return the BMI
        public double CalculateBMI(double heightInMeters, double weightInKilo)
        {
            double bmi = weightInKilo / (heightInMeters * heightInMeters);
            return bmi;
        }

        // Given the weight and height of a person, return a brief analysis
        // of the BMI of that person
        public String AnalyseBMI(double heightInMeters, double weightInKilo)
        {
            // The below code must be changed
            String analysis = "";
            if (CalculateBMI(heightInMeters, weightInKilo) <= 15)
            {
                analysis = "You are way too skinny!";
            }
            else if(CalculateBMI(heightInMeters, weightInKilo) > 15 && CalculateBMI(heightInMeters,weightInKilo) <= 22)
            {
                analysis = "You are a bit skinny!";
            }
            else if(CalculateBMI(heightInMeters,weightInKilo) > 22 && CalculateBMI(heightInMeters,weightInKilo) <= 28)
            {
                analysis = "You are just fine!";
            }
            else if(CalculateBMI(heightInMeters,weightInKilo) > 28 && CalculateBMI(heightInMeters,weightInKilo) <= 35)
            {
                analysis = "You are a bit overweight!";
            }
            
            else
            {
                analysis = "You are way too fat!";
            } 

            return analysis;
        }

    }
}
