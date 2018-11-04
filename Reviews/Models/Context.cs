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
                new Review() { Id = 1, Title = "Fender FA-125", ImageURL = "https://media.guitarcenter.com/is/image/MMGS7/FA-125-Dreadnought-Acoustic-Guitar-Natural/L18556000001000-00-500x500.jpg", Content = "Fender's FA-125 is a visually stunning entry-level guitar with a budget-friendly price. It has a quality laminate spruce and basswood construction with a modern Fender 3+3 headstock and stylish Viking bridge which combine to create an easy-playing instrument that sounds great. Beginners and developing players will appreciate this guitar, which includes a mahogany neck to gives the guitar lively tone and a smooth playing feel.", CategoryId = 1 },
                new Review() { Id = 2, Title = "Ibanez V70CE", ImageURL = "https://media.guitarcenter.com/is/image/MMGS7/V70CE-Acoustic-Electric-Guitar-Transparent-Blue/519468000012000-00-500x500.jpg", Content = "Acoustic electric guitar with select spruce top and mahogany back and sides. Mahogany neck. The V70CE is equipped with a soft cutaway for higher access. It is a very responsive instrument with capacity for great dynamic range both acoustically and through the output.", CategoryId = 1 },
                new Review() { Id = 3, Title = "Yamaha F335", ImageURL = "https://media.guitarcenter.com/is/image/MMGS7/F335-Acoustic-Guitar-Black/512940000001000-00-500x500.jpg", Content = "Yamaha's F335 gives you that classic dreadnought shape and sound at a price point that won't break your bank. The F335's tonewood combination includes a laminate spruce top, rosewood fingerboard and bridge, and meranti back and sides. Gold die-cast tuners provide smooth and accurate tuning while a tortoiseshell pickguard gives a bit more style. Case sold separately.", CategoryId = 1 },
                new Review() { Id = 4, Title = "Ibanez Nita Strauss JIVA10", ImageURL = "https://media.guitarcenter.com/is/image/MMGS7/Nita-Strauss-JIVA10-Signature-Electric-Guitar-Deep-Space-Blonde/L19851000001000-00-500x500.jpg", Content = "The JIVA10 is based on the Ibanez S series and features Nita’s own personal touches, such as her signature 'Pandemonium' pickups by DiMarzio in a versatile HSH configuration. Triggered by a 5-way selector switch, these pickups deliver an amazing array of tones while a well-placed master volume control lets you make rapid adjustments with ease. For the best performance in a tremolo, Nita choose the Ibanez Edge Zero II bridge. With its sleek and comfortable, low-profile design and stud lock function for superior tuning stability you'll be able to express every aspect of your musical personality. It all adds up to a pro-level playing experience for anyone with the courage to go all the way. ", CategoryId = 2 }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Acoustic-Electric" },
                new Category() { Id = 2, Name = "Electric" }
                );

            modelBuilder.Entity<Comment>().HasData(
                new Comment() { Id = 1, Text = "Funny Comment", CreatedAt = new DateTime(2018, 11, 2), ReviewId = 3 }
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
