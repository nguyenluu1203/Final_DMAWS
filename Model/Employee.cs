﻿using System;
using System.Collections.Generic;

namespace Final_DMAWS.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; } // Id nhân viên
        public string EmployeeName { get; set; } // Tên nhân viên
        public DateTime EmployeeDOB { get; set; } // Ngày tháng năm sinh
        public string EmployeeDepartment { get; set; } // Bộ phận

        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; } = new List<ProjectEmployee>();
    }
}