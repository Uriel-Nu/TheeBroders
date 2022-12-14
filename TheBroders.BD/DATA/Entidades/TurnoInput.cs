using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBroders.BD.DATA.Entidades
{
    public class TurnoInput
    {

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30, ErrorMessage = "La fecha no puede tener mas de {1} caracteres")]
        public string fecha { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30, ErrorMessage = "La Hora no puede tener mas de {1} caracteres")]
        public string Hora { get; set; }

        public int ClienteID { get; set; }
    }
}
