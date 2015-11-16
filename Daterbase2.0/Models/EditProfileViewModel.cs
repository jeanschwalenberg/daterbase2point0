using Daterbase2._0.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Daterbase2._0.Models
{
    public class EditProfileViewModel
    {
        //TODO Member Since
        //public DateTime ProfileCreationDate = DateTime.UtcNow;

        public string DisplayUsername { get; set; }
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

        public int? NumberOfKids { get; set; }
        public int? HeightInInches { get; set; }


        public Gender? Gender { get; set; }
        public Gender? GenderPreference { get; set; }

        public bool? MyZipCodeOnly { get; set; }
        public bool? DesireForKids { get; set; }
        public bool? WillingnessToDateParents { get; set; }
        public bool? Smoker { get; set; }
        public bool? Drinker { get; set; }
        public bool? Stoner { get; set; }
        public bool? Single { get; set; }
        public bool? Monogamous { get; set; }
    }
}