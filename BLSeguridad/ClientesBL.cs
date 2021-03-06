﻿using BLFacturacionSB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class ClientesBL
    {
        Contexto _contexto;
        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto();
            ListaClientes = new BindingList<Cliente>();
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            _contexto.Clientes.Load();
            ListaClientes = _contexto.Clientes.Local.ToBindingList();

            return ListaClientes;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries()) 
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }


        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
                return resultado;
        }

        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            ListaClientes.Add(nuevoCliente);

        }

        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    _contexto.SaveChanges();
                    return true;
                   }
                }
                
                    return false;
            }

        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(cliente.RazonSocial) == true)
            {
                resultado.Mensaje = "Ingrese la Razon Social";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.RtnCliente) == true)
            {
                resultado.Mensaje = "Ingrese el RTN";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.TipoCliente) == true)
            {
                resultado.Mensaje = "Ingrese si es credito o de contado";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.TermPago) == true)
            {
                resultado.Mensaje = "Ingrese los dias a pagar";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.Nombrecont) == true)
            {
                resultado.Mensaje = "Ingrese su nombre completo";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.Puesto) == true)
            {
                resultado.Mensaje = "Ingrese su cargo actual";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.Email) == true)
            {
                resultado.Mensaje = "Ingrese su correo electronico";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.Telefono) == true)
            {
                resultado.Mensaje = "Ingrese su numero de telefono";
                resultado.Exitoso = false;
            }

            return resultado;
        }
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
        public byte[] Foto { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
  }

