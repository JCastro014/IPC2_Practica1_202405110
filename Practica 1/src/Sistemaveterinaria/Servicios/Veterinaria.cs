using System;
using System.Collections.Generic;
using SistemaVeterinaria.Modelos;
namespace SistemaVeterinaria.Servicios

{
    public class Veterinaria
    
    {
        private List<Mascota> ListaMascotas;
        public Veterinaria()
        {
            ListaMascotas = new List<Mascota>();

        }
        public void AgregarMascota(Mascota mascota)
        {
            ListaMascotas.Add(mascota);
        }
        public Mascota BuscarMascota(string codigo)
        {
            foreach (Mascota m in ListaMascotas)
            {
                if (m.Codigo == codigo)
                {
                    return m;
                }
                
                
            }
            return null;
        }
        public void CambiarEstadoMascota(string codigo, bool nuevoEstado)
        {
            Mascota mascota = BuscarMascota(codigo);
            if (mascota != null)
            {
                mascota.CambiarEstado(nuevoEstado);
            }
        }
        public double CalcularDosisMascota(string codigo, double dosisPorKg)
        {
            Mascota mascota = BuscarMascota(codigo);
            if (mascota != null)
            {
                return mascota.CalcularDosis(dosisPorKg);
            }
            return -1;
        }
        public void MostrarInformacionMascota(string codigo)
        {
            Mascota mascota = BuscarMascota(codigo);
            if (mascota != null)
            {
                mascota.MostrarInformacion();
            }
            
        }
    }
}
