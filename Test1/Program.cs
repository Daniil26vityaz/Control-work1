using MyLib;
namespace Test1;

class Program
{
    static void Main(string[] args)
    {
        int size = MyLibClass.Input("Введите размер массива: ");
        string[] array = new string[size];
        Console.Write("Введите элементы массива: ");
        for (int i = 0; i < size; i++)
        {
            array[i] = Console.ReadLine();
        }       
        string str = string.Join(", ", array);
        Console.Write($"Ваш массив: [{str}]");
    }
}
