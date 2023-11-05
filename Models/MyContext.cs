#pragma warning disable CS8618

namespace conectionMysql.Models;
using Microsoft.EntityFrameworkCore;

public class MyContext : DbContext 
{     
    public DbSet<Mascota> Mascotas { get; set; } 

    public MyContext(DbContextOptions options) : base(options) { }    
}