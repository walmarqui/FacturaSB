using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class ClientesBL
    {
        public BindingList<Cliente> ListaCliente { get; set; }

        public ClientesBL()

        public BindingList<Cliente> ObtenerClientes()

        }
           public ListaCliente = new BindingList<Cliente>();


            var cliente1 = new Cliente();
            cliente1.Id = 0001;
            cliente1.RazonSocial = "Plasticos";
            cliente1.RtnCliente = "05011911150002";
            cliente1.TermPago = "30 dias";
            cliente1.TipoCliente = "Credito";
            cliente1.Nombrecont = "Juan Perez";
            cliente1.Telefono = "9999-9999";
            cliente1.Email = "Jperez@plasticos.com";
            cliente1.Puesto = "Supervisor";
            cliente1.Activo = true;

            ListaCliente.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Id = 0001;
            cliente2.RazonSocial = "Movesa";
            cliente2.RtnCliente = "05011911150002";
            cliente2.TermPago = "0";
            cliente2.TipoCliente = "Contado";
            cliente2.Nombrecont = "Pedro Paramo";
            cliente2.Telefono = "9999-9999";
            cliente2.Email = "Paramop@movesa.com";
            cliente2.Puesto = "Jefe de Matenimineto";
            cliente2.Activo = true;

            ListaCliente.Add(cliente2);
        }

    public BindingList<Cliente> ObtenerClientes()
        {
            throw new NotImplementedException();
        }
    

    
    public class Cliente
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string RtnCliente  { get; set; }
        public string TipoCliente { get; set; }
        public string TermPago { get; set; }
        public string Nombrecont { get; set; }
        public string Puesto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
    }
}
