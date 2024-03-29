﻿using ColorWebsite.Data.Entities;
using System.Data.Entity;
using System.Configuration;

namespace ColorWebsite.Data
{
    public class DataContext : DbContext
    {

        public DataContext() : base(ConfigurationManager.ConnectionStrings["AZURE"].ConnectionString)
        {
        }
        public DbSet<DemoColor> Colors { get; set; }
    }
}
