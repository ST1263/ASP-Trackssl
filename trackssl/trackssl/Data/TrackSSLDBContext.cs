using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trackssl.Model;

namespace trackssl.Data
{
    public class TrackSSLDBContext: DbContext
    {
        public TrackSSLDBContext(DbContextOptions<TrackSSLDBContext> options) : base(options)
        {

        }
        public DbSet<Domain> Domain { get; set; }
    }
}
