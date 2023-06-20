// See https://aka.ms/new-console-template for more information

class Learn
{
    static void Main(string[] args)
    {
        int[] arrayData = { 1, 2, 3 };

        double[] doublesArray = { 0.3, 0.1, 7.0 };

        displayData(arrayData);
        displayData(doublesArray);
      


    }
    public static void displayData<Tdata>(Tdata[] array)
    {
        foreach(Tdata item in array)
        {

            Console.WriteLine(item);
        }
    }
}
