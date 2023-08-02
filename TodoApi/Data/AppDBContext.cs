using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyApi.Models;

namespace MyApi.Data;

public class AppDBContext : DbContext
{
    public DbSet<TodoModel> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
     optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");


}
