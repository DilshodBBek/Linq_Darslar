
public static class Projection_Operators
{
    public static void Start()
    {
        //Select();
        //SelectFewProperties();
        //SelectAnonymousType();
        //SelectWithCalculations();

        //SelectMany();
        //SelectManyExample();
        //SelectManyComplex();
    }
    public static void Select()
    {
        //Using Query Syntax
        List<int> basicPropQuery = (from emp in Employee.GetEmployees()
                                    select emp.ID).ToList();
        foreach (var id in basicPropQuery)
        {
            Console.WriteLine($"ID : {id}");
        }

        // Using Method Syntax
        IEnumerable<int> basicPropMethod = Employee.GetEmployees()
                                                   .Select(emp => emp.ID);


        foreach (var id in basicPropMethod)
        {
            Console.WriteLine($"ID : {id}");
        }
    }
    public static void SelectFewProperties()
    {
        //Query Syntax
        IEnumerable<Employee> selectQuery = (from emp in Employee.GetEmployees()
                                             select new Employee()
                                             {
                                                 FirstName = emp.FirstName,
                                                 LastName = emp.LastName,
                                                 Salary = emp.Salary
                                             });

        foreach (var emp in selectQuery)
        {
            Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
        }

        //Method Syntax
        List<Employee> selectMethod = Employee.GetEmployees()
                                              .Select(emp => new Employee()
                                              {
                                                  FirstName = emp.FirstName,
                                                  LastName = emp.LastName,
                                                  Salary = emp.Salary
                                              }).ToList();
        foreach (var emp in selectMethod)
        {
            Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
        }
    }
    public static void SelectAnonymousType()
    {
        //Query Syntax
        var selectQuery = from emp in Employee.GetEmployees()
                          select new
                          {
                              FirstName = emp.FirstName,
                              LastName = emp.LastName,
                              Salary = emp.Salary
                          };

        foreach (var emp in selectQuery)
        {
            Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
        }

        //Method Syntax
        var selectMethod = Employee.GetEmployees()
                                   .Select(emp => new
                                   {
                                       FirstName = emp.FirstName,
                                       LastName = emp.LastName,
                                       Salary = emp.Salary
                                   }).ToList();
        foreach (var emp in selectMethod)
        {
            Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
        }
    }
    public static void SelectWithCalculations()
    {
        //Query Syntax
        var selectQuery = (from emp in Employee.GetEmployees()
                           select new
                           {
                               EmployeeId = emp.ID,
                               FullName = emp.FirstName + " " + emp.LastName,
                               AnnualSalary = emp.Salary * 12
                           });

        foreach (var emp in selectQuery)
        {
            Console.WriteLine($" ID {emp.EmployeeId} Name : {emp.FullName} Annual Salary : {emp.AnnualSalary} ");
        }
        //Method Syntax
        var selectMethod = Employee.GetEmployees()
                                   .Select(emp => new
                                   {
                                       EmployeeId = emp.ID,
                                       FullName = emp.FirstName + " " + emp.LastName,
                                       AnnualSalary = emp.Salary * 12
                                   }).ToList();
        foreach (var emp in selectMethod)
        {
            Console.WriteLine($" ID {emp.EmployeeId} Name : {emp.FullName} Annual Salary : {emp.AnnualSalary} ");
        }
    }

    public static void SelectMany()
    {
        List<string> nameList = new List<string>() { "Dilshod", "Shodiyev" };

        IEnumerable<char> querySyntax = from str in nameList
                                        from ch in str
                                        select ch;
        foreach (char c in querySyntax)
        {
            Console.Write(c + " ");
        }
    }
    public static void SelectManyExample()
    {
        //Using Method Syntax
        List<string> MethodSyntax = Employee.GetEmployees().SelectMany(std => std.Programming).ToList();

        //Using Query Syntax
        IEnumerable<string> QuerySyntax = from emp in Employee.GetEmployees()
                                          from program in emp.Programming
                                          select program;

        foreach (string program in MethodSyntax)
        {
            Console.WriteLine(program);
        }
    }
    public static void SelectManyComplex()
    {
        //Using Method Syntax
        var MethodSyntax = Employee.GetEmployees()
                                   .SelectMany(std => std.Programming,
                                         (emp, program) => new
                                         {
                                             EmployeeName = emp.FirstName + " " + emp.LastName,
                                             ProgramName = program
                                         }).ToList();

        foreach (var item in MethodSyntax)
        {
            Console.WriteLine(item.EmployeeName + " => " + item.ProgramName);
        }

        //Using Query Syntax
        var QuerySyntax = (from emp in Employee.GetEmployees()
                           from program in emp.Programming
                           select new
                           {
                               EmployeeName = emp.FirstName + " " + emp.LastName,
                               ProgramName = program
                           }).ToList();

        foreach (var item in QuerySyntax)
        {
            Console.WriteLine(item.EmployeeName + " => " + item.ProgramName);
        }
    }
}

public class Employee
{
    public int ID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public double Salary { get; set; }
    public List<string> Programming { get; set; }
    public static List<Employee> GetEmployees()
    {
        List<Employee> employees = new()
            {
                new() {ID = 101, FirstName = "Dilshod", LastName = "Shodiyev", Salary = 60000,Programming = new List<string>() { "C#", "Jave", "C++"}  },
                new() {ID = 102, FirstName = "Sardor", LastName = "Bozorov", Salary = 70000, Programming = new List<string>() { "WCF", "SQL Server", "C#"}},
                new() {ID = 103, FirstName = "Turon", LastName = "Ahmadov", Salary = 80000, Programming = new List<string>() { "MVC", "Java", "LINQ"}},
                new() {ID = 104, FirstName = "Nodir", LastName = "Temirov", Salary = 90000, Programming = new List<string>() { "ADO.NET", "C#", "LINQ"}},
                new() {ID = 105, FirstName = "Faxriddin", LastName = "Nurmatov", Salary = 100000, Programming = new List<string>() { "C++", "ASP.NET", "PHP"}},
                new() {ID = 106, FirstName = "Nasibali", LastName = "Esonov", Salary = 160000, Programming = new List<string>() { "Java", "Python", "C++"}}
            };
        return employees;
    }
}

