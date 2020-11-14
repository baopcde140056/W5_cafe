namespace W5_cafe.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=CoffeeModel")
        {
        }

        public virtual DbSet<combo> comboes { get; set; }
        public virtual DbSet<pro_com> pro_com { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<find> finds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<combo>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<product>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<USER>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<find>()
                .Property(e => e.open_hours)
                .IsUnicode(false);
        }
    }
}
