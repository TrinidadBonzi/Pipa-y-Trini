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
    public class LibroLogic : ILibroLogic
    {
        ILibroRepository _libroRepository;

        public LibroLogic(ILibroRepository librorepository)
        {
            _libroRepository = librorepository;
        }

        public async Task<List<Libro>> GetAll()
        {
            return await _libroRepository.GetAll();
        }

        public void AltaLibro(Libro libroNuevo)
        {
            List<string> camposErroneos = new List<string>();
            if (string.IsNullOrEmpty(libroNuevo.ISBN) || !IsValidISBN(libroNuevo.ISBN))
                camposErroneos.Add("ISBN");

            if (string.IsNullOrEmpty(libroNuevo.Titulo) || !IsValidTitulo(libroNuevo.Titulo))
                camposErroneos.Add("Titulo");

            if (string.IsNullOrEmpty(libroNuevo.Descripcion) || !IsValidDescripcion(libroNuevo.Descripcion))
                camposErroneos.Add("Descripción");

            if (libroNuevo.PrecioVenta == 0f || !IsValidPrecioVenta(libroNuevo.PrecioVenta))
                camposErroneos.Add("PrecioVenta");

            if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

            Libro libro = new Libro();
            libro.ISBN = libroNuevo.ISBN;
            libro.Titulo = libroNuevo.Titulo;
            libro.Descripcion = libroNuevo.Descripcion;

            _libroRepository.Create(libro);
            _libroRepository.Save();
        }

        public void ActualizarLibro(string ISBN, Libro libroActualizar)
        {
            List<string> camposErroneos = new List<string>();
            if (string.IsNullOrEmpty(libroActualizar.ISBN) || !IsValidISBN(libroActualizar.ISBN))
                camposErroneos.Add("ISBN");

            if (string.IsNullOrEmpty(libroActualizar.Titulo) || !IsValidTitulo(libroActualizar.Titulo))
                camposErroneos.Add("Titulo");

            if (string.IsNullOrEmpty(libroActualizar.Descripcion) || !IsValidDescripcion(libroActualizar.Descripcion))
                camposErroneos.Add("Descripción");

            if (libroActualizar.PrecioVenta == 0f || !IsValidPrecioVenta(libroActualizar.PrecioVenta))
                camposErroneos.Add("PrecioVenta");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
            }

            if (string.IsNullOrEmpty(ISBN) || !IsValidISBN(ISBN))
                throw new ArgumentException("El isbn ingresado es inválido.");

            Libro? libro = _libroRepository.FindByCondition(p => p.ISBN == ISBN).FirstOrDefault();

            if (libro == null)
            {
                throw new ArgumentNullException("No se ha encontrado un libro con ese isbn");
            }

            libro.ISBN = libroActualizar.ISBN;
            libro.Titulo = libroActualizar.Titulo;
            libro.Descripcion = libroActualizar.Descripcion;

            _libroRepository.Update(libro);
            _libroRepository.Save();
        }

        public void EliminarLibro(string ISBN)
        {
            if (string.IsNullOrEmpty(ISBN) || !IsValidISBN(ISBN))
                throw new ArgumentException("El isbn ingresado es inválido.");

            Libro? libro = _libroRepository.FindByCondition(p => p.ISBN == ISBN).FirstOrDefault();

            if (libro == null)
            {
                throw new ArgumentNullException("No se ha encontrado un libro con ese isbn");
            }
            _libroRepository.Delete(libro);
            _libroRepository.Save();
        }

        #region validaciones
        private bool ContainsInvalidCharacter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '/', '(', ')', '=', '.', ',' };
            return caracteres.Any(c => text.Contains(c));
        }
        private bool IsValidISBN(string ISBN)
        {
            return ISBN.Length < 15 && !ContainsInvalidCharacter(ISBN);
        }
        private bool IsValidTitulo(string Titulo)
        {
            return Titulo.Length < 17 && Titulo.All(c => Char.IsNumber(c));
        }
        private bool IsValidDescripcion(string Descripcion)
        {
            return Descripcion.Length < 17 && Descripcion.All(c => Char.IsNumber(c));
        }

        private bool IsValidPrecioVenta(float PrecioVenta)
        {
            return PrecioVenta > 0;
        }

        #endregion validaciones 
    }
}