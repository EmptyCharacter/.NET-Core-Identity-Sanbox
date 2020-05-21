using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity_SandBox.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity_SandBox.Data
{
    public class Identity_SandBoxContext : IdentityDbContext<Identity_SandBoxUser>
    {
        public Identity_SandBoxContext(DbContextOptions<Identity_SandBoxContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
