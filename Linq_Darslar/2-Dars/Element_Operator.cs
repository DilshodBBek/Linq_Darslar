
internal class Element_Operator
{
    public static void Start()
    {
        //ElementAt1();
        //ElementAtOrDefault1();
        //ElementAtOrDefault2();
        //ElementAtOrDefault3();

        //ElementAtWithException1();
        //ElementAtWithException2();

        //First1();
        //First2();

        //FirstOrDefault1();
        //FirstOrDefault2();
        //FirstOrDefault3();
        //FirstOrDefault4();
        //FirstOrDefault5();

        //Last1();
        //Last2();

        //LastOrDefault1();
        //LastOrDefault2();
        //LastOrDefault3();
        //LastOrDefault4();
        //LastOrDefault5();

        //LastWithException1();
        //LastWithException2();

        //Single1();
        //Single2();

        //SingleWithException1();
        //SingleWithException2();
        //SingleWithException3();
        //SingleWithException4();

        //SingleOrDefault1();
        //SingleOrDefault2();

        //SingleOrDefaultWithException1();

        //DefaultIfEmpty1();
        //DefaultIfEmpty2();
        //DefaultIfEmpty3();
        //DefaultIfEmpty4();
        //DefaultIfEmpty5();
        //DefaultIfEmpty6();
    }

    public static void ElementAt1()
    {
        //Data Source
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Using ElementAt Method
        //Fetch the Element from Index Position 1 using Method Syntax
        //ElementAt Method returns a Single Value
        int MethodSyntax = numbers.ElementAt(1);
        //Query Syntax
        int QuerySyntax = (from num in numbers
                           select num).ElementAt(1);
        //Printing the value returned by the ElementAt Method
        Console.WriteLine(MethodSyntax);
    }

    public static void ElementAtOrDefault1()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Method Syntax
        int MethodSyntax = numbers.ElementAtOrDefault(1);
        //Query Syntax
        int QuerySyntax = (from num in numbers
                           select num).ElementAtOrDefault(1);
        Console.WriteLine(MethodSyntax);
    }

    public static void ElementAtOrDefault2()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int MethodSyntax1 = numbers.ElementAtOrDefault(10);
        Console.WriteLine($"Value at Index Position 10: {MethodSyntax1}");
        int MethodSyntax2 = numbers.ElementAtOrDefault(-1);
        Console.WriteLine($"Value at Index Position -1: {MethodSyntax2}");

    }

    public static void ElementAtOrDefault3()
    {
        //ElementAtOrDefault Method Syntax
        Student ElementAtMS = Student.GetAllStudents().ElementAt(1);
        //ElementAtOrDefault Query Syntax
        Student ElementAtQS = (from student in Student.GetAllStudents()
                               select student).ElementAt(2);
        //ElementAtOrDefault Method Syntax
        Student ElementAtOrDefaultMS = Student.GetAllStudents().ElementAtOrDefault(0);
        //ElementAtOrDefault Query Syntax
        Student ElementAtOrDefaultQS = (from student in Student.GetAllStudents()
                                        select student).ElementAtOrDefault(3);
        Console.WriteLine($"ID: {ElementAtMS.ID}, Name: {ElementAtMS.Name}, Department: {ElementAtMS.Department}");
    }

    public static void ElementAtWithException1()
    {
        //Data Source
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Using ElementAt Method
        //Fetch the Element from Index Position -1 or 10 using Method Syntax
        //int MethodSyntax = numbers.ElementAt(-1);
        int MethodSyntax = numbers.ElementAt(10);
        //Printing the value returned by the ElementAt Method
        Console.WriteLine(MethodSyntax);
    }

    public static void ElementAtWithException2()
    {
        //Data Source is Empty
        List<int> numbers = new List<int>();
        //Using ElementAt Method
        int MethodSyntax = numbers.ElementAt(1);
        //Printing the value returned by the ElementAt Method
        Console.WriteLine(MethodSyntax);
    }

    public static void First1()
    {
        //Fetching the First Element from the Data Source using First Method
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Using Method Syntax
        int MethodSyntax = numbers.First();
        //Query Syntax
        int QuerySyntax = (from num in numbers
                           select num).First();
        //Printing the value returned by the First Method
        Console.WriteLine(MethodSyntax);
    }

    public static void First2()
    {
        //Fetching the First Element from the Data Source which is Divisble by 2
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Using Method Syntax
        int MethodSyntax = numbers.First(num => num % 2 == 0);
        //Query Syntax
        int QuerySyntax = (from num in numbers
                           select num).First(num => num % 2 == 0);
        //Printing the value returned by the First Method
        Console.WriteLine(MethodSyntax);
    }

    public static void FirstWithException1()
    {
        //Empty Data Source
        List<int> numbersEmpty = new List<int>() { };
        int MethodSyntax = numbersEmpty.First();
        Console.WriteLine(MethodSyntax);
    }

    public static void FirstWithException2()
    {
        //Specified Condition Doesnot Return Any Element
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int MethodSyntax = numbers.First(num => num > 50);
        Console.WriteLine(MethodSyntax);
    }

    public static void FirstOrDefault1()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Using Method Syntax
        int MethodSyntax = numbers.FirstOrDefault();

        //Using Query Syntax
        int QuerySyntax = (from num in numbers
                           select num).FirstOrDefault();
        Console.WriteLine(MethodSyntax);
    }

    public static void FirstOrDefault2()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Using Method Syntax
        int MethodSyntax = numbers.FirstOrDefault(num => num > 5);

        //Using Query Syntax
        int QuerySyntax = (from num in numbers
                           select num).FirstOrDefault(num => num > 5);
        Console.WriteLine(MethodSyntax);
    }

    public static void FirstOrDefault3()
    {
        //Empty Data Source
        List<int> numbersEmpty = new List<int>();
        //Using Method Syntax
        int MethodSyntax1 = numbersEmpty.FirstOrDefault();

        //Using Query Syntax
        int QuerySyntax1 = (from num in numbersEmpty
                            select num).FirstOrDefault();
        Console.WriteLine(MethodSyntax1);

        //Specified condition doesnot return any element
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Using Method Syntax
        int MethodSyntax2 = numbers.FirstOrDefault(num => num > 50);

        //Using Query Syntax
        int QuerySyntax2 = (from num in numbers
                            select num).FirstOrDefault(num => num > 50);
        Console.WriteLine(MethodSyntax2);
    }

    public static void FirstOrDefault4()
    {
        //Data Source
        List<Employee> listEmployees = Employee.GetAllEmployees();
        //Fetching the First Employee from listEmployees Collection
        Employee Employee1 = listEmployees.First();
        Console.WriteLine($"{Employee1.ID}, {Employee1.Name}, {Employee1.Gender}, {Employee1.Salary}");
        //Fetch the First Employee where the Gender is Male
        Employee Employee2 = listEmployees.First(emp => emp.Gender == "Male");
        Console.WriteLine($"{Employee2.ID}, {Employee2.Name}, {Employee2.Gender}, {Employee2.Salary}");
        //Fetch the First Employee where the Salary is less than 30000
        Employee Employee3 = listEmployees.First(emp => emp.Salary < 30000);
        Console.WriteLine($"{Employee3.ID}, {Employee3.Name}, {Employee3.Gender}, {Employee3.Salary}");
    }

    public static void FirstOrDefault5()
    {
        //Data Source
        List<Employee> listEmployees = Employee.GetAllEmployees();
        //Fetching the First Employee from listEmployees Collection
        Employee Employee1 = listEmployees.FirstOrDefault();
        Console.WriteLine($"{Employee1.ID}, {Employee1.Name}, {Employee1.Gender}, {Employee1.Salary}");
        //Fetch the First Employee where the Gender is Female
        Employee Employee2 = listEmployees.FirstOrDefault(emp => emp.Gender == "Female");
        Console.WriteLine($"{Employee2.ID}, {Employee2.Name}, {Employee2.Gender}, {Employee2.Salary}");
        //Fetch the First Employee where the Salary is greater than 30000
        Employee Employee3 = listEmployees.First(emp => emp.Salary > 30000);
        Console.WriteLine($"{Employee3.ID}, {Employee3.Name}, {Employee3.Gender}, {Employee3.Salary}");
    }

    public static void Last1()
    {
        //Fetching the Last Element from the Data Source using Last Method
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Using Method Syntax
        int MethodSyntax = numbers.Last();
        //Query Syntax
        int QuerySyntax = (from num in numbers
                           select num).Last();
        //Printing the value returned by the Last Method
        Console.WriteLine(MethodSyntax);
    }

    public static void Last2()
    {
        //Fetching the Last Element from the Data Source which is Divisble by 3
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Using Method Syntax
        int MethodSyntax = numbers.Last(num => num % 3 == 0);
        //Query Syntax
        int QuerySyntax = (from num in numbers
                           select num).Last(num => num % 3 == 0);
        //Printing the value returned by the Last Method
        Console.WriteLine(MethodSyntax);
    }

    public static void LastWithException1()
    {
        //Empty Data Source
        List<int> numbersEmpty = new List<int>();
        int MethodSyntax = numbersEmpty.Last();
        Console.WriteLine(MethodSyntax);
    }

    public static void LastWithException2()
    {
        //Specified Condition Doesnot Return Any Element
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int MethodSyntax = numbers.Last(num => num > 50);
        Console.WriteLine(MethodSyntax);
    }

    public static void LastOrDefault1()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Using Method Syntax
        int MethodSyntax = numbers.LastOrDefault();
        //Using Query Syntax
        int QuerySyntax = (from num in numbers
                           select num).LastOrDefault();
        Console.WriteLine(MethodSyntax);
    }

    public static void LastOrDefault2()
    {
        //Fetching the Last Element which is less than 5
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Using Method Syntax
        int MethodSyntax = numbers.LastOrDefault(num => num < 5);
        //Using Query Syntax
        int QuerySyntax = (from num in numbers
                           select num).LastOrDefault(num => num < 5);
        Console.WriteLine(MethodSyntax);
    }

    public static void LastOrDefault3()
    {
        //Empty Data Source
        List<int> numbersEmpty = new List<int>();
        //Using Method Syntax
        int MethodSyntax1 = numbersEmpty.LastOrDefault();
        //Using Query Syntax
        int QuerySyntax1 = (from num in numbersEmpty
                            select num).LastOrDefault();
        Console.WriteLine(MethodSyntax1);
        //Specified condition doesnot return any element
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Using Method Syntax
        int MethodSyntax2 = numbers.LastOrDefault(num => num > 50);
        //Using Query Syntax
        int QuerySyntax2 = (from num in numbers
                            select num).LastOrDefault(num => num > 50);
        Console.WriteLine(MethodSyntax2);
    }

    public static void LastOrDefault4()
    {
        //Data Source
        List<Employee> listEmployees = Employee.GetAllEmployees();
        //Fetching the Last Employee from listEmployees Collection
        Employee Employee1 = listEmployees.Last();
        Console.WriteLine($"{Employee1.ID}, {Employee1.Name}, {Employee1.Gender}, {Employee1.Salary}");
        //Fetch the Last Employee where the Gender is Male
        Employee Employee2 = listEmployees.Last(emp => emp.Gender == "Male");
        Console.WriteLine($"{Employee2.ID}, {Employee2.Name}, {Employee2.Gender}, {Employee2.Salary}");
        //Fetch the Last Employee where the Salary is less than 30000
        Employee Employee3 = listEmployees.Last(emp => emp.Salary < 30000);
        Console.WriteLine($"{Employee3.ID}, {Employee3.Name}, {Employee3.Gender}, {Employee3.Salary}");
    }

    public static void LastOrDefault5()
    {
        //Data Source
        List<Employee> listEmployees = Employee.GetAllEmployees();
        //Fetching the Last Employee from listEmployees Collection
        Employee Employee1 = listEmployees.FirstOrDefault();
        Console.WriteLine($"{Employee1.ID}, {Employee1.Name}, {Employee1.Gender}, {Employee1.Salary}");
        //Fetch the Last Employee where the Gender is Male
        Employee Employee2 = listEmployees.FirstOrDefault(emp => emp.Gender == "Male");
        Console.WriteLine($"{Employee2.ID}, {Employee2.Name}, {Employee2.Gender}, {Employee2.Salary}");
        //Fetch the Last Employee where the Salary is less than 30000
        Employee Employee3 = listEmployees.First(emp => emp.Salary < 30000);
        Console.WriteLine($"{Employee3.ID}, {Employee3.Name}, {Employee3.Gender}, {Employee3.Salary}");
    }

    public static void Single1()
    {
        //Sequence contains one element
        List<int> numbers = new List<int>() { 10 };
        //Fetching the Only Element from the Sequenece using Method Syntax
        int numberMS = numbers.Single();
        //Fetching the Only Element from the Sequenece using Query Syntax
        int numberQS = (from num in numbers
                        select num).Single();
        //Printing the Returned element by Single Method
        Console.WriteLine(numberQS);
    }

    public static void Single2()
    {
        //Sequence contains more than one element
        List<int> numbers = new List<int>() { 10, 20, 30 }; ;
        //Fetching the Only Element from the Sequenece using Method Syntax
        //Where the Element is 20
        int numberMS = numbers.Single(num => num == 20);
        //Fetching the Only Element from the Sequenece using Query Syntax
        //Where the Element is 20
        int numberQS = (from num in numbers
                        select num).Single(num => num == 20);
        //Printing the Returned element by Single Method
        Console.WriteLine(numberQS);
    }

    public static void SingleWithException1()
    {
        //Sequence contains no element i.e. Empty Data Source
        List<int> numbers = new List<int>();
        //Fetching the Only Element from the Sequenece using Method Syntax
        int numberMS = numbers.Single();
        //Fetching the Only Element from the Sequenece using Query Syntax
        int numberQS = (from num in numbers
                        select num).Single();
        //Printing the Returned element by Single Method
        Console.WriteLine(numberQS);
    }

    public static void SingleWithException2()
    {
        //Sequence contains more than one element
        List<int> numbers = new List<int>() { 10, 20, 30 }; ;
        //Fetching the Only Element from the Sequenece using Method Syntax
        int numberMS = numbers.Single();
        //Fetching the Only Element from the Sequenece using Query Syntax
        int numberQS = (from num in numbers
                        select num).Single();
        //Printing the Returned element by Single Method
        Console.WriteLine(numberQS);
    }

    public static void SingleWithException3()
    {
        //Sequence contains more than one element
        List<int> numbers = new List<int>() { 10, 20, 30 }; ;
        //Fetching the Only Element from the Sequenece using Method Syntax
        //Where the Element > 10
        int numberMS = numbers.Single(num => num > 10);
        //Fetching the Only Element from the Sequenece using Query Syntax
        //Where the Element > 10
        int numberQS = (from num in numbers
                        select num).Single(num => num > 10);
        //Printing the Returned element by Single Method
        Console.WriteLine(numberQS);
    }

    public static void SingleWithException4()
    {
        //Sequence contains more than one element
        List<int> numbers = new List<int>() { 10, 20, 30 }; ;
        //Fetching the Only Element from the Sequenece using Method Syntax
        //Where the Element < 10
        int numberMS = numbers.Single(num => num < 10);
        //Fetching the Only Element from the Sequenece using Query Syntax
        //Where the Element < 10
        int numberQS = (from num in numbers
                        select num).Single(num => num < 10);
        //Printing the Returned element by Single Method
        Console.WriteLine(numberQS);
    }

    public static void SingleOrDefault1()
    {
        List<int> numbers = new List<int>() { 10, 20, 30 };
        int number = numbers.SingleOrDefault(num => num < 10);
        Console.WriteLine(number);
    }

    public static void SingleOrDefault2()
    {
        //Sequence contains no element
        List<int> numbers = new List<int>();
        //Fetching the Only Element from the Sequenece using Method Syntax
        //Where the Element < 10
        int numberMS = numbers.SingleOrDefault(num => num < 10);
        //Fetching the Only Element from the Sequenece using Query Syntax
        //Where the Element < 10
        int numberQS = (from num in numbers
                        select num).SingleOrDefault(num => num < 10);
        //Printing the Returned element by Single Method
        Console.WriteLine(numberQS);
    }

    public static void SingleOrDefaultWithException1()
    {
        //Sequence contains
        List<int> numbers = new List<int>() { 10, 20, 30 };
        //Fetching the Only Element from the Sequenece using Method Syntax
        //Where the Element > 10
        int numberMS = numbers.SingleOrDefault(num => num > 10);
        //Fetching the Only Element from the Sequenece using Query Syntax
        //Where the Element > 10
        int numberQS = (from num in numbers
                        select num).SingleOrDefault(num => num > 10);
        //Printing the Returned element by Single Method
        Console.WriteLine(numberQS);
    }

    public static void DefaultIfEmpty1()
    {
        //Sequence is not empty
        List<int> numbers = new List<int>() { 10, 20, 30 };
        //DefaultIfEmpty Method will return a new sequence with existing sequence values
        //Using Method Syntax
        IEnumerable<int> resultMS = numbers.DefaultIfEmpty();
        //Using Query Syntax
        IEnumerable<int> resultQS = (from num in numbers
                                     select num).DefaultIfEmpty();
        //Accessing the new sequence values using for each loop
        foreach (int num in resultMS)
        {
            Console.Write($"{num} ");
        }
    }

    public static void DefaultIfEmpty2()
    {
        //Sequence is empty
        List<int> numbers = new List<int>();
        //DefaultIfEmpty Method will return a new sequence with one element having the value 0
        //as the Sequence is Empty
        //Using Method Syntax
        IEnumerable<int> resultMS = numbers.DefaultIfEmpty();
        //Using Query Syntax
        IEnumerable<int> resultQS = (from num in numbers
                                     select num).DefaultIfEmpty();
        //Accessing the new sequence values using for each loop
        foreach (int num in resultMS)
        {
            Console.Write($"{num} ");
        }
    }

    public static void DefaultIfEmpty3()
    {
        //Sequence is empty
        List<int> numbers = new List<int>();
        //DefaultIfEmpty Method will return 5 as the Sequence is Empty
        //as the Sequence is Empty
        //Using Method Syntax
        IEnumerable<int> resultMS = numbers.DefaultIfEmpty(5);
        //Using Query Syntax
        IEnumerable<int> resultQS = (from num in numbers
                                     select num).DefaultIfEmpty();
        //Accessing the new sequence values using for each loop
        foreach (int num in resultMS)
        {
            Console.Write($"{num} ");
        }
    }

    public static void DefaultIfEmpty4()
    {
        //Sequence is not empty
        List<int> numbers = new List<int>() { 10, 20, 30 };
        //DefaultIfEmpty Method will return the Original Sequence values
        //as the Sequence is not Empty
        //Using Method Syntax
        IEnumerable<int> resultMS = numbers.DefaultIfEmpty(5);
        //Using Query Syntax
        IEnumerable<int> resultQS = (from num in numbers
                                     select num).DefaultIfEmpty();
        //Accessing the new sequence values using for each loop
        foreach (int num in resultMS)
        {
            Console.Write($"{num} ");
        }
    }


    public static void DefaultIfEmpty5()
    {
        //Sequence is not empty
        List<Employee> employees = Employee.GetAllEmployees();
        //Create an Employee Object to pass into the DefaultIfEmpty method incase the sequence is Empty
        Employee emp5 = new Employee() { ID = 5, Name = "Hina", Salary = 10000, Gender = "Female" };
        //DefaultIfEmpty Method will return the Original Sequence values
        //as the Sequence is not Empty
        //Using Method Syntax
        IEnumerable<Employee> resultMS = employees.DefaultIfEmpty(emp5);
        //Using Query Syntax
        IEnumerable<Employee> resultQS = (from employee in employees
                                          select employee).DefaultIfEmpty(emp5);
        //Accessing the new sequence values using for each loop
        foreach (Employee emp in resultMS)
        {
            Console.WriteLine($"ID:{emp.ID}, Name:{emp.Name}, Gender:{emp.Gender}, Salary:{emp.Salary} ");
        }
    }

    public static void DefaultIfEmpty6()
    {
        //Sequence is empty
        List<Employee> employees = new List<Employee>();
        //Create an Employee Object to pass into the DefaultIfEmpty method incase the sequence is Empty
        Employee emp5 = new Employee() { ID = 5, Name = "Hina", Salary = 10000, Gender = "Female" };
        //DefaultIfEmpty Method will return the Employee Object that we passed
        //as the Sequence is Empty
        //Using Method Syntax
        IEnumerable<Employee> resultMS = employees.DefaultIfEmpty(emp5);
        //Using Query Syntax
        IEnumerable<Employee> resultQS = (from employee in employees
                                          select employee).DefaultIfEmpty(emp5);
        //Accessing the new sequence values using for each loop
        foreach (Employee emp in resultMS)
        {
            Console.WriteLine($"ID:{emp.ID}, Name:{emp.Name}, Gender:{emp.Gender}, Salary:{emp.Salary} ");
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
                new Employee { ID = 5, Name = "Hina", Salary = 10000, Gender = "Female"},
                new Employee { ID = 6, Name = "Sambit", Salary = 30000, Gender = "Male"},
                new Employee { ID = 7, Name = "Mahesh", Salary = 35600, Gender = "Male"}
            };
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public static List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student { ID = 1, Name = "Preety", Department= "IT"},
                new Student { ID = 2, Name = "Priyanka", Department= "HR"},
                new Student { ID = 3, Name = "Anurag", Department= "HR"},
                new Student { ID = 4, Name = "Pranaya", Department= "IT"},
                new Student { ID = 5, Name = "Hina", Department= "IT"}
            };
        }
    }
}

