using SistemaVeterinaria.Servicios;

using SistemaVeterinaria.Modelos;
using System;

class Program
{
    static void Main(string[] args)
    {
        Veterinaria veterinaria = new Veterinaria();
        bool activo = true;
        while (activo)
        {
            // Menu
            Console.WriteLine("1. Registrar mascota");
            Console.WriteLine("2. Cambiar estado");
            Console.WriteLine("3. Calcular dosis");
            Console.WriteLine("4. Ver informacion");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opcion: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.WriteLine("Que tipo de mascota quieres registrar?");
                Console.WriteLine("1. Perro");
                Console.WriteLine("2. Ave");
                Console.WriteLine("3. Gato");
                Console.WriteLine("4. Tortuga");
                Console.Write("Elige una opcion: ");
                string tipoMascota = Console.ReadLine();

                    if (tipoMascota == "1")
                        {
                            //Perro
                        Console.WriteLine("Ingrese ek nombres del perro");
                        String nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el peso del perro");
                        double peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el sexo del perro");
                        String sexo = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad del perro");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el dueño del perro");
                        String dueño = Console.ReadLine();
                        Console.WriteLine("Ingrese la raza del perro");
                        String raza = Console.ReadLine();
                        Perro perro = new Perro(nombre, peso, sexo, edad, dueño, raza);
                        veterinaria.AgregarMascota(perro);
                        Console.WriteLine("Perro registrado con exito. Su codigo es: " + perro.Codigo);
                        }



                        else if (tipoMascota == "2")
                        {
                        // Ave
                        Console.WriteLine("Ingrese el nombre del ave");
                        String nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el peso del ave");
                        double peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el sexo del ave");
                        String sexo = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad del ave");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el dueño del ave");
                        String dueño = Console.ReadLine();
                        Console.WriteLine("Ingrese la envergadura de las alas del ave");
                        double envergadura = double.Parse(Console.ReadLine());
                        Ave ave = new Ave(nombre, peso, sexo, edad, dueño, envergadura);
                        veterinaria.AgregarMascota(ave);
                        Console.WriteLine("Ave registrada con exito. Su codigo es: " + ave.Codigo);
                        Console.WriteLine("Per registrada con exito. Su codigo es: " + ave.Codigo);
                        }




                        else if (tipoMascota == "3")
                        {
                        // Gato
                        Console.WriteLine("Ingrese el nombre del gato");
                        String nombre = Console.ReadLine();
                        Console.WriteLine("Ingres peso del Gato");
                        double peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el sexo del gato");
                        String sexo = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad del gato");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el dueño del gato");
                        string dueño = Console.ReadLine();
                        Console.WriteLine("Ingrese si el gato esta esterilizado (true/false)");
                        bool esterilizado = bool.Parse(Console.ReadLine());
                        Gato gato = new Gato(nombre, peso, sexo, edad, dueño, esterilizado);
                        veterinaria.AgregarMascota(gato);
                        Console.WriteLine("Gato registrado con exito. Su codigo es: " + gato.Codigo);
                        }







                        else if (tipoMascota == "4")
                        {
                        //datos de la toru8tuga
                        Console.WriteLine("Ingrese el nombre de la tortuga");
                        String nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el PEso");
                        double peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el sexo de la tortuga");
                        String sexo = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad de la tortuga");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el dueño de la tortuga");
                        string dueño = Console.ReadLine();
                        Console.WriteLine("Ingrese si la tortuga es acuatica (true/false)");
                        bool esAcuatica = bool.Parse(Console.ReadLine());
                        Tortuga tortuga = new Tortuga(nombre, peso, sexo, edad, dueño, esAcuatica);
                        veterinaria.AgregarMascota(tortuga);
                        Console.WriteLine("Tortuga registrada con exito. Su codigo es: " + tortuga.Codigo);
                        }
            }






            else if (opcion == "2")
            {
                // lógica de cambiar estado)
                Console.WriteLine("Ingrese el codigo de la mascota a cambiar estado: ");
                string codigo = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo estado (true = enferma, false = no lo esta):");
                bool nuevoEstado = bool.Parse(Console.ReadLine());
                veterinaria.CambiarEstadoMascota(codigo, nuevoEstado);
                Console.WriteLine("Estado de la mascota actualizado con exito.");
            }






            else if (opcion == "3")
            {
                //  calcular dosis)

                
                
                Console.WriteLine("Ingrese el codigo de la mascota para calcular dosis: ");
                string codigo = Console.ReadLine();


                Console.WriteLine("Ingrese la dosis por kg: ");
                double dosisPorKg = double.Parse(Console.ReadLine());
                double resultado = veterinaria.CalcularDosisMascota(codigo, dosisPorKg);
                
                
                if (resultado == -1)
                    {
                        Console.WriteLine("Mascota no encontrada. No se puede calcular la dosis.");

                    }else
                    {
                        


                
                Console.WriteLine("La dosis recomendada para la mascota es: " + resultado);
                    }
                

            }






            else if (opcion == "4")
            {
                //mostramos informacion de la mascota
                Console.WriteLine("Ingrese el codigo de la mascota para ver informacion: ");
                string codigo = Console.ReadLine();
                veterinaria.MostrarInformacionMascota(codigo);
                
            }






            else if (opcion == "5")
            {
                activo = false;
            }
        
    }
    }
}