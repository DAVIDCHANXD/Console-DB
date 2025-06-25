using david.Entidades;
using david.Funciones;
using System.Diagnostics;

PersonaServicio Servicios = new PersonaServicio();
int OPCION;
do { 

    Console.WriteLine("INGRESA UNA NUEVA OPCION");
    Console.WriteLine("1. LUISTA DE PERSONAS");
    Console.WriteLine("2. CREAR UNA PERSONA");
    Console.WriteLine("3. ACTUALIZAR PEROSNA");
    Console.WriteLine("4. ELIMINAR PEROSNA");
    Console.WriteLine("5. CONSULTAR ID");
    Console.WriteLine("0. SALIR DEL PROGRAMA");
    Console.WriteLine("Selecciona una opcion:");

    OPCION= int.Parse(Console.ReadLine());
        
    switch (OPCION)
    {
        case 1:
            Console.WriteLine("LISTA DE PERSONAS");

            List<Persona> listP = new List<Persona>();
            listP = Servicios.GetAllPersona();

            foreach (var item in listP)
            {
                Console.WriteLine("ID: " + item.Pkpersona);
                Console.WriteLine("Nombre: " + item.Nombre);
                Console.WriteLine("Apellido: " + item.Apellido);
                Console.WriteLine("Correo: " + item.Correo);
                Console.WriteLine("Edad: " + item.Edad);
                Console.WriteLine("Ciudad: " + item.Ciudades);
                Console.WriteLine("\n");
            }
            //FOR
            //FOREACH
            //
            break;
        case 2:
            Console.WriteLine("Ingresa los dayos que se te piden");
            Persona persona1 = new Persona();
            Console.WriteLine("Nombre: ");
            persona1.Nombre = Console.ReadLine();

            Console.WriteLine("Apellido: ");
            persona1.Apellido = Console.ReadLine();

            Console.WriteLine("Correo: ");
            persona1.Correo = Console.ReadLine();

            Console.WriteLine("Edad: ");
            persona1.Edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ciudad: ");
            persona1.Fkciudad = int.Parse(Console.ReadLine());
            Servicios.CreatePersona(persona1);
            Console.WriteLine("\n");

            break;

        case 3:
            Console.WriteLine("Haz seleccionado actualizar dato: ");
            Persona persona2 = new Persona();

            Console.WriteLine("Ingresa tu ID a modificar");
            persona2.Pkpersona = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu nombre");
            persona2.Nombre = Console.ReadLine();

            Console.WriteLine("Ïngresa tus apellidos");
            persona2.Apellido = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad");
            persona2.Edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la ciudad ");
            persona2.Fkciudad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu Correo");
            persona2.Correo = Console.ReadLine();

            Servicios.UpdatePersona(persona2);
            Console.WriteLine("\n");

            break;

        case 4:
            Console.WriteLine("Haz seleccionado eliminar una persona: ");
            Console.WriteLine("Ingresa el ID de la persona que deseas eliminar:");
            int idEliminar = int.Parse(Console.ReadLine());
            bool resultado = true;

            if (resultado)

            {
                Console.WriteLine("La persona ha sido eliminada exitosamente.");
            }
            else
            {
                Console.WriteLine("No se encontró una persona con ese ID.");
            }
            Servicios.DeletePersona(idEliminar);
            Console.WriteLine("\n");

            break;

        case 5:
            Console.WriteLine("ID EN LA BASE DE DATOS");
            List<Persona> listaP = new List<Persona>();
            listP = Servicios.GetAllPersona();

            foreach (var item in listP)
            {
                Console.WriteLine("ID: " + item.Pkpersona);
            }

            Console.WriteLine("Ingresa el ID de la persona que deseas consultar:");
            int idConsultar = int.Parse(Console.ReadLine());

            Persona personaConsultada = Servicios.ByIdPersona(idConsultar);
            if (personaConsultada != null)
            {
                Console.WriteLine("ID: " + personaConsultada.Pkpersona);
                Console.WriteLine("Nombre: " + personaConsultada.Nombre);
                Console.WriteLine("Apellido: " + personaConsultada.Apellido);
                Console.WriteLine("Correo: " + personaConsultada.Correo);
                Console.WriteLine("Edad: " + personaConsultada.Edad);
                Console.WriteLine("Ciudad: " + personaConsultada.Ciudades);
            }
            else
            {
                Console.WriteLine("No se encontró una persona con ese ID.");
            }
            Console.WriteLine("\n");

            break;

    }

    } while (OPCION != 0);