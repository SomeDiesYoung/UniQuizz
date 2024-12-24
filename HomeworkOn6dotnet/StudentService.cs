using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkOn6dotnet;



public class StudentManager
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    public void UpdateStudent(int id, Student updatedStudent)
    {
        var student = students.FirstOrDefault(s => s.ID == id);
        if (student != null)
        {
            student.FirstName = updatedStudent.FirstName;
            student.LastName = updatedStudent.LastName;
            student.BirthDate = updatedStudent.BirthDate;
            student.GPA = updatedStudent.GPA;
        }
    }

    public void DeleteStudent(int id)
    {
        var student = students.FirstOrDefault(s => s.ID == id);
        if (student != null)
        {
            students.Remove(student);
        }
    }

    public IEnumerable<Student> GetAllStudents()
    {
        return students;
    }

    public IEnumerable<Student> FilterStudentsByGPA(float minGPA, float maxGPA)
    {
        return students.Where(s => s.GPA >= minGPA && s.GPA <= maxGPA);
    }
}
