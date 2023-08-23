Console.WriteLine("Выберите категорию анекдотов из предложенных: Автомобили и транспорт, Брак, Теща, Психушка\n");
string category = Console.ReadLine();

switch(category)
{
    case "Автомобили и транспорт":
        Console.WriteLine("1\n");
        break;
    case "Брак":
        Console.WriteLine("2\n");
        break;
    case "Теща":
        Console.WriteLine("3\n");
        break;
    case "Психушка":
        Console.WriteLine("4\n");
        break;
    default:
        Console.WriteLine("\nКатегория введена неправильно, либо данной категории не существует. Повторите попытку еще раз\n");
        break;
}