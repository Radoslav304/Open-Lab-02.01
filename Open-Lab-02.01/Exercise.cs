using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            double[] numbers = { 1.3, 2.3, 3.3, 4.5, 5.8 };
            return numbers;
        }

        public double GetSecond(double[] numbers)
        {
            return numbers[1];
        }
    }
}