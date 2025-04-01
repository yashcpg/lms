using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LmsApp.Models
{
    public class LeaveType
    {
        [Key]
        public int LeaveTypeId{get;set;}
        [Required]
        public string TypeName{get;set;}

        [Required]
        public int MaxDays{get;set;}
        
    }
}