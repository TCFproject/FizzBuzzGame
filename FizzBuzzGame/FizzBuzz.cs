using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    public class FizzBuzz
    {
        public static string BobRepond(int nb)
        {
            if(nb % 3 == 0 && nb != 15)
            {
                return "Fizz";
            }
            if(nb % 5 == 0 && nb != 15)
            {
                return "Buzz";
            }
            return "FizzBuzz";
        }
    }
}
