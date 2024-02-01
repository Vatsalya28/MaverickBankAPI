﻿using MaverickBankAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace MaverickBankAPI.Contexts
{
    public class RequestTrakerContext : DbContext
    {
        public RequestTrakerContext(DbContextOptions options) : base(options)
        {


        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }
        public DbSet<BankEmployee> BankEmployees { get; set; }
        public DbSet<Administrator> Administrators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserID);
                entity.Property(e => e.UserName).IsRequired();
                entity.Property(e => e.Password).IsRequired();
                
            });


            modelBuilder.Entity<Customer>()
           .HasKey(c => c.CustomerID);

            modelBuilder.Entity<Customer>()
                .Property(c => c.Name)
                .IsRequired();

            
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.User)
                .WithMany(u => u.Customers)
                .HasForeignKey(c => c.UserID);



            modelBuilder.Entity<Account>()
            .HasKey(a => a.AccountID);

            modelBuilder.Entity<Account>()
                .Property(a => a.AccountType).IsRequired();
                

            
            modelBuilder.Entity<Account>()
                .HasOne(a => a.Customer)
                .WithMany(c => c.Accounts)
                .HasForeignKey(a => a.CustomerID);


            modelBuilder.Entity<Transaction>()
            .HasKey(t => t.TransactionID);

            modelBuilder.Entity<Transaction>()
                .Property(t => t.TransactionType)
                .IsRequired();

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Account)
                .WithMany(a => a.Transactions)
                .HasForeignKey(t => t.AccountID)
                .OnDelete(DeleteBehavior.NoAction);

           





            modelBuilder.Entity<Loan>()
                    .HasKey(l => l.LoanID);

            modelBuilder.Entity<Loan>()
                    .Property(l => l.Status)
                    .HasDefaultValue("Pending");

            modelBuilder.Entity<Loan>()
                    .HasOne(l => l.Customer)
                    .WithMany(c => c.Loans)
                    .HasForeignKey(l => l.CustomerID)
                    .IsRequired();

            //modelBuilder.Entity<Beneficiary>()
            //   .HasKey(b => b.BeneficiaryID);

            //modelBuilder.Entity<Beneficiary>()
            //    .HasOne(b => b.Customer)
            //    .WithMany(c => c.Beneficiaries)
            //    .HasForeignKey(b => b.CustomerID)
            //    .IsRequired();





            modelBuilder.Entity<Beneficiary>()
            .HasKey(b => b.BeneficiaryID);


            modelBuilder.Entity<Beneficiary>()
            .HasOne(b => b.Bank)
            .WithMany(bank => bank.Beneficiaries)
            .HasForeignKey(b => b.BankID);



            modelBuilder.Entity<Beneficiary>()
                .HasOne(b => b.Customer)
                .WithMany(customer => customer.Beneficiaries)
                .HasForeignKey(b => b.CustomerID);
               


            modelBuilder.Entity<BankEmployee>()
                .HasKey(be => be.EmployeeID);

            modelBuilder.Entity<BankEmployee>()
                .HasOne(be => be.User)
                .WithMany(u => u.BankEmployees)
                .HasForeignKey(be => be.UserID)
                .IsRequired();

            modelBuilder.Entity<Administrator>()
                .HasKey(a => a.AdministratorID);

            modelBuilder.Entity<Administrator>()
                .HasOne(a => a.User)
                .WithMany(u => u.Administrators)
                .HasForeignKey(a => a.UserID)
                .IsRequired();

        }
    }
}
