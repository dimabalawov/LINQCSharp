


using System.Globalization;

Student[] students = new Student[]
        {
            new Student("John", "Doe", 20, "MIT"),
            new Student("Anna", "Smith", 22, "Stanford University"),
            new Student("Ivan", "Petrov", 19, "University of Oxford"),
            new Student("Emily", "Johnson", 21, "University of Oxford"),
            new Student("Li", "Wang", 23, "Tsinghua University")
        };

var linq1 = from student in students
            select student;
Console.WriteLine("LINQ1:");
foreach (var student in linq1)
    Console.WriteLine(student);

var ext1 = students.Select(i => i);
Console.WriteLine("EXT1:");
foreach (var student in ext1)
    Console.WriteLine(student);

var linq2 = from student in students
            where student.FirstName == "Boris"
            select student;
Console.WriteLine("LINQ2:");
foreach (var student in linq2)
    Console.WriteLine(student);

var ext2 = students.Where(student => student.FirstName == "Boris");
Console.WriteLine("EXT2:");
foreach (var student in ext2)
    Console.WriteLine(student);

var linq3 = from student in students
            where student.LastName.StartsWith("Bro")
            select student;
Console.WriteLine("LINQ3:");
foreach (var student in linq3)
    Console.WriteLine(student);

var ext3 = students.Where(student => student.LastName.StartsWith("Bro"));
Console.WriteLine("EXT3:");
foreach (var student in ext3)
    Console.WriteLine(student);

var linq4 = from student in students
            where student.Age > 19
            select student;
Console.WriteLine("LINQ4:");
foreach (var student in linq4)
    Console.WriteLine(student);

var ext4 = students.Where(student => student.Age > 19);
Console.WriteLine("EXT4:");
foreach (var student in ext4)
    Console.WriteLine(student);

var linq5 = from student in students
            where student.Age > 20
            where student.Age < 23
            select student;
Console.WriteLine("LINQ5:");
foreach (var student in linq5)
    Console.WriteLine(student);

var ext5 = students.Where(student => student.Age > 20 && student.Age < 23);
Console.WriteLine("EXT5:");
foreach (var student in ext5)
    Console.WriteLine(student);

var linq6 = from student in students
            where student.University == "MIT"
            select student;
Console.WriteLine("LINQ6:");
foreach (var student in linq6)
    Console.WriteLine(student);

var ext6 = students.Where(student => student.University == "MIT");
Console.WriteLine("EXT6:");
foreach (var student in ext6)
    Console.WriteLine(student);

var linq7 = from student in students
            where student.University == "Oxford"
            where student.Age > 18
            orderby student descending
            select student;
Console.WriteLine("LINQ7:");
foreach (var student in linq7)
    Console.WriteLine(student);

var ext7 = students.Where(student => student.University == "Oxford" && student.Age > 18).OrderByDescending(student => student);
Console.WriteLine("EXT7:");
foreach (var student in ext7)
    Console.WriteLine(student);

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string University { get; set; }

    public Student(string firstName, string lastName, int age, string university)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        University = university;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {Age} years old, studies at {University}";
    }
}