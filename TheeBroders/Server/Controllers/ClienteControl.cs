using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheBroders.BD.DATA;
using TheBroders.BD.DATA.Entidades;

namespace TheeBroders.Server.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly BDtc context;

        public ClienteController(BDtc context)
        {
            this.context = context;
        }
        [HttpGet]

        public async Task<ActionResult<List<Cliente>>> Get()
        {
            var resp = await context.Clientes.ToListAsync();
            return resp;
        }
        [HttpGet("{ID:int}")]
        public async Task<ActionResult<Cliente>> Get(int ID)
        {
            var cliente = await context.Clientes
                                         .Where(e => e.ID == ID)
                                         //.Include(m => m.Matriculas)
                                         .FirstOrDefaultAsync();
            if (cliente == null)
            {
                return NotFound($"No existe la especialidad de Id={ID}");
            }
            return cliente;
        }

        [HttpPost]

        public async Task<ActionResult<int>> Post(Cliente Cliente)
        {
            try
            {
                context.Clientes.Add(Cliente);
                await context.SaveChangesAsync();
                return Cliente.ID;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        [HttpPut("/ActualizarCliente")]
        public ActionResult Put([FromBody] ClienteInput cliente)
        {
            if (cliente.ID == null)
            {
                return BadRequest("ID nulo");
            }

            var cambios = context.Clientes.Where(e => e.ID == cliente.ID).FirstOrDefault();

            if (cambios == null)
            {
                return NotFound("No existe la especialidad a modificar");
            }

            //cambios.Nombre = cliente.Nombre;
            cambios.Nombre = cliente.nombre;

            try
            {

                context.Clientes.Update(cambios);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no han sido actualizados por: {e.Message}");
            }

        }
        [HttpDelete("/BorrarCliente/{id}")]
       public ActionResult Delete(int id)
        {
            var saco = context.Clientes.Where(x => x.ID == id).FirstOrDefault();

            if (saco == null)
            {
                return NotFound($"El registro {id} no fue encontrado");
            }

            try
            {
                context.Clientes.Remove(saco);
                context.SaveChanges();
                return Ok($"El registro de {saco.Nombre} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
            }

        }
    }
}