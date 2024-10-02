using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class GeneroLogic : IGeneroLogic
    {
        private IGeneroRepository _generoRepository;

        public GeneroLogic(IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;
        }

        public async Task<List<Genero>> GetAll()
        {
            return await _generoRepository.GetAll();
        }

        public void AltaGenero(Genero generoNuevo)
        {
            List<string> camposErroneos = new List<string>();
            if (string.IsNullOrEmpty(generoNuevo.Nombre) || !IsValidName(generoNuevo.Nombre))
                camposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(generoNuevo.Descripcion) || !IsValidDescripcion(generoNuevo.Descripcion))
                camposErroneos.Add("Descripción");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
            }

            Genero genero = new Genero();
            genero.Nombre = generoNuevo.Nombre;
            genero.Descripcion = generoNuevo.Descripcion;


            _generoRepository.Create(genero);
            _generoRepository.Save();
        }

        public void ActualizarGenero(string nombre, Genero generoActualizar)
        {
            List<string> camposErroneos = new List<string>();
            if (string.IsNullOrEmpty(generoActualizar.Nombre) || !IsValidName(generoActualizar.Nombre))
                camposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(generoActualizar.Descripcion) || !IsValidDescripcion(generoActualizar.Descripcion))
                camposErroneos.Add("Descripción");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
            }

            if (string.IsNullOrEmpty(nombre) || !IsValidName(nombre))
                throw new ArgumentException("El nombre ingresado es inválido.");

            Genero? genero = _generoRepository.FindByCondition(p => p.Nombre == nombre).FirstOrDefault();

            if (genero == null)
            {
                throw new ArgumentNullException("No se ha encontrado un genero con ese documento");
            }

            genero.Nombre = generoActualizar.Nombre;
            genero.Descripcion = generoActualizar.Descripcion;


            _generoRepository.Create(genero);
            _generoRepository.Save();
        }

        public void EliminarGenero(string nombre)
        {
            if (string.IsNullOrEmpty(nombre) || !IsValidName(nombre))
                throw new ArgumentException("El documento ingresado es inválido.");

            Genero? genero = _generoRepository.FindByCondition(p => p.Nombre == nombre).FirstOrDefault();

            if (genero == null)
            {
                throw new ArgumentNullException("No se ha encontrado un genero con ese documento");
            }
            _generoRepository.Create(genero);
            _generoRepository.Save();
        }

        #region validaciones
        private bool ContainsInvalidCharacter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '/', '(', ')', '=', '.', ',' };
            return caracteres.Any(c => text.Contains(c));
        }
        private bool IsValidName(string nombre)
        {
            return nombre.Length < 15 && !ContainsInvalidCharacter(nombre);
        }
        private bool IsValidDescripcion(string Descripcion)
        {
            return Descripcion.Length < 17 && Descripcion.All(c => Char.IsNumber(c));
        }

        #endregion validaciones 

    }
}
