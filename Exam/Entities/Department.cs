using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Entities
{
    public class Department
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string name { get; set; }

        [Required]
        [StringLength(200)]
        public string code { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string location { get; set; }

        [Required]
        public int numberOfPersonals { get; set; }

        public ICollection<Employee> employees { get; set; }
    }
}
