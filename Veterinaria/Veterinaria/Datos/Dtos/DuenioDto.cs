﻿using Veterinaria.Datos.Entidades;

namespace Veterinaria.Datos.Dtos
{
    public class DuenioDto
    {
        public int idDuenio { get; set; }
        public string dniDuenio { get; set; }
        public string nombreDuenio { get; set; }
        public string apellidoDuenio { get; set; }

        public ICollection<Animal> Animales { get; set; } = new List<Animal>(); //lista vacía de animales

    }
}
