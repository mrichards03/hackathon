﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.TeamDbContext
{
    public class Activity
    {
        [Key]
        public int id { get; set; }
        public bool isPrivate { get; set; }
        /// <summary>
        /// place or can be virtual or in space
        /// </summary>
        public string? Location { get; set; }
        public DateTime Time_start { get; set; }
        public DateTime Time_end { get; set; }
        public string Age_rating { get; set; }


    }
}