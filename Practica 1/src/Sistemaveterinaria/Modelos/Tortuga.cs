using System;

namespace SistemaVeterinaria.Modelos
{
    public class Tortuga : Mascota
    {
        // atributo extra 
private bool esAcuatica;

    public bool EsAcuatica
        {
        get { return esAcuatica; }
    set { esAcuatica = value; }
        }

    public Tortuga(string nombre, double peso, string sexo, int edad, string dueño, bool esAcuatica)
        : base(nombre, peso, sexo, edad, dueño)
        {
        this.esAcuatica = esAcuatica;
        }
    public override double CalcularDosis(double dosisPorKg)
        {
        double dosisNormal = base.CalcularDosis(dosisPorKg);
        return dosisNormal * 0.8;
        }
    public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Es acuatica: " + (esAcuatica ? "Si" : "No"));
        }
    }
}