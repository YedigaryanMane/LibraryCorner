﻿using LibraryCorner.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryCorner
{
    public class DataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Author> Author { get; set; }


        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(b => b.Books)
                .WithMany(d => d.User);

            modelBuilder.Entity<Author>()
                .HasMany(b => b.Books)
                .WithMany(d => d.Author);
        }
    }
}
