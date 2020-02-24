﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollection.Models;

namespace TrashCollection.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ServiceInfo> ServiceInfos { get; set; }
        //public DbSet<TrashCollection.Models.EmployeeViewModel> EmployeeViewModel { get; set; }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<IdentityRole>()
        //        .HasData(
        //        new IdentityRole
        //        {
        //            Name = "Admin",
        //            NormalizedName = "ADMIN"
        //        }
        //        );
        //    base.OnModelCreating(builder);

        //    builder.Entity<IdentityRole>()
        //        .HasData(
        //        new IdentityRole
        //        {
        //            Name = "Customer",
        //            NormalizedName = "CUSTOMER"
        //        }
        //        );
        //    base.OnModelCreating(builder);

        //    builder.Entity<IdentityRole>()
        //        .HasData(
        //        new IdentityRole
        //        {
        //            Name = "Employee",
        //            NormalizedName = "EMPLOYEE"
        //        }
        //        );
        //}
    }
}
