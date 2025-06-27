using david.Entidades;
using Microsoft.EntityFrameworkCore;
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
            using (var _context = new applitationDBContext())
            {
                persona = _context.Persona.FirstOrDefault(MySqlX => MySqlX.Pkpersona == PkPersona);
            }
            return persona;

        }

        public void UpdatePersona(Persona Nuevo)
        {
            Persona personas = new Persona();
            {
                Nuevo.Pkpersona = Nuevo.Pkpersona;
                Nuevo.Nombre = Nuevo.Nombre;
                Nuevo.Apellido = Nuevo.Apellido;
                Nuevo.Correo = Nuevo.Correo;
                Nuevo.Edad = Nuevo.Edad;
                Nuevo.Fkciudad = Nuevo.Fkciudad;

                using (var _context = new applitationDBContext())
            {//se abrio la conexión a la BD

                _context.Persona.Update(Nuevo);
                _context.SaveChanges();
            }//se cerro la conexion
            Console.WriteLine("Se actualizo correctamente la lista");
              }
        }

        public void DeletePersona(int PkPersona)
        {
            using (var _context = new applitationDBContext())
            {//se abrio la conexión a la BD
                var persona = _context.Persona.Find(PkPersona);
                if (persona != null)
                {
                    _context.Persona.Remove(persona);
                    _context.SaveChanges();
                    Console.WriteLine("La persona ha sido eliminada exitosamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró una persona con ese ID.");
                }
            }//se cerro la conexion
        }
    }
}