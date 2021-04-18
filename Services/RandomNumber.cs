using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorama.Services
{
    class RandomNumber
    {
        Random rn = new Random();
        public int getNumber(int min, int max)
        {
            return rn.Next(min, max);

        }
    }
}
