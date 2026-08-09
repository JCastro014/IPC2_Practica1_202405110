using System;

namespace SistemaVeterinaria.Modelos
{
    public class Perro : Mascota
    {
        private string raza;

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
        public Perro(string nombre, double peso, string sexo, int edad, string dueño, string raza)
            : base(nombre, peso, sexo, edad, dueño)
        {
            this.raza = raza;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Raza: " + raza);
        }
    }
}