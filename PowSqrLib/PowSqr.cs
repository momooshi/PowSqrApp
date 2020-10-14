using System;

namespace calc
{
    public class PowSqr
    {              
       public static double pow(double a, double b)
        {
            if (b == 0)
            {
                return 1;
            }
            if (((Int32) b & 1) == 0)
            {
                var p = pow(a, (Int32)b >> 1 );
                return p * p;
            }
            else return a * pow(a, b - 1);

        }
        public static double sqr(double a, double b)
        {
            double res = a;
            double prev = res;

           if (((b % 2) == 0) && (a < 0)) { return 0; }
                            
                    do
                    {
                        prev = res;
                        res = (((b - 1) * res) + (a / pow(res, (b - 1)))) / b;   //итерационная формула вычисления степени через приближение

                    } while (((prev - res) > 0.0000001) || (res - prev) > 0.0000001);
                
            
            
             return res;
        }
    }
}
