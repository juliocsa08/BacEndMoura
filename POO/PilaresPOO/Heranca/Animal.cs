using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Heranca
{
    public class Animal
    {
        public virtual void FazerSom()
        {
            Console.WriteLine("O animal faz um som.");
        }
    }
}