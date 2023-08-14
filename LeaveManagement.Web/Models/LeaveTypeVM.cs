using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        public int Name { get; set; }
        [Display(Name ="Default Number Of Days")]
        public int DefaultDays { get; set; }
    }
}
