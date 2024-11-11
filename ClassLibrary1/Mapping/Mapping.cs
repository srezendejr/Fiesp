using FIESP.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FIESP.Data.Mapping
{
    public class Mapping
    {
        public static void Map(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>()
               .ToTable("Empresa")
               .HasKey(k => k.Codigo)
               .Property(p => p.Codigo).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            
        }
    }
}
