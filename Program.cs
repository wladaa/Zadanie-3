using System;

public class Person //Definition of the abstract class
{
    public string FirstName;
    public string LastName;

    public Person(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

}


public class Student : Person //Student class inheriting from Preson
{
    public string School;

    public Student(string firstName, string lastName, string school) : base(firstName, lastName)
    {
        this.School = school;
    }

    public void Study()
    {
        Console.WriteLine($"{FirstName} {LastName} is studying at {School}.");
    }
}

public class Teacher : Person //Teacher class inheriting from Person
{
    public string Subject;

    public Teacher(string firstName, string lastName, string subject) : base(firstName, lastName)
    {
        this.Subject = subject;
    }

    public void Teach()
    {
        Console.WriteLine($"{FirstName} {LastName} is teaching {Subject}.");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Student student = new Student("Jan", "Kowalski", "TEB");
        student.Study();

        Teacher teacher = new Teacher("Anna", "Nowak", "Mathematics");
        teacher.Teach();
    }
}


