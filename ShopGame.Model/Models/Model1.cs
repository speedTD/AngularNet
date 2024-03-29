namespace ShopGame.Model.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Duy")
        {
        }

        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<InfoSupport> InfoSupports { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<OderDetail> OderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PostCateGory> PostCateGories { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostTag> PostTags { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCateGory> ProductCateGories { get; set; }
        public virtual DbSet<ProductTag> ProductTags { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostCateGory>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<PostCateGory>()
                .Property(e => e.alias)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.alias)
                .IsUnicode(false);

            modelBuilder.Entity<PostTag>()
                .Property(e => e.tagid)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.alias)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.promotion)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProductCateGory>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCateGory>()
                .Property(e => e.alias)
                .IsUnicode(false);

            modelBuilder.Entity<ProductTag>()
                .Property(e => e.tagid)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.type)
                .IsUnicode(false);
        }
    }
}
