// See https://aka.ms/new-console-template for more information
using david.Entidades;
using david.Funciones;
using System.Diagnostics;

PersonaServicio Servicios = new PersonaServicio();

Console.WriteLine("Hello, World!\n ");

Console.WriteLine("INGRESA UNA NUEVA OPCION\n ");
Console.WriteLine("1. LISTA DE PERSONAS\n ");
Console.WriteLine("2. CREAR UNA PERSONA\n ");

int OPCION= int.Parse(Console.ReadLine());



switch (OPCION)
{
    case 1:
        Console.WriteLine("LISTA DE PERSONAS\n ");
        
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

        break;
}