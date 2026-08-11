using System;
namespace SistemaVeterinaria.Modelos
{
    public class Ave : Mascota
    {
        // atributo extra
        private double envergaduraAlas;

        public double EnvergaduraAlas
        {
            get { return envergaduraAlas; }
            set { envergaduraAlas = value; }
        }
        public Ave(string nombre, double peso, string sexo, int edad, string dueño, double envergaduraAlas)
            : base(nombre, peso, sexo, edad, dueño)
        {
            this.envergaduraAlas = envergaduraAlas;
        }
        public override double CalcularDosis(double dosisPorKg)
        {
            double dosisNormal = base.CalcularDosis(dosisPorKg);
            return dosisNormal * 0.5;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Envergadura de alas: " + envergaduraAlas);
        }
    }
}