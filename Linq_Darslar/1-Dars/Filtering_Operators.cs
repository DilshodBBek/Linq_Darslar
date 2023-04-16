public static class Filtering_Operators
{
    public static void Start()
    {
        //Where();
        //WhereWithMethod();
        //WhereWithIndexPosition();
        //WhereWithEmployee();
        //WhereWithEmployee2();
        //OfType();
        //OfTypeString();
    }
    public static void Where()
    {
        List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Method Syntax
        IEnumerable<int> filteredData = intList.Where(num => num > 5);
        //Query Syntax
        IEnumerable<int> filteredResult = from num in intList
                                          where num > 5
                                          select num;

        foreach (int number in filteredData)
        {
            Console.WriteLine(number);
        }
    }
    public static void WhereWithMethod()
    {
        List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Method Syntax
        IEnumerable<int> filteredData = intList.Where(num => CheckNumber(num));
        foreach (int number in filteredData)
        {
            Console.WriteLine(number);
        }
        Console.ReadKey();
    }
    public static bool CheckNumber(int number)
    {
        if (number > 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static void WhereWithIndexPosition()
    {
        List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //Method Syntax
        var OddNumbersWithIndexPositionMethodSyntax = intList.Select((num, index) => new
        {
            Numbers = num,
            IndexPosition = index
        }).Where(x => x.Numbers % 2 != 0)
          .Select(data => new
          {
              Number = data.Numbers,
              IndexPosition = data.IndexPosition
          });

        //Query Syntax
        var OddNumbersWithIndexPositionQuerySyntax = from number in intList.Select((num, index) => new { Numbers = num, IndexPosition = index })
                                                     where number.Numbers % 2 != 0
                                                     select new
                                                     {
                                                         Number = number.Numbers,
                                                         IndexPosition = number.IndexPosition
                                                     };

        foreach (var item in OddNumbersWithIndexPositionMethodSyntax)
        {
            Console.WriteLine($"IndexPosition :{item.IndexPosition} , Value : {item.Number}");
        }

    }
    public static void WhereWithEmployee()
    {
        //Query Syntax
        var QuerySyntax = from employee in Employee.GetEmployees()
                          where employee.Salary > 50000
                          select employee;
        //Method Syntax
        var MethodSyntax = Employee.GetEmployees()
                           .Where(emp => emp.Salary > 50000);

        foreach (var emp in QuerySyntax)
        {
            Console.WriteLine($"Name : {emp.FirstName}, Salary : {emp.Salary}");
        }
    }
    public static void WhereWithEmployee2()
    {
        //Query Syntax
        var QuerySyntax = from employee in Employee.GetEmployees()
                          where employee.Salary > 500000 && employee.Programming.Contains("C#")
                          select employee;
        //Method Syntax
        var MethodSyntax = Employee.GetEmployees()
                           .Where(emp => emp.Salary > 500000 && emp.Programming.Contains("C#"))
                           .ToList();

        foreach (var emp in MethodSyntax)
        {
            Console.WriteLine($"Name : {emp.FirstName}, Salary : {emp.Salary}, \nProgramming :");
            foreach (var program in emp.Programming)
            {
                Console.Write(program + ",");
            }
        }
    }
    public static void OfType()
    {
        List<object> dataSource = new List<object>()
        {
           "Ahad", "Abdulatif", 50, "Xurshid", "Ulug'bek", 10, 20, 30, 40, "Abubakr"
        };

        List<int> intData = dataSource.OfType<int>().ToList();

        foreach (int number in intData)
        {
            Console.Write(number + " ");
        }
    }
    public static void OfTypeString()
    {
        List<object> dataSource = new List<object>()
            {
                "Ahad", "Abdulatif", 50, "Xurshid", "Ulug'bek", 10, 20, 30, 40, "Abubakr"
            };

        var stringData = (from name in dataSource
                          where name is string
                          select name).ToList();

        foreach (string name in stringData)
        {
            Console.Write(name + " ");
        }
    }
}

