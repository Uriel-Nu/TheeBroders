using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheBroders.BD.DATA;
using TheBroders.BD.DATA.Entidades;

namespace TheeBroders.Server.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]

    public class TurnosController : ControllerBase
    {
        private readonly BDtc context;
        public TurnosController(BDtc context)
        {
            this.context = context;
        }
        [HttpGet]

        public async Task<ActionResult<List<Turno>>> Get()
        {
            var resp = await context.Turnos.ToListAsync();
            return resp;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Turno>> Get(int ID)
        {
            var Turno = await context.Turnos
                                         .Where(e => e.ID == ID)
                                         .Include(m => m.ClienteID)
                                         .FirstOrDefaultAsync();
            if (Turno == null)
            {
                return NotFound($"No existe la especialidad de Id={ID}");
            }
            return Turno;
        }

        [HttpPost]

        public async Task<ActionResult<int>> Post(Turno Turno)
        {
            try
            {
                context.Turnos.Add(Turno);
                await context.SaveChangesAsync();
                return Turno.ID;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            [HttpPost]

            async Task<ActionResult<int>> Post(Turno Turno)
            {
                try
                {
                    context.Turnos.Add(Turno);
                    await context.SaveChangesAsync();
                    return Turno.ID;
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
                



                }
            }
        }
    }

    

