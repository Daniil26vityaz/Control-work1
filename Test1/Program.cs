using MyLib;
namespace Test1;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int size = MyLibClass.Input("Введите размер массива: ");
        string[] array = new string[size];
        Console.Write("Введите элементы массива: ");
        for (int i = 0; i < size; i++)
        {
            array[i] = Console.ReadLine();
        }
        string str = string.Join(", ", array);
        Console.WriteLine($"Ваш массив: [{str}]");
        Console.Write($"Ваш новый массив : [");
        for (int i = 0; i < size; i++)
        {
            if (array[i].Length <= 3)
            {
                Console.Write($"{array[i]}, ");
            }
        }
        Console.Write("\b\b");
        Console.Write($"]");

    }
}
