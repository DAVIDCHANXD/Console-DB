using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace david.Entidades
{
    public class Ciudad
    {
        [Key]
    public int Pkciudad { get; set; }
        public string Nombre { get; set; }
    }
}
