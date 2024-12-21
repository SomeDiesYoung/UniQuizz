public class StudentService
{
    private List<Student> students = new List<Student>();

    public void AddStudent(StudentCommand command)
    {
        command.Validate();

        var newStudent = new Student(
            name: command.Name,
            age: command.Age
        );
        students.Add(newStudent);
    }

    public void UpdateStudent(int id, Student updatedStudent)
    {
        var student = students.FirstOrDefault(s => s.Id == id); 
        if (student != null)
        {
            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
        }
    }

    public void DeleteStudent(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);  
        if (student != null)
        {
            students.Remove(student);
        }
    }

    public IEnumerable<Student> GetAllStudents()
    {
        return students;
    }
}
