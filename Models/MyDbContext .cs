﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace Codefirst.Models
{
    public class MyDbContext
    {
        public MyDbContext()
            : base("name=conn")
        {

        }
        public DbSet<User> Users { get; set; }


    }
}