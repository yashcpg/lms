using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LmsApp.Models
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){}
        public DbSet<Employee> Employees{get;set;}
                public DbSet<Role> Roles{get;set;}
                        public DbSet<LeaveRequest> LeaveRequests{get;set;}
                                public DbSet<LeaveType> LeaveTypes{get;set;}
        public DbSet<Notification> Notifications
        {get;set;}



        
    }
}