using Microsoft.EntityFrameworkCore;

namespace CMSECommerce.Infrastructure
{
    public class Datacontext(DbContextOptions<Datacontext>options):DbContext(options)
    {
        public DbSet<Page>Pages  { get; set; }//type prop

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            modelBuilder .Entity <Page>().HasData(
                new Page { Id = 1, Title="Home",Slug="home",Body="This is the home page" },
                new Page { Id = 2, Title="About",Slug="about",Body="This is the about page" },
                new Page { Id = 3, Title="Services",Slug="services",Body="This is the service page" },
                new Page { Id = 4, Title="Contact",Slug="contact",Body="This is the contact page" }
            ) ;
        }
    }
}
