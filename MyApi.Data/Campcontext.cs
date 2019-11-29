using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApi.Data
{
    public class Campcontext :DbContext
    {
        public Campcontext(DbContextOptions<Campcontext> contextOptions) :base(contextOptions)
        {
            //contextOptions.s
        }


        //public Campcontext(DbContextOptions<Campcontext> contextOptions, IConfiguration configuration) : base(contextOptions)
        //{
        //    //contextOptions.s
        //}

        public DbSet<Camp> Camps { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Talk> Talks { get; set; }


    }
    
    //public class GenericContext : DbContext
    //{
    //    public GenericContext() : base()
    //    {
            
    //    }

    //    public override int SaveChanges()
    //    {
    //        try
    //        {
    //            return base.SaveChanges();
    //        }
    //        catch(Exception e) { throw; }
    //    }
    //}
}
