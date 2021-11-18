using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using attendance.Models;

    public class AttendanceContext : DbContext
    {
        public AttendanceContext (DbContextOptions<AttendanceContext> options)
            : base(options)
        {
        }

        public DbSet<attendance.Models.Attendance> Attendance { get; set; }
    }
