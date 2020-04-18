using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProAgil.API.Model;

namespace ProAgil.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Evento> Eventos {get; set;}

        public static implicit operator ControllerContext(DataContext v)
        {
            throw new NotImplementedException();
        }
    }
}