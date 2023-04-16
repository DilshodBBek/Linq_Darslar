namespace Linq_Darslar
{
    public class Quantifier_Operators
    {
        public static void Start()
        {
            //All1();
            //All2();

            //Any1();
            //Any2();
            //Any3();

            //Contains1();
            //Contains2();
        }

        public static void All1()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };
            //Using Method Syntax
            bool ResultMS = IntArray.All(x => x > 10);
            //Using Query Syntax
            bool ResultQS = (from num in IntArray
                             select num).All(x => x > 10);
            Console.WriteLine("Is All Numbers are greater than 10 : " + ResultMS);
        }

        public static void All2()
        {
            string[] stringArray = { "James", "Sachin", "Sourav", "Pam", "Sara" };
            //Using Method Syntax
            bool ResultMS = stringArray.All(name => name.Length > 5);
            //Using Query Syntax
            bool ResultQS = (from num in stringArray
                             select num).All(name => name.Length > 5);
            Console.WriteLine("Is All Names are greater than 5 Characters : " + ResultQS);
        }

        public static void Any1()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };
            //Using Method Syntax
            var ResultMS = IntArray.Any();
            //Using Query Syntax
            var ResultQS = (from num in IntArray
                            select num).Any();
            Console.WriteLine("Is there any element in the collection: " + ResultMS);
        }

        public static void Any2()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };
            //Using Method Syntax
            var ResultMS = IntArray.Any(x => x < 10);
            //Using Query Syntax
            var ResultQS = (from num in IntArray
                            select num).Any(x => x < 10);
            Console.WriteLine("Is There Any Element Less than 10: " + ResultMS);

        }

        public static void Any3()
        {
            string[] stringArray = { "James", "Sachin", "Sourav", "Pam", "Sara" };
            //Method Syntax
            var ResultMS = stringArray.Any(name => name.Length > 5);
            //Query Syntax
            var ResultQS = (from name in stringArray
                            select name).Any(name => name.Length > 5);
            Console.WriteLine("Is Any name with a Length greater than 5 Characters: " + ResultMS);
        }

        public static void Contains1()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };
            //Using Method Syntax
            var IsExistsMS = IntArray.Contains(33);
            //Using Query Syntax
            var IsExistsQS = (from num in IntArray
                              select num).Contains(33);
            Console.WriteLine($"Is Element 33 Exist: {IsExistsMS}");

        }

        public static void Contains2()
        {
            List<string> namesList = new List<string>() { "James", "Sachin", "Sourav", "Pam", "Sara" };
            //Using Method Syntax
            //This method belongs to System.Collections.Generic namespace
            var IsExistsMS1 = namesList.Contains("Anurag");
            //This method belongs to System.Linq namespace
            var IsExistsMS2 = namesList.AsEnumerable().Contains("Anurag");
            //Using Query Syntax
            var IsExistsQS = (from num in namesList
                              select num).Contains("Anurag");
            Console.WriteLine($"Is Name Anurag Exist: {IsExistsQS}");
        }
    }
}
