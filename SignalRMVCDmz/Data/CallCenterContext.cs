using SignalRMVCDmz.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRMVCDmz.Data
{
  public class CallCenterContext : DbContext
  {
    private readonly IConfiguration _config;

    public CallCenterContext(IConfiguration config)
    {
      _config = config;
    }

    public DbSet<Calls> Calls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder bldr)
    {
      bldr.UseSqlServer(_config.GetConnectionString("CallCenterConnectionString"));
    }
  }
}
