using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
   public class Contexto: DbContext        
    {
        public Contexto(): base("Clientes")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuider)
        {
            modelBuider.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }
        public DbSet<Cliente> Clientes { get; set; }
       // public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Factura> Facturas { get; set; }
       // public object Usuarios { get; internal set; }
    }
}
