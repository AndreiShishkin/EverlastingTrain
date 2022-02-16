using EverlastingTrain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverlastingTrain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train tr = new Train();
            List<Car> cars = new List<Car>();
            cars = tr.FillingTrain();
            cars[0].lightIsOn = true;

            int step;
            for (step = 1;  step < cars.Count; step++)
            {
                if (step >= cars.Count)
                    step = cars.Count - step;
                if (cars[step].lightIsOn)
                {
                cars[step].lightIsOn = false;
                    if (cars[step].lightIsOn == cars[0].lightIsOn)
                    {
                        step++;
                        break;
                    }
                }
            }
            Console.WriteLine(step);
            Console.ReadLine();
        }
    }
}
