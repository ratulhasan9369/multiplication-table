
class Multiplication_Table
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter your start number: ");
        int startNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your end number: ");
        int endNumber = Convert.ToInt32(Console.ReadLine());


        for (int i = startNumber; i <= endNumber; i++)
        {

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
            }
            Console.WriteLine("-----------------");
        }
    }
}