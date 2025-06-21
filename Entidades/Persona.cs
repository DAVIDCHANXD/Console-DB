using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace david.Entidades
{
    public class Persona
    {
        [Key]
        public int Pkpersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; } 
        public string Correo { get; set; } 
        public int Edad { get; set; }

        [ForeignKey("Ciudades")]
        public int Fkciudad { get; set; }
        public Ciudad Ciudades { get; set; }

    }
}
