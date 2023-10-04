using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam.Models.Department
{
    public class DepartmentViewModel
    {
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
