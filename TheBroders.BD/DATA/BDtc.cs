using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBroders.BD.DATA.Entidades;

namespace TheBroders.BD.DATA
{
    public class BDtc : DbContext

    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Recepcionista>Recepcionistas { get; set; }
        public DbSet<Barbero> Barberos { get; set; }
        public DbSet<Turno> Turnos { get; set; }

        public BDtc(DbContextOptions options) : base(options)
        {
        }
    }
}
