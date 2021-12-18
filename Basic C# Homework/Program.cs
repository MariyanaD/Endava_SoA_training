using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endava_BuyCars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person Mimi = new Person("Mariyana Doy", 34);
            Person Yuri = new Person("Yuri Grigorov");
            Person Ivaylo = new Person();

            Mimi.Money = 1500;
            Yuri.Money = 500;
            Ivaylo.Money = 10000;

            Console.WriteLine(Mimi.Name);
            Console.WriteLine(Mimi.Age);

            Console.WriteLine(Yuri.Age);
            Console.WriteLine(Yuri.Name);

            Console.WriteLine(Ivaylo.Age);
            Console.WriteLine(Ivaylo.Name);

            Car mercedes = new Car("S500", false, "Yellow");
            Car bmw = new Car("X5", false, "Pink");
            Car lada = new Car("Jiguli", true, "White");

            lada.ChangeColor("Black");
            bmw.ChangeColor("Red");

            Car ford = new Car("Escort", true, "Pink", 1000, 100);
            Car kia = new Car("Sportage", true, "Brown", 1500, 100);
            Car kia2 = new Car("Sportage2", true, "Brown", 1500, 100);

            bool isTheFordMoreExpensive = ford.IsMoreExpensive(kia);
            Console.WriteLine("isTheFordMoreExpensive = " + isTheFordMoreExpensive);

            bool isKiaMoreExpensive = kia.IsMoreExpensive(ford);
            Console.WriteLine("isKiaMoreExpensive = " + isKiaMoreExpensive);

            Console.WriteLine(Mimi.Money);

            Mimi.BuyCar(kia);

            Console.WriteLine(Mimi.MyCar.Model);
            Console.WriteLine(Mimi.Money);


            Console.WriteLine(Ivaylo.Money);
            Ivaylo.BuyCar(ford);
            Console.WriteLine(Ivaylo.MyCar.Model);
            Console.WriteLine(Ivaylo.Money);

            Yuri.BuyCar(kia2);
        }
    }
}

