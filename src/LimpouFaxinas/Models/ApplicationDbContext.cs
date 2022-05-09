using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LimpouFaxinas.Models
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
    {

    }
}
