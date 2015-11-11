using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace Daterbase2._0.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public DateTime MyBirthDate { get; set; }
        public DateTime MyProfileCreationDate = DateTime.UtcNow;

        public string MyDisplayUsername { get; set; }
        public string MyFirstName { get; set; }
        public string MyLastName { get; set; }
        public string MyEmailAddress { get; set; }
        public string MyJob { get; set; }
        public string MySchool { get; set; }
        public string MyAboutMe { get; set; }
        public string[] MyFavoriteThings { get; set; }
        public string[] MySavedMatches { get; set; }

        public int? MyAge { get; set; }
        public int? MatchLowestAge { get; set; }
        public int? MatchHighestAge { get; set; }
        public int? MyZipCode { get; set; }
        public int? MyHomeTimeZone { get; set; }
        public int? MyGender { get; set; }
        public int?[] MyGenderPreference { get; set; }

        public bool MyZipCodeOnly { get; set; }
        public bool MyRelationshipStatus { get; set; }
        public bool MyKidsOrLackThereof { get; set; }
        public bool MyWillingnessToDateParents { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}