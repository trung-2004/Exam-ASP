using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam.Entities
{
    public class Employee
    {

        [Key]   
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string name { get; set; }

        [Required]
        [StringLength(200)]
        public string code { get; set; }

        public int department_id { get; set; }

        [ForeignKey("department_id")]
        public Department department { get; set; }

        [Required]
        public string rank { get; set; }
    }
}
