using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBroders.BD.DATA.Entidades
    
{
    [Index(nameof(IDCliente),nameof(IDTurno),Name ="GenerarTurnosIDClienteIDTurno_uq",IsUnique =true)]
    public class GenerarTurnos : EntytyBase
    {
        [Required(ErrorMessage = " Campo obligatorio ")]
        [MaxLength(30, ErrorMessage = "El nombre no puede tener mas de {1} caracteres")]
        public string NumeroDeTurno { get; set; }

        [Required(ErrorMessage = " Campo obligatorio ")]
        public int IDCliente { get; set; }


        [Required(ErrorMessage = " Campo obligatorio ")]
        public Cliente Cliente { get; set; }

        public int IDTurno { get; set; }


    }
}
