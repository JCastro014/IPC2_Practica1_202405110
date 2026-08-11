using System;
using SistemaVeterinaria.Utilidades;
namespace SistemaVeterinaria.Modelos
{
public abstract class Mascota
    {
private string nombre;
        private double peso;
        private string sexo;
        private int edad;
        private string dueño;
        private string codigo;
        private bool enfermo;
                public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
    public int Edad
        {
        get { return edad; }
        set { edad = value; }
        }
    public string Dueño
        {
        get { return dueño; }
        set { dueño = value; }
        }
        public string Codigo
        {
            get { return codigo; }
        }

        public bool Enfermo
        {
            get { return enfermo; }
        }
        public Mascota(string nombre, double peso, string sexo, int edad, string dueño)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
            this.dueño = dueño;
            this.codigo = GeneradorCodigo.Generar();
            this.enfermo = false; // cuando la registro asumo que esta sana
        }
    public void CambiarEstado(bool nuevoEstado)
        {
            enfermo = nuevoEstado;
        }




        
    public virtual double CalcularDosis(double dosisPorKg)
        {
            return peso * dosisPorKg;
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Codigo: " + codigo);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Peso: " + peso + " kg");
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Dueño: " + dueño);
            Console.WriteLine("Estado: " + (enfermo ? "Enfermo" : "Sano"));
        }
    }
}