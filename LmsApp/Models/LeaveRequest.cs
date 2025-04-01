using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LmsApp.Models
{
    public class LeaveRequest
    {
        [Key]
        public int LeaveId{get;set;}

        [Required]
        public int EmpId{get;set;}
        public Employee employee{get;set;}
        [Required]
        public DateTime StartDate{get;set;}
        [Required]
        public DateTime EndDate{get;set;}

        [Required]
        public int LeaveTypeId{get;set;}
        public LeaveType LeaveType{get;set;}
        [Required]
        public string Reason{get;set;}
        [Required]
        public string Status{get;set;}

        public DateTime AppliedOn{get;set;}=DateTime.UtcNow;

    }
}