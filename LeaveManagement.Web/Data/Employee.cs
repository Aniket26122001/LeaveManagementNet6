using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data
{
    public class Employee : IdentityUser
    {
        public String? Firstname { get; set; }
        public String? Lastname { get; set; }
        public String? TexId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }

    }
}
