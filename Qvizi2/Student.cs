using System.ComponentModel.DataAnnotations;

public class Student
{
    private static int nextId = 1;

    public int Id { get; private set; }  

    public int Age { get; set; }
    public string Name { get; set; }

    public Student(string name, int age)
    {
        if (age <= 6) throw new ValidationException("Age must be greater than 5");
        if (string.IsNullOrWhiteSpace(name) || name.Length < 2) throw new ValidationException("Name must be given correctly");

        Id = nextId++;  
        Name = name;
        Age = age;
    }
}
