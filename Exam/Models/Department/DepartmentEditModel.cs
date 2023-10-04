using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Models.Department
{
    public class DepartmentEditModel
    {
        [Required]
        public int id { get; set; }

        [Required(ErrorMessage = "Vui long nhap ten")]
        [Display(Name = "Name")]// hien thi ra ngoai view
        public string name { get; set; }

        [Required(ErrorMessage = "Vui long nhap ten code")]
        [Display(Name = "Price")]
        public string code { get; set; }

        [Column(TypeName = "text")]
        [Required(ErrorMessage = "Vui long chon address")]
        [Display(Name = "Location")]
        public string location { get; set; }

        [Required(ErrorMessage = "Vui long nhap ten code")]
        [Display(Name = "numberOfPersonals")]
        public int numberOfPersonals { get; set; }
    }
}
