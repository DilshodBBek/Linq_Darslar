public static class CustomSequence_Operators
{
    public static void Start()
    {
        //SequenceEqual();
        //SequenceEqual1();
        //SequenceEqualWithReference();
    }
    public static void SequenceEqual()
    {
        IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

        IList<string> strList2 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

        bool isEqual = strList1.SequenceEqual(strList2); // returns true
        Console.WriteLine(isEqual);
    }
    public static void SequenceEqual1()
    {
        IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

        IList<string> strList2 = new List<string>() { "Two", "One", "Three", "Four", "Three" };

        bool isEqual = strList1.SequenceEqual(strList2); // returns false
        Console.WriteLine(isEqual);
    }
    public static void SequenceEqualWithReference()
    {
        Student std = new Student() { ID = 1, Name = "Bill" };

        IList<Student> studentList1 = new List<Student>() { std };

        IList<Student> studentList2 = new List<Student>() { std };

        bool isEqual = studentList1.SequenceEqual(studentList2); // returns true

        Student std1 = new Student() { ID = 1, Name = "Bill" };
        Student std2 = new Student() { ID = 1, Name = "Bill" };

        IList<Student> studentList3 = new List<Student>() { std1 };

        IList<Student> studentList4 = new List<Student>() { std2 };

        isEqual = studentList3.SequenceEqual(studentList4);// returns false
    }
}

