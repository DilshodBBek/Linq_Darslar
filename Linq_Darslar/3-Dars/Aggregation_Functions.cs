public static class Aggregation_Functions
{
    public static void Start()
    {
        //Sum();
        //Max();
        //Min();
        //Average();
        //Count();
        //Aggregate();
        //Aggregate1();
    }
    public static void Sum()
    {
        int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };
        //Using Method Syntax
        int MSTotal = intNumbers.Sum();
        //Using Query Syntax
        int QSTotal = (from num in intNumbers
                       select num).Sum();
        Console.WriteLine("Sum =" + QSTotal);
    }
    public static void Max()
    {
        int[] intNumbers = new int[] { 10, 80, 50, 90, 60, 30, 70, 40, 20, 100 }; //Using Method Syntax
        int MSLergestNumber = intNumbers.Max();
        //Using Query Syntax
        int QSLergestNumber = (from num in intNumbers
                               select num).Max();
        Console.WriteLine("Largest Number:" + MSLergestNumber);
        //Output: Largest Number = 100
    }
    public static void Min()
    {

        int[] intNumbers = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
        //Using Method Syntax
        int MSLowestNumber =
        //Using Query Syntax
        intNumbers.Min();
        int QSLowestNumber = (from num in intNumbers
                              select num).Min();
        Console.WriteLine("Lowest Number = " + QSLowestNumber);
        //Output: Lowest Number = 10
    }
    public static void Average()
    {
        int[] intNumbers = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
        //Using Method Syntax
        var MSAverageValue = intNumbers.Average();
        //Using Query Syntax
        var QSAverageValue = (from num in intNumbers select num).Average();
        Console.WriteLine("Average Value:" + MSAverageValue);
        //Output: Average Value = 55
    }
    public static void Count()
    {

        int[] intNumbers = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 }; //Using Method Syntax
        int MSCount = intNumbers.Count();
        //Using Query Syntax
        var QSCount =
        (from num in intNumbers
         select num).Count();
        Console.WriteLine("No of Elements:" + MSCount);
        //Output: No of Elements = 10
    }
    public static void Aggregate()
    {
        List<int> numbers = new List<int> { 6, 2, 8, 3 };
        int multiply = numbers.Aggregate(func: (result, item) => result + item);
        // multiply: 6*2*8*3 = 288
        Console.WriteLine("Aggregate multiply:" + multiply);
    }
    public static void Aggregate1()
    {
        var numbers = new List<int> { 6, 2, 8, 3 };
        int sum = numbers.Aggregate(func: Add);
        // sum: (((6+2)+8)+3) = 19
        Console.WriteLine("Aggregate Add():" + sum);
    }
    private static int Add(int x, int y) { return x + y; }

}
