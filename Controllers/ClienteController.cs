using AzureApi.Data;
using AzureApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class ClienteController : ControllerBase
    {
        protected readonly ConexionDbContext _contexto;
        public ClienteController(ConexionDbContext contexto)
        {
            _contexto = contexto;
        }

        [HttpPost]
        [Route("CrearCliente")]
        public bool CrearCliente(Cliente cliente)
        {
            var c = new Cliente();
            try
            {
                c.Nombre = cliente.Nombre;
                c.Apellido = cliente.Apellido;
                c.NroDocumento = cliente.NroDocumento;
                _contexto.Cliente.Add(c);
                _contexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return false;
            }

        }
    }
}
