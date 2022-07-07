namespace MERCEDESS2
{
    public class Program
    {
        static void Main()
        {
            BMW bMW = new BMW("M5", 7600, 260,"Black");

            bMW.model = "M5";
            bMW.price = 76000;
            bMW.speed = 260;
            bMW.color = "Black";

            Console.WriteLine(bMW.GetDetalis());


        }
    }
}