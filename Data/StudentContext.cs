using _212.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting.Server;
//using System.Data.Entity;//winform
using Microsoft.EntityFrameworkCore;//webapi
using System.Security.Cryptography;
using System;
namespace _212.Data
{
    public class StudentContext : DbContext
    {
        // public StudentContext() : base("name=StudentDBConnectionString") //winform
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) //webapi
        {
        }

        public DbSet<Student> Students { get; set; }

    }
}
