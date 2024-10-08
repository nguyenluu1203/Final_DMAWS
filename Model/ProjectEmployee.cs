namespace Final_DMAWS.Models
{
    public class ProjectEmployee
    {
        public int EmployeeId { get; set; } // Id nhân viên
        public int ProjectId { get; set; } // Id dự án
        public string Tasks { get; set; } // Nhiệm vụ trong dự án

        public virtual Employee Employee { get; set; } // Nhân viên
        public virtual Project Project { get; set; } // Dự án
    }
}
