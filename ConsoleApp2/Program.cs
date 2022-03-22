using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ne qeder car olsun?");
            int car = int.Parse(Console.ReadLine());
            Car[] cars = new Car[car];




            for (int i = 0; i < cars.Length; i++)
            {

                Console.WriteLine("Color daxil edin");
                string Color = Console.ReadLine();
                Console.WriteLine("Brand daxil edin");
                string Brand = Console.ReadLine();
                Console.WriteLine("Millage daxil edin");
                double Millage = double.Parse(Console.ReadLine());
                Console.WriteLine("FuelCapast daxil edin");
                double FuelCapacity = double.Parse(Console.ReadLine());
                Console.WriteLine("Cari yanacaqi qeyd edin");
                double CurrentFuel = double.Parse(Console.ReadLine());
                Console.WriteLine("FuelForm1km daxil edin");
                double FuelFor1km = double.Parse(Console.ReadLine());
                cars[i] = new Car(Color, Brand, Millage, FuelCapacity, CurrentFuel, FuelFor1km);


            }
            bool bools = true;
            while (bools)
            {


                Console.WriteLine("1. Masinlari millage-e gore filtirle ");
                Console.WriteLine("2. Butun masinlari goster");
                Console.WriteLine("3. Prosesi bitir");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:

                        Console.WriteLine("Minimum deyeri daxil edin");
                        int min = int.Parse(Console.ReadLine());
                        Console.WriteLine("Maksimum deyeri daxil edin");
                        int max = int.Parse(Console.ReadLine());
                        Car[] FilteredShow = Millagefilter(cars, min, max);
                        foreach (Car item in FilteredShow)
                        {
                            Console.WriteLine(item.ShowInfo());

                        }


                        break;
                    case 2:
                        foreach (var item in cars)
                        {
                            Console.WriteLine(item.ShowInfo());

                        }
                        break;
                    case 3:
                        bools = false;

                        break;
                }
            }

        }
        static Car[] Millagefilter(Car[] cars, double minMillage, double maxMillage)
        {
            int count = 0;
            foreach (Car car in cars)
            {
                if (car.Millage >= minMillage && car.Millage <= maxMillage)
                {
                    count++;
                }
            }
            Car[] CarNew = new Car[count];
            count = 0;
            foreach (Car car in cars)
            {
                if (car.Millage >= minMillage && car.Millage <= maxMillage)
                {
                    CarNew[count] = car;
                    count++;
                }
            }
            return CarNew;
        }
    }
}