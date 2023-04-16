namespace Linq_Darslar
{
    public class Generation_Operators
    {
        public static void Start()
        {
            //Range1();
            //Range2();
            //Range3();
            //Range4();

            //Repeat();
            //RepeatWithException();

            //Empty1();
            //Empty2();
            //EmptyWithException();
        }

        public static void Range1()
        {
            //Generating Intger Numbers from 1 to 10
            IEnumerable<int> numberSequence = Enumerable.Range(1, 10);
            //Accessing the numberSequence using Foreach Loop
            foreach (int num in numberSequence)
            {
                Console.Write($"{num} ");
            }
        }

        public static void Range2()
        {
            //Using Range with Where Extension Method
            IEnumerable<int> EvenNumbers = Enumerable.Range(10, 40).Where(x => x % 2 == 0);
            //Printing the Even Numbers between 10 and 40
            foreach (int num in EvenNumbers)
            {
                Console.Write($"{num} ");
            }
        }

        public static void Range3()
        {
            IEnumerable<int> EvenNumbers = Enumerable.Range(1, 5).Select(x => x * x);
            foreach (int num in EvenNumbers)
            {
                Console.Write($"{num} ");
            }
        }

        public static void Range4()
        {
            IEnumerable<string> rangewithString = Enumerable.Range(1, 5).Select(x => (x * x) + " " + CustomLogic(x)).ToArray();
            foreach (var item in rangewithString)
            {
                Console.WriteLine(item);
            }
        }

        private static string CustomLogic(int x)
        {
            string result = string.Empty;
            switch (x)
            {
                case 1:
                    result = "1st";
                    break;
                case 2:
                    result = "2nd";
                    break;
                case 3:
                    result = "3rd";
                    break;
                case 4:
                    result = "4th";
                    break;
                case 5:
                    result = "5th";
                    break;
            }
            return result;
        }

        public static void Repeat()
        {
            //Repeating the string value Welcome to DOT NET Tutorials for 10 Times
            //Using the Repeat Method
            IEnumerable<string> repeatStrings = Enumerable.Repeat("Welcome to DOT NET Tutorials", 10);
            //Accessing the collection or sequence using a foreach loop
            foreach (string str in repeatStrings)
            {
                Console.WriteLine(str);
            }
        }

        public static void RepeatWithException()
        {

            //Repeating the string value Welcome to DOT NET Tutorials for 10 Times
            //Using the Repeat Method
            IEnumerable<string> repeatStrings =
                Enumerable.Repeat("Welcome to DOT NET Tutorials", -5);
            //Accessing the collection or sequence using a foreach loop
            foreach (string str in repeatStrings)
            {
                Console.WriteLine(str);
            }
        }

        public static void Empty1()
        {
            //Creating Empty Collection of Strings
            IEnumerable<string> emptyCollection1 = Enumerable.Empty<string>();
            //Creating Empty Collection of Student
            IEnumerable<Student> emptyCollection2 = Enumerable.Empty<Student>();
            //Printing the Type and Count of emptyCollection1
            Console.WriteLine("Count: {0} ", emptyCollection1.Count());
            Console.WriteLine("Type: {0} ", emptyCollection1.GetType().Name);
            //Printing the Type and Count of emptyCollection2
            Console.WriteLine("Count: {0} ", emptyCollection2.Count());
            Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name);
        }

        public static void EmptyWithException()
        {
            //GetData() Method Returning Null
            IEnumerable<int> integerSequence = GetData();
            //The forloop will throw NullReferenceException
            foreach (var num in integerSequence)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
        public static void Empty2()
        {
            IEnumerable<int> integerSequence = GetData() ?? Enumerable.Empty<int>(); ;
            foreach (var num in integerSequence)
            {
                Console.WriteLine(num);
            }
        }

        private static IEnumerable<int> GetData()
        {
            return null;
        }
    }
}
