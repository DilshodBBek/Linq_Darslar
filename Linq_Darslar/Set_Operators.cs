namespace Linq_Darslar
{
    public class Set_Operators
    {
        public static void Start()
        {

        }

        public static void Distinct1()
        {
            List<int> intCollection = new List<int>()
            {
                1,2,3,2,3,4,4,5,6,3,4,5
            };
            //Using Method Syntax
            var MS = intCollection.Distinct();
            //Using Query Syntax
            var QS = (from num in intCollection
                      select num).Distinct();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }

        public static void Distinct2()
        {
            string[] namesArray = { "Abdulatif", "YUSUF", "Xurshid", "Hasan", "Xurshid", "Yusuf" };

            var distinctNames = namesArray.Distinct();

            foreach (var name in distinctNames)
            {
                Console.WriteLine(name);
            }
        }

        public static void Distinct3()
        {
            string[] namesArray = { "Abdulatif", "YUSUF", "Xurshid", "Hasan", "Xurshid", "Yusuf" };

            var distinctNames = namesArray.Distinct(StringComparer.OrdinalIgnoreCase);

            foreach (var name in distinctNames)
            {
                Console.WriteLine(name);
            }
        }

        public static void Distinct4()
        {
            //Using Method Syntax
            var MS = Student.GetAllStudents()
                    .Select(std => std.Name)
                    .Distinct().ToList();
            //Using Query Syntax
            var QS = (from std in Student.GetAllStudents()
                      select std.Name)
                      .Distinct().ToList();

            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }

        public static void Except1()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
            //Method Syntax
            var MS = dataSource1.Except(dataSource2).ToList();
            //Query Syntax
            var QS = (from num in dataSource1
                      select num)
                      .Except(dataSource2).ToList();
            foreach (var item in QS)
            {
                Console.Write(item + " ");
            }
        }

        public static void Except2()
        {
            List<Student1> AllStudents = new()
            {
                new Student1 { ID = 101, Name = "Xurshid" },
                new Student1 { ID = 102, Name = "Jamol" },
                new Student1 { ID = 103, Name = "Xojiakbar" },
                new Student1 { ID = 104, Name = "Kamol" },
                new Student1 { ID = 105, Name = "Olim" },
                new Student1 { ID = 106, Name = "Adham" },
            };
            List<Student1> Class6Students = new()
            {
                new Student1 {ID = 102, Name = "Jamol" },
                new Student1 {ID = 104, Name = "Kamol"},
                new Student1 {ID = 105, Name = "Olim" }
            };
            //Method Syntax
            var MS = AllStudents
            .Except(Class6Students).ToList();
            //Query Syntax
            var QS = (from std in AllStudents
                      select std)
            .Except(Class6Students).ToList();
            foreach (var student in QS)
            {
                Console.WriteLine($" ID: {student.ID} Name {student.Name}");
            }
        }

        public static void Except3()
        {
            List<Student1> AllStudents = new()
            {
                new Student1 { ID = 101, Name = "Xurshid" },
                new Student1 { ID = 102, Name = "Jamol" },
                new Student1 { ID = 103, Name = "Xojiakbar" },
                new Student1 { ID = 104, Name = "Kamol" },
                new Student1 { ID = 105, Name = "Olim" },
                new Student1 { ID = 106, Name = "Adham" },
            };
            List<Student1> Class6Students = new()
            {
                new Student1 {ID = 102, Name = "Jamol" },
                new Student1 {ID = 104, Name = "Kamol"},
                new Student1 {ID = 105, Name = "Olim" }
            };

            //Method Syntax
            var MS = AllStudents.Except(Class6Students).ToList();
            //Query Syntax
            var QS = (from std in AllStudents
                      select std).Except(Class6Students).ToList();
            
            foreach (var student in MS)
            {
                Console.WriteLine($" ID : {student.ID} Name : {student.Name}");
            }
        }

        public static void Except4()
        {
            List<Student> AllStudents = new List<Student>()
            {
                new Student {ID = 101, Name = "Preety" },
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 103, Name = "Hina"},
                new Student {ID = 104, Name = "Anurag"},
                new Student {ID = 105, Name = "Pranaya"},
                new Student {ID = 106, Name = "Santosh"},
            };
            List<Student> Class6Students = new List<Student>()
            {
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 104, Name = "Anurag"},
                new Student {ID = 105, Name = "Pranaya"},
            };

            //Method Syntax
            var MS = AllStudents.Select(x => new { x.ID, x.Name })
                    .Except(Class6Students.Select(x => new { x.ID, x.Name })).ToList();
            //Query Syntax
            var QS = (from std in AllStudents
                      select new { std.ID, std.Name })
                      .Except(Class6Students.Select(x => new { x.ID, x.Name })).ToList();

            foreach (var student in QS)
            {
                Console.WriteLine($" ID : {student.ID} Name : {student.Name}");
            }
        }

        public static void Intersect1()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
            //Method Syntax
            var MS = dataSource1.Intersect(dataSource2).ToList();
            //Query Syntax
            var QS = (from num in dataSource1
                      select num)
                      .Intersect(dataSource2).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }

        }

        public static void Intersect2()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = null;
            //Method Syntax
            var MS = dataSource1.Intersect(dataSource2).ToList();

            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }

        public static void Intersect3()
        {
            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            //Method Syntax
            var MS = dataSource1.Intersect(dataSource2).ToList();
            //Query Syntax
            var QS = (from country in dataSource1
                      select country)
                      .Intersect(dataSource2).ToList();
            foreach (var item in QS)
            {
                Console.WriteLine(item);
            }

        }

        public static void Intersect4()
        {
            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            //Method Syntax
            var MS = dataSource1.Intersect(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            //Query Syntax
            var QS = (from country in dataSource1
                      select country)
                      .Intersect(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            foreach (var item in QS)
            {
                Console.WriteLine(item);
            }
        }

        public static void Intersect5()
        {
            List<Student1> StudentCollection1 = new List<Student1>()
            {
                new Student1 {ID = 101, Name = "Preety" },
                new Student1 {ID = 102, Name = "Sambit" },
                new Student1 {ID = 105, Name = "Hina"},
                new Student1 {ID = 106, Name = "Anurag"},
            };
            List<Student1> StudentCollection2 = new List<Student1>()
            {
                new Student1 {ID = 105, Name = "Hina"},
                new Student1 {ID = 106, Name = "Anurag"},
                new Student1 {ID = 107, Name = "Pranaya"},
                new Student1 {ID = 108, Name = "Santosh"},
            };

            //Method Syntax
            var MS = StudentCollection1.Select(x => x.Name)
                     .Intersect(StudentCollection2.Select(y => y.Name)).ToList();
            //Query Syntax
            var QS = (from std in StudentCollection1
                      select std.Name)
                      .Intersect(StudentCollection2.Select(y => y.Name)).ToList();
            foreach (var name in MS)
            {
                Console.WriteLine(name);
            }

        }

        public static void Union1()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
            //Method Syntax
            var MS = dataSource1.Union(dataSource2).ToList();
            //Query Syntax
            var QS = (from num in dataSource1
                      select num)
                      .Union(dataSource2).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }

        public static void Union2()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = null;
            //Method Syntax
            var MS = dataSource1.Union(dataSource2).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }

        public static void Union3()
        {
            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            //Method Syntax
            var MS = dataSource1.Union(dataSource2).ToList();
            //Query Syntax
            var QS = (from country in dataSource1
                      select country)
                      .Union(dataSource2).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }

        public static void Union4()
        {
            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            //Method Syntax
            var MS = dataSource1.Union(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            //Query Syntax
            var QS = (from country in dataSource1
                      select country)
                      .Union(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Student1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Equals(Student other) =>
            this.ID.Equals(other.ID) && this.Name.Equals(other.Name);
        public override int GetHashCode()
        {
            int IDHashCode = this.ID.GetHashCode();
            int NameHashCode = this.Name == null ? 0 : this.Name.GetHashCode();
            return IDHashCode ^ NameHashCode;
        }
    }
}
