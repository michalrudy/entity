﻿using Microsoft.EntityFrameworkCore;


namespace MyBoards.Entities
{
    public class MyBoardsContext : DbContext

    {
        public MyBoardsContext(DbContextOptions<MyBoardsContext> options) : base(options)
        {
            
        }
        public DbSet<WorkItem> WorkItems {  get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Adress> Adresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
  
            modelBuilder.Entity<WorkItem>(eb =>
                {
                    eb.Property(x => x.State).IsRequired();
                    eb.Property(x => x.Area).HasColumnType("varchar(200)"); 
                    eb.Property(wi => wi.IterationPath).HasColumnName("Iteration_Path");
                    eb.Property(wi => wi.Efford).HasColumnName("decimal(5,2");
                    eb.Property(wi => wi.EndDate).HasPrecision(3);
                    eb.Property(wi => wi.Activity).HasMaxLength(200);
                    eb.Property(wi => wi.ReamaningWork).HasPrecision(14, 2);
                });

        }

    }
}
