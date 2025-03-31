using Microsoft.EntityFrameworkCore;

namespace PersonWebApplicaton.Model.Context;

public class SQLServerConxtext : DbContext
{
    public SQLServerConxtext() {}
    public SQLServerConxtext(DbContextOptions<SQLServerConxtext> options) : base(options) { }

    // DbSet é similar à uma list
    public DbSet<Person> Persons { get; set; }
}
