// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = new Vehicle("Generic", 10000, 100, 4);
        vehicles[1] = new Lorry("LorryBrand", 5000, 200, 6, 5000);
        vehicles[2] = new Car("CarBrand", 20000, 150, 4, 5);

        while (true)
        {
            Console.WriteLine("Виберіть завдання:");
            Console.WriteLine("1. Зміна потужності та величини пробігу для машини");
            Console.WriteLine("2. Зміна вантажопідйомності та кількості пасажирів для вантажівки та автомобіля");
            Console.WriteLine("3. Порівняння об'єктів");
            Console.WriteLine("4. Показати інформацію про об'єкти");
            Console.WriteLine("5. Вихід");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Зміна потужності та величини пробігу для машини
                    Console.WriteLine("Введіть нову потужність:");
                    int newPower = int.Parse(Console.ReadLine());
                    vehicles[0].Power = newPower;

                    Console.WriteLine("Введіть новий пробіг:");
                    double newMileage = double.Parse(Console.ReadLine());
                    vehicles[0].Mileage = newMileage;

                    break;
                case 2:
                    // Зміна вантажопідйомності та кількості пасажирів для вантажівки та автомобіля
                    Console.WriteLine("Введіть нову вантажопідйомність для вантажівки:");
                    double newLoadCapacity = double.Parse(Console.ReadLine());
                    ((Lorry)vehicles[1]).LoadCapacity = newLoadCapacity;

                    Console.WriteLine("Введіть нову кількість пасажирів для автомобіля:");
                    int newPassengerCount = int.Parse(Console.ReadLine());
                    ((Car)vehicles[2]).PassengerCount = newPassengerCount;

                    break;
                case 3:
                    // Порівняння об'єктів
                    Console.WriteLine("Введіть номери об'єктів для порівняння (через пробіл):");
                    string[] objectNumbers = Console.ReadLine().Split(' ');

                    int object1 = int.Parse(objectNumbers[0]) - 1;
                    int object2 = int.Parse(objectNumbers[1]) - 1;

                    bool isEqual = vehicles[object1].Equals(vehicles[object2]);
                    Console.WriteLine($"Об'єкт {object1 + 1} {(isEqual ? "рівний" : "не рівний")} об'єкту {object2 + 1}");

                    break;
                case 4:
                    // Показати інформацію про об'єкти
                    foreach (var vehicle in vehicles)
                    {
                        vehicle.ShowInfo();
                        Console.WriteLine("-------------");
                    }

                    break;
                case 5:
                    // Вихід з програми
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Невірний вибір");
                    break;
            }
        }
    }
}

