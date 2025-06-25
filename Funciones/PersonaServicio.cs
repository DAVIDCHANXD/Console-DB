using david.Entidades;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace david.Funciones
{
    public class PersonaServicio
    {  
      //crud orm

        public void CreatePersona(Persona persona)
        {
            Persona request = new Persona();
            {
                request.Pkpersona = persona.Pkpersona;
                request.Nombre = persona.Nombre;
                request.Apellido = persona.Apellido;
                request.Correo = persona.Correo;
                request.Edad = persona.Edad;
                request.Ciudades = persona.Ciudades;
                request.Fkciudad = persona.Fkciudad;

                using (var _context = new applitationDBContext())
                {//se habre a conexion a la base de datos
                    _context.Persona.Add(request); 
                    _context.SaveChanges();
                }// se cerro la conexion a la base de datos
            };
        }
        }

        public List<Persona> GetAllPersona()
        {
            List<Persona> personaslist = new List<Persona>();

            //se crea una lista de personas
            using (var _context = new applitationDBContext())
            {
                //se habre a conexion a la base de datos
                personaslist = _context.Persona.ToList();   
            }

            return personaslist;
        }

        public Persona ByIdPersona(int PkPersona)
        {
            Persona persona = new Persona();

            return persona;

        }

        public void UpdatePersona(Persona persona)
        {

        }

        public void DeletePersona(int PkPersona)
        {
        }
    }
}
