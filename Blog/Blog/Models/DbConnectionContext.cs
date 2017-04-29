﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class DbConnectionContext : DbContext
    {
        public DbConnectionContext() : base("name=dbContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges
            <DbConnectionContext>());
        }
        public DbSet<ImageGallery> ImageGallery { get; set; }
    }
}