using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LmsApp.Models
{
    public class Employee
    {
        [Key]
        public int EmpId {get;set;}
        [Required,StringLength(100)]
        public string Name{get;set;}
        [Required,EmailAddress]

        public string Email{get;set;}
        [Required]

        public string Password{get;set;}

        public int LeaveBalance {get;set;}=20;
 
        [Required]
        public int RoleId{get;set;}
        public Role Role{get;set;}
    

        public ICollection<LeaveRequest> LeaveRequests {get;set;}
    }
}