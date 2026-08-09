using System;
namespace SistemaVeterinaria.Modelos
{
    public class Gato : Mascota
    {
        private bool esterilizado;
    public bool Esterilizado
        {
    get { return esterilizado; }
    set { esterilizado = value; }
        }
        public Gato(string nombre, double peso, string sexo, int edad, string dueño, bool esterilizado)
            : base(nombre, peso, sexo, edad, dueño)
        {
            this.esterilizado = esterilizado;
        }
    public override double CalcularDosis(double dosisPorKg)
        {
            double dosisNormal = base.CalcularDosis(dosisPorKg);
            return dosisNormal * 0.9;
        }
public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Esterilizado: " + (esterilizado ? "Si" : "No"));
        }
    }
}