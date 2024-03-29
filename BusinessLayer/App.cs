﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class App
    {
        [Key]
        public string ID { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal ReleasePrice { get; set; }
        
        [Required]
        public string ReleaseDate { get; set; }

        private App()
        {
        }

        public App(string name, decimal releaseprice, string releasedate)
        {
            Name = name;
            ReleasePrice = releaseprice;
            ReleaseDate = releasedate;
            ID = Guid.NewGuid().ToString();
        }
        public App(string id, string name, decimal releaseprice, string releasedate)
        {
            Name = name;
            ReleasePrice = releaseprice;
            ReleaseDate = releasedate;
            ID = id;
        }

        public override string ToString()
        {
            return "ID: " + ID + " Name: " + Name + " ReleasePrice: " + ReleasePrice + " ReleaseDate: " + ReleaseDate;
        }


    }
}
