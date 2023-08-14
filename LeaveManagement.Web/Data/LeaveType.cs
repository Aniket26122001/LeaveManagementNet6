namespace LeaveManagement.Web.Data
{
    public class LeaveType : BaseEntity
    {
        public String Name { get; set; }
        public int DefaultDays { get; set; }
        
    }
}
