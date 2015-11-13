namespace Daterbase2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Monogamous : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "DisplayUsername", c => c.String());
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Job", c => c.String());
            AddColumn("dbo.AspNetUsers", "School", c => c.String());
            AddColumn("dbo.AspNetUsers", "AboutMe", c => c.String());
            AddColumn("dbo.AspNetUsers", "WhoIAmHereToMeet", c => c.String());
            AddColumn("dbo.AspNetUsers", "WhatIAmLookingForInARelationship", c => c.String());
            AddColumn("dbo.AspNetUsers", "ReligionOrLackThereof", c => c.String());
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
            AddColumn("dbo.AspNetUsers", "State", c => c.String());
            AddColumn("dbo.AspNetUsers", "Ethnicity", c => c.String());
            AddColumn("dbo.AspNetUsers", "ProfileImageLocation", c => c.String());
            AddColumn("dbo.AspNetUsers", "MatchLowestAge", c => c.Int());
            AddColumn("dbo.AspNetUsers", "MatchHighestAge", c => c.Int());
            AddColumn("dbo.AspNetUsers", "ZipCode", c => c.Int());
            AddColumn("dbo.AspNetUsers", "HomeTimeZone", c => c.Int());
            AddColumn("dbo.AspNetUsers", "NumberOfKids", c => c.Int());
            AddColumn("dbo.AspNetUsers", "HeightInInches", c => c.Int());
            AddColumn("dbo.AspNetUsers", "Gender", c => c.Int());
            AddColumn("dbo.AspNetUsers", "GenderPreference", c => c.Int());
            AddColumn("dbo.AspNetUsers", "MyZipCodeOnly", c => c.Boolean());
            AddColumn("dbo.AspNetUsers", "DesireForKids", c => c.Boolean());
            AddColumn("dbo.AspNetUsers", "WillingnessToDateParents", c => c.Boolean());
            AddColumn("dbo.AspNetUsers", "Smoker", c => c.Boolean());
            AddColumn("dbo.AspNetUsers", "Drinker", c => c.Boolean());
            AddColumn("dbo.AspNetUsers", "Stoner", c => c.Boolean());
            AddColumn("dbo.AspNetUsers", "Single", c => c.Boolean());
            AddColumn("dbo.AspNetUsers", "Monogamous", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Monogamous");
            DropColumn("dbo.AspNetUsers", "Single");
            DropColumn("dbo.AspNetUsers", "Stoner");
            DropColumn("dbo.AspNetUsers", "Drinker");
            DropColumn("dbo.AspNetUsers", "Smoker");
            DropColumn("dbo.AspNetUsers", "WillingnessToDateParents");
            DropColumn("dbo.AspNetUsers", "DesireForKids");
            DropColumn("dbo.AspNetUsers", "MyZipCodeOnly");
            DropColumn("dbo.AspNetUsers", "GenderPreference");
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "HeightInInches");
            DropColumn("dbo.AspNetUsers", "NumberOfKids");
            DropColumn("dbo.AspNetUsers", "HomeTimeZone");
            DropColumn("dbo.AspNetUsers", "ZipCode");
            DropColumn("dbo.AspNetUsers", "MatchHighestAge");
            DropColumn("dbo.AspNetUsers", "MatchLowestAge");
            DropColumn("dbo.AspNetUsers", "ProfileImageLocation");
            DropColumn("dbo.AspNetUsers", "Ethnicity");
            DropColumn("dbo.AspNetUsers", "State");
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "ReligionOrLackThereof");
            DropColumn("dbo.AspNetUsers", "WhatIAmLookingForInARelationship");
            DropColumn("dbo.AspNetUsers", "WhoIAmHereToMeet");
            DropColumn("dbo.AspNetUsers", "AboutMe");
            DropColumn("dbo.AspNetUsers", "School");
            DropColumn("dbo.AspNetUsers", "Job");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "DisplayUsername");
            DropColumn("dbo.AspNetUsers", "BirthDate");
        }
    }
}
