using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodResort.Data
{
    public class Context : IdentityDbContext<User>
    {
        public DbSet<Content> Content { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Review> Review { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<User>().ToTable("Users");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            builder.Entity<IdentityRole>().ToTable("Roles");


            string adminRoleId = "24c0f25f-7519-494e-b291-b6282439a949";
            string userRoleId = "6f539821-a125-4c21-886f-417e604f355b";


            builder.Entity<IdentityRole>().HasData(new IdentityRole 
            { 
                Id = adminRoleId,
                Name = "Admin",
                NormalizedName = "ADMIN"

            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = userRoleId,
                Name = "User",
                NormalizedName = "USER"

            });


            builder.Entity<Content>().HasData(new Content("About","Lorem ipsum"));
            builder.Entity<Content>().HasData(new Content("FAQ", "Lorem ipsum"));
            builder.Entity<Content>().HasData(new Content("Contact", "Lorem ipsum"));

            builder.Entity<Place>().HasData(new Place("McDonald's", "McDonald's Corporation is an American fast food company, founded in 1940 as a restaurant operated by Richard and Maurice McDonald, in San Bernardino, California, United States.", "https://www.qsrmagazine.com/sites/default/files/styles/story_page/public/story/mcdonalds-getting-even-more-serious-about-tech.jpg"));
            builder.Entity<Place>().HasData(new Place("Burger King", "Burger King is an American multinational chain of hamburger fast food restaurants. Headquartered in Miami-Dade County, Florida, the company was founded in 1953 as Insta-Burger King, a Jacksonville, Florida–based restaurant chain.", "https://www.fastighetsvarlden.se/wp-content/uploads/2019/01/fv-burger-king.jpg"));
            builder.Entity<Place>().HasData(new Place("Max", "Max Burgers Aktiebolag, earlier Max Hamburgerrestauranger AB, is a fast food corporation from Sweden.", "https://www.max.se/contentassets/1b89f49ce6974a1a86271668c1406db4/restaurantstockholm-ulvsundavagen.png"));
            builder.Entity<Place>().HasData(new Place("Subway", "Subway is an American fast food restaurant franchise that primarily sells submarine sandwiches, salads and beverages. It was founded by the 17 year old Fred DeLuca and financed by Peter Buck in 1965 as Pete's Super Submarines in Bridgeport, Connecticut", "https://insidefmcg.com.au/wp-content/uploads/2020/11/Subway7.jpg"));
            builder.Entity<Place>().HasData(new Place("Pizza hut", "Pizza Hut is an American restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. It provides pizza and other Italian-American dishes, including pasta, side dishes and desserts.", "https://1.bp.blogspot.com/-fXQqW5OlBwY/Wzm4v7YZ2gI/AAAAAAABA0w/TaEGHb5vSqEld1xm2M9ia1QQuPj7-qzbgCKgBGAs/s1600/20180701_172010.jpg"));
            builder.Entity<Place>().HasData(new Place("KFC", "KFC is an American fast food restaurant chain headquartered in Louisville, Kentucky, that specializes in fried chicken. It is the world's second-largest restaurant chain after McDonald's, with 22,621 locations globally in 150 countries as of December 2019. The chain is a subsidiary of Yum!", "https://3kytnw3txc4d32157aq3xvd1-wpengine.netdna-ssl.com/wp-content/uploads/2018/01/kfc-snabbmatsrestaurang-foto-kfc-465x312.jpg"));

        }
    }
}
