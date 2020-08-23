using System;

namespace MyMath
{
    public class Class1
    {
    }

    public class Rooter
    {
        public double SquareRoot(double input)
        {
            if (input <= 0.0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var result = input;
            var previousResult = -input;
            while (Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = (result + input / result) / 2;
            }
            return result;
        }
    }
}
