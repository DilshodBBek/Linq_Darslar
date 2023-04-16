public static class Join_Operators
{
    public static void Start()
    {
        //InnerJoinMetodSyntax();
        //InnerJoinQuerySyntax();
        //JoinMultipleDatabasesUsingQS();
        //JoinMultipleDatabasesUsingMS();

        //GroupJoinMethodSyntax();
        //GroupJoinQuerySyntax();

        //LeftJoinQuerySyntax();
        //LeftJoinMethodSyntax();

        //RightJoinQuerySyntax();

        //FullJoinQS();
        //FullJoinMS();

        //CrossJoinQS();
    }
    public static void InnerJoinMetodSyntax()
    {
        var JoinUsingMS = Employees.GetAllEmployees()
                       .Join(Address.GetAllAddresses(),
                       employee => employee.AddressId,
                       address => address.ID,
                       (employee, address) => new
                       {
                           EmployeeName = employee.Name,
                           AddressLine = address.AddressLine
                       }).ToList();

        foreach (var employee in JoinUsingMS)
        {
            Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
        }
    }
    public static void InnerJoinQuerySyntax()
    {
        var JoinUsingQS = (from emp in Employees.GetAllEmployees()
                           join address in Address.GetAllAddresses()
                           on emp.AddressId equals address.ID
                           select new
                           {
                               EmployeeName = emp.Name,
                               AddressLine = address.AddressLine
                           }).ToList();

        foreach (var employee in JoinUsingQS)
        {
            Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
        }
    }
    public static void JoinMultipleDatabasesUsingQS()
    {
        var JoinMultipleDSUsingQS = (from emp in Employees.GetAllEmployees()

                                     join adrs in Address.GetAllAddresses()
                                     on emp.AddressId equals adrs.ID

                                     join dept in Department.GetAllDepartments()
                                     on emp.DepartmentId equals dept.ID

                                     select new
                                     {
                                         ID = emp.ID,
                                         EmployeeName = emp.Name,
                                         DepartmentName = dept.Name,
                                         AddressLine = adrs.AddressLine
                                     }).ToList();

        foreach (var employee in JoinMultipleDSUsingQS)
        {
            Console.WriteLine($"ID = {employee.ID}, Name = {employee.EmployeeName}, Department = {employee.DepartmentName}, Addres = {employee.AddressLine}");
        }
    }
    public static void JoinMultipleDatabasesUsingMS()
    {
        var JoinMultipleDSUsingMS = Employees.GetAllEmployees()
                                    .Join(
                                            Address.GetAllAddresses(), //Inner Data Source 1
                                            empLevel1 => empLevel1.AddressId, //Outer Key selector
                                            addLevel1 => addLevel1.ID, //Inner Key selector
                                                                       //Result set
                                            (empLevel1, addLevel1) => new { empLevel1, addLevel1 }
                                         )
                                    .Join(
                                            Department.GetAllDepartments(), //Inner Data Source 2
                                                                            //You cannot access the outer key selector directly
                                                                            //You can only access with the result set created in previous step
                                                                            //i.e. using empLevel1 and addLevel1
                                            empLevel2 => empLevel2.empLevel1.DepartmentId, //Outer Key selector
                                            deptLevel1 => deptLevel1.ID, //Inner Key selector
                                                                         //Result set
                                            (empLevel2, deptLevel1) => new { empLevel2, deptLevel1 }
                                         )
                                    .Select(e => new
                                    {
                                        ID = e.empLevel2.empLevel1.ID,
                                        EmployeeName = e.empLevel2.empLevel1.Name,
                                        AddressLine = e.empLevel2.addLevel1.AddressLine,
                                        DepartmentName = e.deptLevel1.Name
                                    }).ToList();

        foreach (var employee in JoinMultipleDSUsingMS)
        {
            Console.WriteLine($"ID = {employee.ID}, Name = {employee.EmployeeName}, Department = {employee.DepartmentName}, Addres = {employee.AddressLine}");
        }
    }

    public static void GroupJoinMethodSyntax()
    {
        var GroupJoinMS = Department.GetAllDepartments(). //Outer Data Source i.e. Departments
                GroupJoin( //Performing Group Join with Inner Data Source
                    Employees.GetAllEmployees(), //Inner Data Source
                    dept => dept.ID, //Outer Key Selector  i.e. the Common Property
                    emp => emp.DepartmentId, //Inner Key Selector  i.e. the Common Property
                    (dept, emp) => new { dept, emp } //Projecting the Result to an Anonymous Type
                );
        //Printing the Result set
        //Outer Foreach is for Each department
        foreach (var item in GroupJoinMS)
        {
            Console.WriteLine("Department :" + item.dept.Name);
            //Inner Foreach loop for each employee of a Particular department
            foreach (var employee in item.emp)
            {
                Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
            }
        }
    }
    public static void GroupJoinQuerySyntax()
    {
        var GroupJoinQS = from dept in Department.GetAllDepartments() //Outer Data Source i.e. Departments
                          join emp in Employees.GetAllEmployees() //Joining with Inner Data Source i.e. Employees
                          on dept.ID equals emp.DepartmentId //Joining Condition
                          into EmployeeGroups //Projecting the Joining Result into EmployeeGroups
                                              //Final Result include each department and the corresponding employees
                          select new { dept, EmployeeGroups };
        //Printing the Result set
        //Outer Foreach is for Each department
        foreach (var item in GroupJoinQS)
        {
            Console.WriteLine("Department :" + item.dept.Name);
            //Inner Foreach loop for each employee of a Particular department
            foreach (var employee in item.EmployeeGroups)
            {
                Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
            }
        }
    }

    public static void LeftJoinQuerySyntax()
    {
        //Performing Left Outer Join using LINQ using Query Syntax
        //Left Data Source: Employees
        //Right Data Source: Addresses
        //Note: Left and Right Data Source Matters
        var QSOuterJoin = from emp in Employees.GetAllEmployees() //Left Data Source
                          join add in Address.GetAllAddresses() //Right Data Source
                          on emp.AddressId equals add.ID //Inner Join Condition
                          into EmployeeAddressGroup //Performing LINQ Group Join
                          from address in EmployeeAddressGroup.DefaultIfEmpty() //Performing Left Outer Join
                          select new { emp, address }; //Projecting the Result to Anonymous Type
                                                       //Accessing the Elements using For Each Loop
        foreach (var item in QSOuterJoin)
        {
            //Before Accessing the AddressLine, please check null else you will get Null Reference Exception
            Console.WriteLine($"Name : {item.emp.Name}, Address : {item.address?.AddressLine} ");
        }
    }
    public static void LeftJoinMethodSyntax()
    {
        //Performing Left Outer Join using LINQ using Method Syntax
        //Left Data Source: Employees
        //Right Data Source: Addresses
        //Note: Left and Right Data Source Matters
        var MSOuterJOIN = Employees.GetAllEmployees() //Left Data Source
                                                      //Performing Group join with Right Data Source
                          .GroupJoin(
                                Address.GetAllAddresses(), //Right Data Source
                                employee => employee.AddressId, //Outer Key Selector, i.e. Left Data Source Common Property
                                address => address.ID, //Inner Key Selector, i.e. Right Data Source Common Property
                                (employee, address) => new { employee, address } //Projecting the Result
                          )
                          .SelectMany(
                                x => x.address.DefaultIfEmpty(), //Performing Left Outer Join 
                                (employee, address) => new { employee, address } //Final Result Set
                           );
        //Accessing the Elements using For Each Loop
        foreach (var item in MSOuterJOIN)
        {
            Console.WriteLine($"Name : {item.employee.employee.Name}, Address : {item.address?.AddressLine} ");
        }
    }

    public static void RightJoinQuerySyntax()
    {
        //Performing Right Outer Join using LINQ using Query Syntax
        //Changing the Data Sources
        //Left Data Source: Addresses 
        //Right Data Source: Employees
        //Note: Left and Right Data Source Matters
        var QSRightJoin = from add in Address.GetAllAddresses()  //Left Data Source
                          join emp in Employees.GetAllEmployees() //Right Data Source
                          on add.ID equals emp.AddressId //Inner Join Condition
                          into EmployeeAddressGroup //Performing LINQ Group Join
                          from employee in EmployeeAddressGroup.DefaultIfEmpty() //Performing Left Outer Join
                          select new { add, employee }; //Projecting the Result to Anonymous Type
                                                        //Accessing the Elements using For Each Loop
        foreach (var item in QSRightJoin)
        {
            //Before Accessing the AddressLine, please check null else you will get Null Reference Exception
            Console.WriteLine($"Name : {item.employee?.Name}, Address : {item.add?.AddressLine} ");
        }
    }

    public static void FullJoinQS()
    {
        //Full Outer Join = Left Outer Join UNION Right Outer Join
        //Performinng Left Outer Join
        var LeftOuterJoin = from emp in Employees.GetAllEmployees()
                            join dept in Department.GetAllDepartments()
                            on emp.DepartmentId equals dept.ID into EmployeeDepartmentGroup
                            from department in EmployeeDepartmentGroup.DefaultIfEmpty()
                            select new
                            {
                                //To Avoid Runtime Null Reference Exception, check NULL 
                                EmployeeId = emp?.ID,
                                EmployeeName = emp?.Name,
                                DepartmentName = department?.Name
                            };
        var RightOuterJoin = from dept in Department.GetAllDepartments()
                             join emp in Employees.GetAllEmployees()
                             on dept.ID equals emp.DepartmentId into EmployeeDepartmentGroup
                             from employee in EmployeeDepartmentGroup.DefaultIfEmpty()
                             select new
                             {
                                 //To Avoid Runtime Null Reference Exception, check NULL 
                                 EmployeeId = employee?.ID,
                                 EmployeeName = employee?.Name ?? "NA",
                                 DepartmentName = dept?.Name ?? "NA"
                             };
        var FullOuterJoin = LeftOuterJoin.Union(RightOuterJoin);
        foreach (var emp in FullOuterJoin)
        {
            Console.WriteLine($"EmployeeId: {emp.EmployeeId}, Name: {emp.EmployeeName}, Department: {emp.DepartmentName}");
        }
    }
    public static void FullJoinMS()
    {
        //Performing Left Outer Join using LINQ using Method Syntax
        var MSLeftOuterJOIN = Employees.GetAllEmployees() //Left Data Source
                                                          //Performing Group join with Right Data Source
                          .GroupJoin(
                                Department.GetAllDepartments(), //Right Data Source
                                employee => employee.DepartmentId, //Outer Key Selector, i.e. Left Data Source Common Property
                                department => department.ID, //Inner Key Selector, i.e. Right Data Source Common Property
                                (employee, department) => new { employee, department } //Projecting the Result
                          )
                          .SelectMany(
                                x => x.department.DefaultIfEmpty(), //Performing Left Outer Join 
                                                                    //Final Result Set
                                (employee, department) => new
                                {
                                    EmployeeId = employee?.employee?.ID,
                                    EmployeeName = employee?.employee?.Name,
                                    DepartmentName = department?.Name
                                }
                           );
        //Performing Right Outer Join using LINQ using Method Syntax
        var MSRightOuterJOIN = Department.GetAllDepartments() //Left Data Source
                                                              //Performing Group join with Right Data Source
                          .GroupJoin(
                                Employees.GetAllEmployees(), //Right Data Source
                                department => department.ID, //Outer Key Selector, i.e. Left Data Source Common Property
                                employee => employee.DepartmentId, //Inner Key Selector, i.e. Right Data Source Common Property
                                (department, employee) => new { department, employee } //Projecting the Result
                          )
                          .SelectMany(
                                x => x.employee.DefaultIfEmpty(), //Performing Left Outer Join 
                                                                  //Final Result Set
                                (department, employee) => new
                                {
                                    EmployeeId = employee?.ID,
                                    EmployeeName = employee?.Name,
                                    DepartmentName = department?.department?.Name
                                }
                           );
        var FullOuterJoin = MSLeftOuterJOIN.Union(MSRightOuterJOIN);
        //Accessing the Elements using For Each Loop
        foreach (var emp in FullOuterJoin)
        {
            Console.WriteLine($"EmployeeId: {emp.EmployeeId}, Name: {emp.EmployeeName}, Department: {emp.DepartmentName}");
        }
    }

    public static void CrossJoinQS()
    {
        //Cross Join using Query Syntax
        var CrossJoinResult = from student in Student.GetAllStudents() //First Data Source
                              from subject in Subject.GetAllSubjects() //Cross Join with Second Data Source
                                                                       //Projecting the Result to Anonymous Type
                              select new
                              {
                                  StudentName = student.Name,
                                  SubjectName = subject.SubjectName
                              };
        //Accessing the Elements using For Each Loop
        foreach (var item in CrossJoinResult)
        {
            Console.WriteLine($"Name : {item.StudentName}, Subject: {item.SubjectName}");
        }

    }
    public static void CrossJoinMS()
    {
        //Cross Join using SelectMany Method
        var CrossJoinResult = Student.GetAllStudents()
                    .SelectMany(sub => Subject.GetAllSubjects(),
                     (std, sub) => new
                     {
                         StudentName = std.Name,
                         SubjectName = sub.SubjectName
                     });
        //Cross Join using Join Method
        var CrossJoinResult2 = Student.GetAllStudents()
                    .Join(Subject.GetAllSubjects(),
                        std => true,
                        sub => true,
                        (std, sub) => new
                        {
                            StudentName = std.Name,
                            SubjectName = sub.SubjectName
                        }
                     );
        foreach (var item in CrossJoinResult2)
        {
            Console.WriteLine($"Name : {item.StudentName}, Subject: {item.SubjectName}");
        }
    }
}
public class Employees
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int AddressId { get; set; }
    public int DepartmentId { get; set; }
    public static List<Employees> GetAllEmployees()
    {
        return new List<Employees>()
            {
                new Employees { ID = 1, Name = "Sherali", AddressId = 1, DepartmentId=1 },
                new Employees { ID = 2, Name = "Alisher", AddressId = 2, DepartmentId=1 },
                new Employees { ID = 3, Name = "Anvar", AddressId = 3, DepartmentId=3 },
                new Employees { ID = 4, Name = "Rustam", AddressId = 4, DepartmentId=1 },
                new Employees { ID = 5, Name = "Bektosh", AddressId = 5, DepartmentId=2 },
                new Employees { ID = 6, Name = "Dilmurod", AddressId = 6, DepartmentId=1 },
                new Employees { ID = 7, Name = "Akobir", AddressId = 7, DepartmentId=3},
                new Employees { ID = 8, Name = "Turon", AddressId = 8, DepartmentId=2 },
                new Employees { ID = 9, Name = "Jamshid", AddressId = 9, DepartmentId=2 },
                new Employees { ID = 10, Name = "G'ayrat", AddressId = 10, DepartmentId=1},
                new Employees { ID = 11, Name = "Avaz", AddressId = 11, DepartmentId=3}
            };
    }

}
public class Address
{
    public int ID { get; set; }
    public string AddressLine { get; set; }
    public static List<Address> GetAllAddresses()
    {
        return new List<Address>()
            {
                new Address { ID = 1, AddressLine = "AddressLine1"},
                new Address { ID = 2, AddressLine = "AddressLine2"},
                new Address { ID = 3, AddressLine = "AddressLine3"},
                new Address { ID = 4, AddressLine = "AddressLine4"},
                new Address { ID = 5, AddressLine = "AddressLine5"},
                new Address { ID = 9, AddressLine = "AddressLine9"},
                new Address { ID = 10, AddressLine = "AddressLine10"},
                new Address { ID = 11, AddressLine = "AddressLine11"},
            };
    }
}
public class Department
{
    public int ID { get; set; }
    public string Name { get; set; }
    public static List<Department> GetAllDepartments()
    {
        return new List<Department>()
            {
                new Department { ID = 1, Name = "IT"       },
                new Department { ID = 2, Name = "HR"       },
                new Department { ID = 3, Name = "Payroll"  },
            };
    }
}
public class Subject
{
    public int ID { get; set; }
    public string SubjectName { get; set; }
    public static List<Subject> GetAllSubjects()
    {
        return new List<Subject>()
            {
                new Subject { ID = 1, SubjectName = "ASP.NET"},
                new Subject { ID = 2, SubjectName = "SQL Server" },
                new Subject { ID = 5, SubjectName = "Linq"}
            };
    }
}

