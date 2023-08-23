string path;
bool flag = true;

while (flag == true)
{
    Console.WriteLine("\nВыберите категорию анекдотов из предложенных: Автомобили и транспорт, Брак, Теща, Психушка\n");
    string category = Console.ReadLine();
    switch (category)
    {
        case "Автомобили и транспорт":
            path = @"C:\Users\-LENOVO-\OneDrive\Рабочий стол\Maybe future\C#\Jokes\Jokes\CarsAndTransport.txt";
            string[] array1 = File.ReadAllLines(path);
            Console.WriteLine("\n");
            foreach (string line in array1)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("\nЕсли хотите продолжить введите true, если хотите выйти введите false\n");
            flag = Convert.ToBoolean(Console.ReadLine());
            break;
        case "Брак":
            path = @"C:\Users\-LENOVO-\OneDrive\Рабочий стол\Maybe future\C#\Jokes\Jokes\Marriage.txt";
            string[] array2 = File.ReadAllLines(path);
            Console.WriteLine("\n");
            foreach (string line in array2)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("\nЕсли хотите продолжить введите true, если хотите выйти введите false\n");
            flag = Convert.ToBoolean(Console.ReadLine());
            break;
        case "Теща":
            path = @"C:\Users\-LENOVO-\OneDrive\Рабочий стол\Maybe future\C#\Jokes\Jokes\mother-in-law.txt";
            string[] array3 = File.ReadAllLines(path);
            Console.WriteLine("\n");
            foreach (string line in array3)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("\nЕсли хотите продолжить введите true, если хотите выйти введите false\n");
            flag = Convert.ToBoolean(Console.ReadLine());
            break;
        case "Психушка":
            path = @"C:\Users\-LENOVO-\OneDrive\Рабочий стол\Maybe future\C#\Jokes\Jokes\MentalHhospital.txt";
            string[] array4 = File.ReadAllLines(path);
            Console.WriteLine("\n");
            foreach (string line in array4)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("\nЕсли хотите продолжить введите true, если хотите выйти введите false\n");
            flag = Convert.ToBoolean(Console.ReadLine());
            break;
        default:
            Console.WriteLine("\nКатегория введена неправильно, либо данной категории не существует\n");
            Console.WriteLine("\nЕсли хотите продолжить введите true, если хотите выйти введите false\n");
            flag = Convert.ToBoolean(Console.ReadLine());
            break;
    }
}