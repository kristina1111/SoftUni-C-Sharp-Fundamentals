using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E16PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            double vlmPool = double.Parse(Console.ReadLine());
            double pipe1 = double.Parse(Console.ReadLine());
            double pipe2 = double.Parse(Console.ReadLine());
            double hrsGone = double.Parse(Console.ReadLine());
            double pipesOut = pipe1 * hrsGone + pipe2 * hrsGone;
            //Console.WriteLine(pipesOut);
            if(pipesOut<= vlmPool)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",Math.Floor((pipesOut/vlmPool)*100), Math.Floor((pipe1*hrsGone/pipesOut)*100), Math.Floor((pipe2 * hrsGone / pipesOut) * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hrsGone, pipesOut-vlmPool);
            }

        }
    }
}
