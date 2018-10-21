using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Models
{
    public class Context : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(
                new Review() { Id = 1, Title = "Wolf", ImageURL = "https://i.pinimg.com/originals/dd/7c/33/dd7c33afca6b9ab815b944fbc5fbfc33.jpg", ReviewCategory = "Representation", Content = "Wolf is a symbol of guardianship, ritual, loyalty, and spirit. Wolf has the ability to make quick and firm emotional attachments, and often need to trust their own instincts. Thus they teach us to do the same, to trust our hearts and minds, and have control over our own lives.", CategoryId = 1 },
                new Review() { Id = 2, Title = "Owl", ImageURL = "https://i1.sndcdn.com/avatars-000313148980-h2uglx-t500x500.jpg", ReviewCategory = "Representation", Content = "Owls live within the darkness, which includes magic, mystery, and ancient knowledge. Related to the night is the moon, which owls are also connected to. It becomes a symbol of the feminine and fertility, with the moon's cycles of renewal. Even the mythology relates owl to this wisdom and femininity.", CategoryId = 1 },
                new Review() { Id = 3, Title = "Crow", ImageURL = "https://a0.35photo.ru/photos_col/r2/97/487882_500r.jpg", ReviewCategory = "Representation", Content = "It is usually believed that the crow is a symbol of bad luck and death, but it is not always the case. A crow may be a symbol of life magic and mysteries. It also symbolizes intelligence, flexibility and destiny.", CategoryId = 1 }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Representation" },
                new Category() { Id = 2, Name = "Animal Description" }
                );
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server = (localdb)\\mssqllocaldb; Database = ABReviews; Trusted_Connection = True; ";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
    }
}
