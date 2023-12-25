class Program
{
    static void Main()
    {
        // Создаем объект Avto
        Avto myCar = new Avto("", 0, 0);

        // Вводим информацию о машине
        Console.Write("Введите номер автомобиля: ");
        string number = Console.ReadLine();

        Console.Write("Введите объем бака: ");
        float fuelVolume = float.Parse(Console.ReadLine());

        Console.Write("Введите расход топлива на 100 км: ");
        float fuelConsumption = float.Parse(Console.ReadLine());

        // Инициализация объекта Avto
        myCar.Info(number, fuelVolume, fuelConsumption);

        // Выводим информацию о машине
        myCar.Out();

        // Запускаем цикл управления машиной
        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Ехать");
            Console.WriteLine("2. Заправиться");
            Console.WriteLine("3. Разогнаться");
            Console.WriteLine("4. Тормозить");
            Console.WriteLine("5. Вывести информацию о машине");
            Console.WriteLine("6. Выйти");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введите расстояние к следующей точке: ");
                    int distance = int.Parse(Console.ReadLine());
                    myCar.Move(distance);
                    break;
                case 2:
                    Console.Write("Введите количество топлива для заправки: ");
                    float fuelToAdd = float.Parse(Console.ReadLine());
                    myCar.Zapravka(fuelToAdd);
                    break;
                case 3:
                    Console.Write("Введите ускорение: ");
                    float acceleration = float.Parse(Console.ReadLine());
                    myCar.Razgon(acceleration);
                    break;

                case 4:
                    Console.Write("Введите замедление: ");
                    float deceleration = float.Parse(Console.ReadLine());
                    myCar.Tormozhenie(deceleration);
                    break;
                case 5:
                    myCar.Out();
                    break;
                case 6:
                    // Выход из цикла
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Пожалуйста, выберите снова.");
                    break;
            }
        }
    }
}
