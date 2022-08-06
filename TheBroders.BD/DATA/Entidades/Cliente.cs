using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBroders.BD.DATA.Entidades
{
    public class Cliente : EntytyBase
    {
        [Required(ErrorMessage ="Campo obligatorio")]
        [MaxLength(30, ErrorMessage = "El nombre no puede tener mas de {1} caracteres")]
        public string Nombre { get; set; }

    }
}
