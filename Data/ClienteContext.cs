using ChatBot.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ChatBot.Data;

public class ClienteContext : DbContext
{
    public ClienteContext(DbContextOptions<ClienteContext> opts) : base(opts) { }

    public DbSet<ClienteModel> Cliente { get; set; }

}
