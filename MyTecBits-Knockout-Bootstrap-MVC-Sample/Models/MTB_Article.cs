using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyTecBits_Knockout_Bootstrap_MVC_Sample.Models
{
    public class MTB_Article
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Excerpts { get; set; }
        public string Content { get; set; }

    }
    public class MyTecBitsDBContext : DbContext
    {
        public DbSet<MTB_Article> MyTecBitsDB { get; set; }
    }
}