﻿using Microsoft.EntityFrameworkCore;

namespace RestWithASPNET.Model.Content
{
    public class MySQLContext: DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options): base (options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
