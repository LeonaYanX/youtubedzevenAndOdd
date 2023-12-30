internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the start point");
        int startPoint = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the end point");
        int endPoint = Convert.ToInt32(Console.ReadLine());
        int countEven = 0;
        int countOdd = 0;
        if (startPoint%2==0)
        {
            for(int i = startPoint; i<=endPoint ; i+=2)
        {
             countEven = countEven +1;
        }
        countOdd = (endPoint-startPoint) - countEven + 1;
        Console.WriteLine($"Odd are = {countOdd}");
         Console.WriteLine($"Even are = {countEven}");
        }
        if(startPoint%2!=0)
        {
            for(int j = startPoint; j<=endPoint ; j+=2)
            {
                countOdd = countOdd +1;
            }
         countEven = (endPoint-startPoint) - countOdd + 1;
         Console.WriteLine($"Odd are = {countOdd}");
         Console.WriteLine($"Even are = {countEven}");
        }
       
        
    }
}