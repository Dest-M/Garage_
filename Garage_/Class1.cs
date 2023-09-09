
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace GarageClass
{
    public class Car
    {
        public string name;
        public string color;
        public int horsepower;
        public string number;
        public Car(string name, string color, int horsepower, string number)
        {
            this.name = name;
            this.color = color;

            this.horsepower = horsepower;
            this.number = number;

        }
    }
    internal class Garage
    {
        public List<Car> cars = new List<Car>();
        public int id;
        public string address;
        public float metersSize;
        public string owner;
        public Garage(int num, string address, float metersSize, string owner)
        {
            id = num;
            this.address = address;
            this.metersSize = metersSize;
            this.owner = owner;

        }
        public void addCar(Car car)
        {
            cars.Add(car);

        }
        public void removeCar(Car car)
        {
            cars.Remove(car);
        }
        public void output()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
