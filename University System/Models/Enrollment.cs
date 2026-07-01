    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace University_System.Models
    {
    public class Enrollment
    {

    [Key]
    public int enrollmentId { get; set; } // system generated 

    [Required]
    [ForeignKey("Student")]
    public int studentId { get; set; } // foreign key 

    [Required]
    [ForeignKey("Course")]
    public int courseId { get; set; } // foreign key 

    [Required]
    public DateTime enrollmentDate { get; set; } // user input 

    [MaxLength(2)]
    public string finalGrade { get; set; } // user input

    [Required]
    [MaxLength(20)]
    public string status { get; set; } = "In Progress"; // default value 

    public Student Student { get; set; } // system generated 
    public Course Course { get; set; } // system generated 
    }
    }
