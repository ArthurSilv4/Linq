using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aaaaaaaa.Model;

namespace aaaaaaaa.Controller
{
    internal class ControllerLinq
    {
        private List<Cliente> clientes = new List<Cliente>
        {
            new Cliente{Id=1, Nome="Ale", Email="ale@ale.com"},
            new Cliente{Id=4, Nome="tle4", Email="ale4@ale.com"},
            new Cliente{Id=6, Nome="Ale", Email="ale@ale.com"},
            new Cliente{Id=2, Nome="ble2", Email="ale2@ale.com"},
            new Cliente{Id=3, Nome="vle3", Email="ale3@ale.com"},
            new Cliente{Id=5, Nome="cle5", Email="ale5@ale.com"}
        };

        public List<Cliente> FiltroCliente(string filtro)
        {
            if(string.IsNullOrEmpty(filtro) || filtro.Length > 1)
            {
                return null;
            }

            var filtrados = clientes
                .Where(c => c.Nome.StartsWith(filtro, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return filtrados;
        }

        public List<Cliente> Maiuscula()
        {
            var maiusculos = clientes
                .Select(c => new Cliente
                {
                    Id = c.Id,
                    Nome = c.Nome.ToUpper(),
                    Email = c.Email
                })
                .ToList();

            return maiusculos;
        }

        public List<Cliente> Agrupar()
        {
            var agrupados = clientes
                .OrderBy(c => c.Nome[0])
                .ToList();

            return agrupados;
        }


    }
}
