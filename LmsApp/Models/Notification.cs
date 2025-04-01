using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LmsApp.Models
{
    public class Notification
    {
        public int NotId{get;set;}
        public int UserId{get;set;}
        public Employee Employee{get;set;}
        public string Message {get;set;}

        public DateTime SentAt{get;set;}=DateTime.UtcNow;
    }
}