    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace University_System.Models
    {
    public class Department
    {

    [Key]
    public int departmentId { get; set; } // system generated
        
    [Required]
    [MaxLength(100)]
    public string departmentName { get; set; } // user input

    [MaxLength(50)]
    public string building { get; set; } // user input

    [Required]
    [Range(0.0, double.MaxValue)]  
    public decimal budget { get; set; } // user input

    [ForeignKey("HeadInstructor")]
    public int headInstructorId { get; set; } // foreign key

    public Instructor HeadInstructor { get; set; } // system generated

    public ICollection<Course> Courses { get; set; } = new List<Course>();// system generated
    }
    }
