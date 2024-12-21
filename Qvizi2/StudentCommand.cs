using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public class StudentCommand
{
    
    public string Name { get; set; }
    public int Age { get; set; }

    public void Validate()
    {
 
        if (Age <= 6) throw new ValidationException("Age must be positive");
        if (string.IsNullOrWhiteSpace(Name) || Name.Length < 3) throw new ValidationException("Name must be given correctly");
    }
}