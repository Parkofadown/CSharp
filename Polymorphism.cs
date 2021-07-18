using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Car
    {
        private string brand;
        public int HP { get; set; }
        public string Color { get; set; }

        public Car (int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Brand" + brand + " HP: " + HP + " Color: " + Color);
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired." );
        }
    }
    class BMW:Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW(int hp, string color, string model):base(hp, color)
        {
            this.Model = model;

        }
        public override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired ", Model);
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + " HP: " + HP + " Color: " + Color);
        }

    }
    class Audi : Car
    {

        private string brand = "Audi";
        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;

        }
        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired ", Model);
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + " HP: " + HP + " Color: " + Color);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "Blue", "A4"),
                new BMW(250,"Red", "M3")
            };
            foreach (var car in cars)
            {
                car.Repair();
                
            }

            Car bmwZ3 = new BMW(200, "Black", "Z3");
            Car AudiA3 = new Audi(100, "Green", "A3");
            bmwZ3.ShowDetails();
            AudiA3.ShowDetails();

            BMW bwmM5 = new BMW(330, "White", "M5");
            bwmM5.ShowDetails();
            Audi a4 = new Audi(150, "Black", "A4");
            a4.ShowDetails();

            Console.ReadKey();
        }
    }
}

  
