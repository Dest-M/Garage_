using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using GarageClass;
using System.Runtime.ConstrainedExecution;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            int choice = 0;
            List<Garage> garages = new List<Garage>();
            while (true)
            {
                Console.WriteLine("Welcome to the garage creator! \n Would you like to:\n 1 - New Garage\n 2 - Add car\n 3 - Display cars\n 4 - Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {

                    Console.WriteLine("Enter Address");
                    string address = Console.ReadLine();
                    Console.WriteLine("Enter Size (meters^2)");
                    float size = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Owner Name");
                    string owner = Console.ReadLine();
                    Garage gar = new Garage(i+1, address, size, owner);
                    garages.Add(gar);
                    i++;
                }
                else if (choice == 2 && i != -1)
                {
                    Console.WriteLine("Enter Car Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Color");
                    string color = Console.ReadLine();
                    Console.WriteLine("Enter Horsepower");
                    int horsepower = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number");
                    string number = Console.ReadLine();

                    Car car = new Car(name, color, horsepower, number);
                    garages[i].addCar(car);
                }
                else if (choice == 3 && i != -1)
                {
                    foreach (Garage ga in garages)
                    {
                        Console.WriteLine("Garage id: "+ Convert.ToString(ga.id) + " Addresss: " + ga.address + " Size: " + Convert.ToString(ga.metersSize) + " Owner: " + ga.owner + "\n--------------------------------------------------");
                        foreach (Car ca in ga.cars)
                        {
                            Console.WriteLine("Horsepower: " +Convert.ToString(ca.horsepower) + " Name: " + ca.name + " Color: " + ca.color + " Number: " + ca.number);

                        }
                        Console.WriteLine("============================================================\n\n");
                    }
                }
                else if(choice == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Create a garage first");
                }
            }
        }
    }
}

