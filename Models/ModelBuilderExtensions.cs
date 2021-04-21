﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Pari",
                    Department = Dept.IT,
                    Email = "pari@gmail.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Pakhi",
                    Department = Dept.HR,
                    Email = "pakhi@gmail.com"
                }
                );
        }
    }
}
