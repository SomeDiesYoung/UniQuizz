public class Student
{
    private static int nextID = 1;

    public int ID { get; private set; } 

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    private float _gpa;
    public float GPA
    {
        get => _gpa;
        set
        {
            if (value < 0.0f || value > 4.0f)
                throw new ArgumentOutOfRangeException("GPA must be between 0.0 and 4.0.");
            _gpa = value;
        }
    }

    public Student()
    {
        ID = nextID++; 
    }

    public int GetAge()
    {
        return DateTime.Now.Year - BirthDate.Year - (DateTime.Now.DayOfYear < BirthDate.DayOfYear ? 1 : 0);
    }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}
