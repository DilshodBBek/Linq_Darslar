namespace Linq_Darslar
{
    internal class Partitioning_Operators
    {
        public static void Start()
        {
            //Take1();
            //Take2();
            //Take3();
            //Take4();

            //TakeWhile1();
            //TakeWhile2();
            //TakeWhile3();
            //TakeWhile4();

            //Skip1();
            //Skip2();
            //Skip3();
            //Skip4();

            //SkipWhile1();
            //SkipWhile2();
            //SkipWhile3();
            //SkipWhile4();
        }

        public static void Take1()
        {
            //Sequence Contains 10 Elements
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Fetching the First four elements from the Sequence using Take Method
            //Using Method Syntax
            List<int> ResultMS = numbers.Take(4).ToList();
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  select num).Take(4).ToList();
            //Accessing the Results using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public static void Take2()
        {
            //Sequence Contains 10 Elements
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Fetching the First four elements from the Sequence where Number > 3
            //Using Method Syntax
            List<int> ResultMS = numbers.Where(num => num > 3).Take(4).ToList();

            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  where num > 3
                                  select num).Take(4).ToList();
            //Accessing the Results using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public static void Take3()
        {
            //Sequence Contains 10 Elements
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Fetching the First four elements from the Sequence where Number > 2
            //Using Method Syntax
            List<int> ResultMS = numbers.Take(4).Where(num => num > 2).ToList();
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  select num)
                                  .Take(4)
                                  .Where(num => num > 2)
                                  .ToList();
            //Accessing the Results using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }

        }

        public static void TakeWithException()
        {
            //Data Source is Null
            List<int> numbers = null;
            //Fetching the First four elements from the Sequence
            //Using Method Syntax
            List<int> ResultMS = numbers.Take(4).ToList();
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  select num)
                                  .Take(4)
                                  .ToList();
            //Accessing the Results using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public static void Take4()
        {
            //Data Source
            List<Employee> employees = Employee.GetAllEmployees();
            //Fetching First four Employees who are getting Highest Salary
            //Using Method Syntax
            List<Employee> ResultMS = employees.OrderByDescending(emp => emp.Salary).Take(4).ToList();
            //Using Query Syntax
            List<Employee> ResultQS = (from emp in employees
                                       orderby emp.Salary descending
                                       select emp)
                                  .Take(4)
                                  .ToList();
            //Accessing the Results using Foreach Loop
            foreach (Employee emp in ResultMS)
            {
                Console.WriteLine($"ID:{emp.ID}, Name:{emp.Name}, Gender:{emp.Gender}, Salary:{emp.Salary}");
            }
        }

        public static void TakeWhile1()
        {
            //Data Source
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Fetch Numbers which are less than 6 using TakeWhile Method
            //Using Method Syntax
            List<int> ResultMS = numbers.TakeWhile(num => num < 6).ToList();
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  select num).TakeWhile(num => num < 6).ToList();
            //Accessing the Result using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public static void TakeWhile2()
        {
            //Data Source
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Fetch Numbers which are less than 6 using Where Method
            //Using Method Syntax
            List<int> ResultMS = numbers.Where(num => num < 6).ToList();
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  where num < 6
                                  select num).ToList();
            //Accessing the Result using Foreach Loop
            foreach (var num in ResultQS)
            {
                Console.Write($"{num} ");
            }
        }

        public static void TakeWhile3()
        {
            //Data Source: Numbers are Stored in Randon Order
            List<int> numbers = new List<int>() { 1, 2, 3, 6, 7, 8, 9, 10, 4, 5 };
            //Using TakeWhile Method to Fetch Numbers which are less than 6
            List<int> Result1 = numbers.TakeWhile(num => num < 6).ToList();
            Console.Write("Result Of TakeWhile Method: ");
            foreach (var num in Result1)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            //Using Where Method to Fetch Numbers which are less than 6
            List<int> Result2 = numbers.Where(num => num < 6).ToList();
            Console.Write("Result Of Where Method: ");
            foreach (var num in Result2)
            {
                Console.Write($"{num} ");
            }
        }

        public static void TakeWhile4()
        {
            List<string> names = new List<string>() { "Sara", "Rahul", "John", "Pam", "Priyanka" };
            List<string> namesResult = names.TakeWhile(name => name.Length > 3).ToList();

            foreach (var name in namesResult)
            {
                Console.Write($"{name} ");
            }
        }

        public static void TakeWhile5()
        {
            List<string> names = new List<string>() { "Sara", "Rahul", "John", "Pam", "Priyanka" };
            List<string> namesResult = names.TakeWhile((name, index) => name.Length > index).ToList();

            foreach (var name in namesResult)
            {
                Console.Write($"{name} ");
            }
        }

        public static void Skip1()
        {
            //Data Source 
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Skip the First Four Elements and Return Remaining Elements from the Data Source
            //Using Method Syntax
            List<int> ResultMS = numbers.Skip(4).ToList();
            //Using Mixed Syntax
            List<int> ResultQS = (from num in numbers
                                  select num).Skip(4).ToList();
            //Accessing the Elements using a Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public static void Skip2()
        {
            //Sequence Contains 10 Elements
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Skipping the First four elements and Return Remaining Elements from the Sequence 
            //where Number > 3
            //Using Method Syntax
            List<int> ResultMS = numbers.Where(num => num > 3).Skip(4).ToList();
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  where num > 3
                                  select num).Skip(4).ToList();
            //Accessing the Results using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public static void Skip3()
        {
            //Sequence Contains 10 Elements
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Skipping the First three elements and Returns the Remaining Elements
            //from the Sequence where Number > 4
            //Using Method Syntax
            List<int> ResultMS = numbers.Skip(3).Where(num => num > 4).ToList();
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  select num)
                                  .Skip(3)
                                  .Where(num => num > 4)
                                  .ToList();
            //Accessing the Results using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public static void Skip4()
        {
            //Data Source
            List<Employee> employees = Employee.GetAllEmployees();
            //Skip First four Employees who are getting lowest Salary
            //Using Method Syntax
            List<Employee> ResultMS = employees.OrderBy(emp => emp.Salary).Skip(4).ToList();
            //Using Query Syntax
            List<Employee> ResultQS = (from emp in employees
                                       orderby emp.Salary ascending
                                       select emp)
                                       .Skip(4)
                                       .ToList();
            //Accessing the Results using Foreach Loop
            foreach (Employee emp in ResultMS)
            {
                Console.WriteLine($"ID:{emp.ID}, Name:{emp.Name}, Gender:{emp.Gender}, Salary:{emp.Salary}");
            }
        }

        public static void SkipWhile1()
        {
            //Data Source
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Skip Numbers which are less than 5 using SkipWhile Method
            //Using Method Syntax
            List<int> ResultMS = numbers.SkipWhile(num => num < 5).ToList();
            //Using Query Syntax
            List<int> ResultQS = (from num in numbers
                                  select num).SkipWhile(num => num < 5).ToList();
            //Accessing the Result using Foreach Loop
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public static void SkipWhile2()
        {
            List<int> numbers = new List<int>() { 1, 4, 5, 6, 7, 8, 9, 10, 2, 3 };
            List<int> ResultMS = numbers.SkipWhile(num => num < 5).ToList();
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
        }

        public static void SkipWhile3()
        {
            List<string> names = new List<string>() { "Pam", "Rahul", "Kim", "Sara", "Priyanka" };
            List<string> namesResult = names.SkipWhile(name => name.Length < 4).ToList();
            foreach (var name in namesResult)
            {
                Console.Write($"{name} ");
            }
        }

        public static void SkipWhile4()
        {
            List<string> names = new List<string>() { "Sara", "Rahul", "John", "Pam", "Priyanka" };
            List<string> namesResult = names.SkipWhile((name, index) => name.Length > index).ToList();
            foreach (var name in namesResult)
            {
                Console.Write($"{name} ");
            }
        }


        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Salary { get; set; }
            public static List<Employee> GetAllEmployees()
            {
                return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Preety", Salary = 10000, Gender = "Female"},
                new Employee { ID = 2, Name = "Priyanka", Salary =20000, Gender = "Female"},
                new Employee { ID = 3, Name = "Anurag", Salary = 35000, Gender = "Male"},
                new Employee { ID = 4, Name = "Pranaya", Salary = 45000, Gender = "Male"},
                new Employee { ID = 5, Name = "Sambit", Salary = 15000, Gender = "Male"},
                new Employee { ID = 6, Name = "Hina", Salary = 25000, Gender = "Female"},
                new Employee { ID = 7, Name = "Santosh", Salary = 39000, Gender = "Male"},
                new Employee { ID = 8, Name = "Sukanta", Salary = 55000, Gender = "Male"}
            };
            }
        }
    }
}
