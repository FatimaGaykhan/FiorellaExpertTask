using System;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Models
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) :base(options){ }

		public DbSet<Slider> Sliders{ get; set; }

        public DbSet<SliderInfo> SliderInfos { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Expert> Experts { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Expert>().HasQueryFilter(m => !m.SoftDeleted);



            modelBuilder.Entity<Blog>().HasData(
            new Blog
            {
                Id = 1,
                Title = "Title1",
                Description = "Reshadin Blogu",
                Image= "blog-feature-img-1.jpg",
                CreatedDate=DateTime.Now
            },
             new Blog
             {
                 Id = 2,
                 Title = "Title2",
                 Description = "Ilqarin Blogu",
                 Image = "blog-feature-img-3.jpg",
                 CreatedDate = DateTime.Now
             }, new Blog
             {
                 Id = 3,
                 Title = "Title3",
                 Description = "Hacixanin Blogu",
                 Image = "blog-feature-img-4.jpg",
                 CreatedDate = DateTime.Now
             }

            );

            modelBuilder.Entity<Expert>().HasData(
            new Expert
            {
                Id = 1,
                FullName = "Fatima Gaykhanova",
                Position = "Florist",
                Image = "h3-team-img-1.png",
                CreatedDate = DateTime.Now
            },
              new Expert
              {
                  Id = 2,
                  FullName = "Inji Gaykhanova",
                  Position = "Manager",
                  Image = "h3-team-img-2.png",
                  CreatedDate = DateTime.Now
              },
              new Expert
              {
                  Id = 3,
                  FullName = "Fidan Gaykhanova",
                  Position = "Florist",
                  Image = "h3-team-img-3.png",
                  CreatedDate = DateTime.Now
              },
                new Expert
                {
                    Id = 4,
                    FullName = "Gunel Hasanova",
                    Position = "Florist",
                    Image = "h3-team-img-4.png",
                    CreatedDate = DateTime.Now
                }

            );
        }
    }
}

