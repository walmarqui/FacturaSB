using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>
    {
       /* protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";

            Contexto.Usuarios.Add(usuarioAdmin);

            base.Seed(contexto);
        }*/
    }
}
