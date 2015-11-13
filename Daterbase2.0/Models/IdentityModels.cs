using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections;
using Daterbase2._0.Enums;

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

        public DateTime? BirthDate { get; set; }
        public DateTime ProfileCreationDate = DateTime.UtcNow;

        public string DisplayUsername { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public string School { get; set; }
        public string AboutMe { get; set; }
        public string WhoIAmHereToMeet { get; set; }
        public string WhatIAmLookingForInARelationship { get; set; }
        public string ReligionOrLackThereof { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Ethnicity { get; set; }
        public string ProfileImageLocation { get; set; }
        //public string[] FavoriteThings { get; set; }
        //TODO Favorite Things

        public int? MatchLowestAge { get; set; }
        public int? MatchHighestAge { get; set; }
        public int? ZipCode { get; set; }
        public int? HomeTimeZone { get; set; }
        public int? NumberOfKids { get; set; }
        public int? HeightInInches { get; set; }


        public Gender? Gender { get; set; }
        public Gender? GenderPreference { get; set; }
        //TODO allow multiple selections for Gender Preference

        public bool? MyZipCodeOnly { get; set; }
        public bool? DesireForKids { get; set; }
        public bool? WillingnessToDateParents { get; set; }
        public bool? Smoker { get; set; }
        public bool? Drinker { get; set; }
        public bool? Stoner { get; set; }
        public bool? Single { get; set; }
        public bool? Monogamous { get; set; }

        //public virtual ICollection<Match> SavedMatches { get; set; }
        //TODO Saved Matches
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("TheDaterbase2.0", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}