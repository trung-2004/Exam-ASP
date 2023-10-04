using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam.Models.Employee
{
    public class EmployeeViewModel
    {
        [Required(ErrorMessage = "Vui long nhap ten")]
        [Display(Name = "Name")]// hien thi ra ngoai view
        public string name { get; set; }

        [Required(ErrorMessage = "Vui long nhap ten code")]
        [Display(Name = "Code")]
        public string code { get; set; }

        
        [Required(ErrorMessage = "Vui long chon address")]
        [Display(Name = "Rank")]
        public string rank { get; set; }

        [Required(ErrorMessage = "Vui long chon danh muc")]
        [Display(Name = "Department")]
        public int department_id { get; set; }
    }
}
