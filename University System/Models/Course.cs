    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace University_System.Models
    {
    public class Course
    {

    [Key]
    public int courseId { get; set; } // system generated 

    [Required]
    [MaxLength(10)]
    public string courseCode { get; set; } // user input 

    [Required]
    [MaxLength(150)]
    public string courseTitle { get; set; } // user input 

    [Required]
    [Range(1, 6)]
    public int creditHours { get; set; } // user input 
        
    [Required]
    [ForeignKey("Department")]
    public int departmentId { get; set; } // foreign key 

    [ForeignKey("Instructor")]
    public int instructorId { get; set; } // foreign key 

    [Required]
    [MaxLength(20)]
    public string semesterOffered { get; set; } // user input 

    public Department Department { get; set; } // system generated 

    public Instructor? Instructor { get; set; } // system generated 

    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>(); // system generated 
    }
    }
