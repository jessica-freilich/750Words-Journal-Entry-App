using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace _750Words.Models
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> options) : base(options)
        {
        }

        public DbSet<Entry> Entries {get;set;}
        public DbSet<Emotion> Emotions {get;set;}

    }
}