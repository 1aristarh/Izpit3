﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Person
    {
        [Key]
        public string ID { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string FstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LName { get; set; }
        
        public List<App> FavouriteApps { get; set; }

        private Person()
        {
        }
        
        public Person(string fstname, string lname)
        {
            FstName = fstname;
            LName = lname;
            ID = Guid.NewGuid().ToString();
        }
        public Person(string id, string fstname, string lname)
        {
            FstName = fstname;
            LName = lname;
            ID = id;
        }
        public override string ToString()
        {
            return "ID: " + ID + " FstName: " + FstName + " LName: " + LName;
        }

    }
}
