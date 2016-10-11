using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BodyAnalyser Body1 = new BodyAnalyser();

           
            Console.WriteLine($"resultat af bmi body1 {Body1.CalculateBMI(1.5, 30 )}");
            Console.WriteLine($"bmi analyse body1 {Body1.AnalyseBMI(1.5,30)}");

            BodyAnalyser Body2 = new BodyAnalyser();

            Console.WriteLine($"resultat af bmi body2 {Body2.CalculateBMI(1.9, 90)}");
            Console.WriteLine($"bmi analyse af body2 {Body2.AnalyseBMI(1.9,90)}");

            BodyAnalyser Body3 = new BodyAnalyser();

            Console.WriteLine($"resultat af bmi body3 {Body3.CalculateBMI(1.7, 200)}");
            Console.WriteLine($"bmi analyse af body3 {Body3.AnalyseBMI(1.7, 200)}");

          

            // The LAST line of code should be ABOVE this line
        }
    }
}
