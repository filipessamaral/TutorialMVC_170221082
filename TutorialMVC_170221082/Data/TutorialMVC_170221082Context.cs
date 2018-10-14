using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TutorialMVC_170221082.Models
{
    public class TutorialMVC_170221082Context : DbContext
    {
        public TutorialMVC_170221082Context (DbContextOptions<TutorialMVC_170221082Context> options)
            : base(options)
        {
        }

        public DbSet<TutorialMVC_170221082.Models.Movie> Movie { get; set; }
    }
}
