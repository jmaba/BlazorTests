﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MasterDetailCRUD.Shared.Models
{
    public partial class OrderManagementContext : DbContext
    {
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<OrderMasters> OrderMasters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=OrderManagement;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderDetailNo);

                entity.Property(e => e.OrderDetailNo).HasColumnName("Order_Detail_No");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("Item_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("Order_No");

                entity.Property(e => e.Qty).HasColumnName("QTY");
            });

            modelBuilder.Entity<OrderMasters>(entity =>
            {
                entity.HasKey(e => e.OrderNo);

                entity.Property(e => e.OrderNo).HasColumnName("Order_No");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TableId)
                    .IsRequired()
                    .HasColumnName("Table_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WaiterName)
                    .IsRequired()
                    .HasColumnName("Waiter_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
