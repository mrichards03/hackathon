﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassLibrary.TeamDbContext
{
    public class Profile
    {
        [Key]
        public int id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        //public List<Blob> Image { get; set; }
        /// <summary>
        /// tags that have interests listed “hiking” “fitness” “painting” “games”
        /// </summary>
        public List<InterestTag>? InterestTags { get; set; }
        /// <summary>
        /// pronouns in user profile for closeted users who may have to use the app in a setting 
        /// with people they don’t have a reason to trust
        /// </summary>
        public string? Pronouns { get; set; }
        /// <summary>
        /// text box where you can write stuff about yourself
        /// </summary>
        public string? AboutMe { get; set; }
        /// <summary>
        /// kind of group you’re looking for
        /// </summary>
        public string? LookingFor { get; set; }
        //public List<string>? Links { get; set; }
    }
}
