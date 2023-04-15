public static class Ordering_Operators
{
    public static void Start()
    {
        //OrderByNumbers();
        //OrderByStudents();
        //OrderByDescending();
        //OrderByDescendingStudents();
        //ThenBy();
        //OrderByComplex();
        //Reverse();
    }
    public static void OrderByNumbers()
    {
        List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };

        //Using Method Syntax
        var MS = intList.OrderBy(num => num);

        //Using Query Syntax
        var QS = (from num in intList
                  orderby num
                  select num).ToList();

        foreach (var item in QS)
        {
            Console.Write(item + " ");
        }
        //Output: 10 29 35 45 50 58 69 100
    }
    public static void OrderByStudents()
    {
        //Method Syntax
        var MS = Student.GetAllStudents().OrderBy(x => x.Branch).ToList();

        //Query Syntax
        var QS = (from std in Student.GetAllStudents()
                  orderby std.Branch
                  select std);
        foreach (var student in MS)
        {
            Console.WriteLine("Branch: " + student.Branch + " Name:" + student.Name + " Age:" + student.Age);
        }
    }
    public static void OrderByDescending()
    {
        List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };
        var MS = intList.OrderByDescending(num => num);
        var QS = (from num in intList
                  orderby num descending
                  select num).ToList();
        foreach (var item in QS)
        {
            Console.Write(item + " ");
        }
        // Output: 100 69 58 50 45 35 29 10
    }
    public static void OrderByDescendingStudents()
    {
        //Method Syntax
        var MS = Student.GetAllStudents().OrderByDescending(x => x.Branch).ToList();

        //Query Syntax
        var QS = (from std in Student.GetAllStudents()
                  orderby std.Branch descending
                  select std);
        foreach (var student in MS)
        {
            Console.WriteLine("Branch: " + student.Branch + " Name:" + student.Name + " Age:" + student.Age);
        }
    }
    public static void ThenBy()
    {
        //Using Method Syntax
        var MS = Student.GetAllStudents()
                        .OrderBy(x => x.Name)
                        .ThenBy(y => y.Age)
                        .ToList();

        //Using Query Syntax
        var QS = (from std in Student.GetAllStudents()
                  orderby std.Name, std.Age
                  select std);

        foreach (var student in QS)
        {
            Console.WriteLine("Name:" + student.Name + ", Age:" + student.Age);
        }
    }
    public static void OrderByComplex()
    {
        //Using Method Syntax
        var MS = Student.GetAllStudents()
                 .OrderBy(x => x.Branch)
                 .ThenByDescending(y => y.Name)
                 .ThenBy(z => z.Age)
                 .ToList();

        //Using Query Syntax
        var QS = (from std in Student.GetAllStudents()
                  orderby std.Branch ascending,
                          std.Name descending,
                          std.Age //by default ascending
                  select std).ToList();

        foreach (var student in QS)
        {
            Console.WriteLine("Branch:" + student.Branch + ", Name:" + student.Name + ", Age:" + student.Age);
        }
    }
    public static void Reverse()
    {
        int[] intArray = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };
        Console.WriteLine("Before Reverse the Data");
        foreach (var number in intArray)
        {
            Console.Write(number + " ");
        }
        //Using Method Syntax
        IEnumerable<int> ReversedDataMetodSyntax = intArray.Reverse();

        //Using Query Syntax
        IEnumerable<int> ReversedDataQuerySyntax = (from num in intArray
                                                    select num).Reverse();

        Console.WriteLine("\nAfter Reverse the Data");
        foreach (var number in ReversedDataMetodSyntax)
        {
            Console.Write(number + " ");
        }
    }
}

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }

    public string Branch { get; set; }
    public int Age { get; set; }
    public static List<Student> GetAllStudents()
    {
        return new List<Student>()
        {
            new Student { ID = 1001, Name = "Abdulatif", Gender = "Male", Branch = "Tuman", Age = 19 },
            new Student { ID = 1001, Name = "Ulug'bek", Gender = "Male", Branch = "Shahar", Age = 25 },
            new Student { ID = 1001, Name = "Xurshid", Gender = "Male", Branch = "Viloyat", Age = 20},
            new Student { ID = 1001, Name = "Jamshid", Gender = "Male", Branch = "Tuman", Age = 18 }
        };
    }
}
