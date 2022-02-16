using EverlastingTrain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverlastingTrain
{
    internal class Train
    {
        public List<Car> FillingTrain()
        {
            List<Car> result = new List<Car>();
            Random rnd = new Random();
            int count = rnd.Next(0, 100);
            for (int i = 0; i < count - 1; i++)
            {
                Car car = new Car();
                car.numOfCar = rnd.Next(0, 100);
                car.lightIsOn = Convert.ToBoolean(rnd.Next(0, 2));
                result.Add(car);
            }
            return result;
        }
    }
}
