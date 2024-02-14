internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Подготовка к бою:");
        Console.WriteLine("Введите имя бойца:");
        var Unit = new HW_classes.Unit(Console.ReadLine());
        Console.WriteLine($"Имя: {Unit.Name}");
        
    }
}