using System;
using System.Collections.Generic;

namespace Final_DMAWS.Models
{
    public class Project
    {
        public int ProjectId { get; set; } // Id thể loại
        public string ProjectName { get; set; } // Tên thể loại
        public DateTime ProjectStartDate { get; set; } // Ngày bắt đầu
        public DateTime? ProjectEndDate { get; set; } // Ngày kết thúc

        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; } = new List<ProjectEmployee>();
    }
}