using System;
using System.Collections.Generic;
using System.Text;
using BEFIT.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BEFIT.Data
{
    public class BEFITContext : IdentityDbContext<User, Role, string>
    {
        public BEFITContext(DbContextOptions<BEFITContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Exercise> Exercise { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductOrder> ProductOrder { get; set; }
        public virtual DbSet<Statistic> Statistic { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<TrainingType> TrainingType { get; set; }
        //public virtual DbSet<TrainingUser> TrainingUser { get; set; }
        public virtual DbSet<Nutrition> Nutrition { get; set; }
        public virtual DbSet<DeletedUser> DeletedUser { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MessageType> MessageType { get; set; }
        public virtual DbSet<ProgramArticle> ProgramArticle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
            optionsBuilder.UseSqlServer("Server=app.fit.ba,1432;Database=BEFIT;Trusted_Connection=false;MultipleActiveResultSets=true;User ID=BEFIT;Password=Mobitel!1");

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TrainingUser>()
        //        .HasKey(c => new { c.TrainingID, c.UserID });
        //}
    }
}
