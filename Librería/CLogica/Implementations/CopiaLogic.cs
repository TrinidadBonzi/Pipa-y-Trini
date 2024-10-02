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
    public class CopiaLogic : ICopiaLogic
    { 
            ICopiaRepository _copiaReository;

            public CopiaLogic(ICopiaRepository copiaReository)
            {
                _copiaReository = copiaReository;
            }

            public async Task<List<Copia>> GetAll()
            {
                return await _copiaReository.GetAll();
            }

            public void AltaCopia(Copia copiaNueva)
            {
                List<string> camposErroneos = new List<string>();
                if (string.IsNullOrEmpty(copiaNueva.Libro.ISBN) || !IsValidISBN(copiaNueva.Libro.ISBN))
                    camposErroneos.Add("ISBN");

                if (string.IsNullOrEmpty(copiaNueva.Libro.Titulo) || !IsValidTitulo(copiaNueva.Libro.Titulo))
                    camposErroneos.Add("Titulo");

                if (string.IsNullOrEmpty(copiaNueva.Libro.Descripcion) || !IsValidDescripcion(copiaNueva.Libro.Descripcion))
                    camposErroneos.Add("Descripción");

                if (copiaNueva.PrecioPrestamo == 0f || !IsValidPrecioPrestamo(copiaNueva.PrecioPrestamo))
                    camposErroneos.Add("PrecioPrestamo");

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                Copia copia = new Copia();
                copia.Libro.ISBN = copiaNueva.Libro.ISBN;
                copia.Libro.Titulo = copiaNueva.Libro.Titulo;
                copia.Libro.Descripcion = copiaNueva.Libro.Descripcion;
                copia.PrecioPrestamo = copiaNueva.PrecioPrestamo;

                _copiaReository.Create(copia);
                _copiaReository.Save();
            }

            public void ActualizarCopia(string ISBN, Copia copiaActualizar)
            {
                List<string> camposErroneos = new List<string>();
                if (string.IsNullOrEmpty(copiaActualizar.Libro.ISBN) || !IsValidISBN(copiaActualizar.Libro.ISBN))
                    camposErroneos.Add("ISBN");

                if (string.IsNullOrEmpty(copiaActualizar.Libro.Titulo) || !IsValidTitulo(copiaActualizar.Libro.Titulo))
                    camposErroneos.Add("Titulo");

                if (string.IsNullOrEmpty(copiaActualizar.Libro.Descripcion) || !IsValidDescripcion(copiaActualizar.Libro.Descripcion))
                    camposErroneos.Add("Descripción");

                if (copiaActualizar.PrecioPrestamo == 0f || !IsValidPrecioPrestamo(copiaActualizar.PrecioPrestamo))
                    camposErroneos.Add("PrecioPrestamo");

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                if (string.IsNullOrEmpty(ISBN) || !IsValidISBN(ISBN))
                    throw new ArgumentException("El isbn ingresado es inválido.");

                Copia? copia = _copiaReository.FindByCondition(p => p.Libro.ISBN == ISBN).FirstOrDefault();

            if (copia == null)
                {
                    throw new ArgumentNullException("No se ha encontrado una copia con ese isbn");
                }

                copia.Libro.ISBN = copiaActualizar.Libro.ISBN;
                copia.Libro.Titulo = copiaActualizar.Libro.Titulo;
                copia.Libro.Descripcion = copiaActualizar.Libro.Descripcion;
                copia.PrecioPrestamo = copiaActualizar.PrecioPrestamo;

                _copiaReository.Update(copia);
                _copiaReository.Save();
            }

            public void EliminarCopia(string ISBN)
            {
                if (string.IsNullOrEmpty(ISBN) || !IsValidISBN(ISBN))
                    throw new ArgumentException("El isbn ingresado es inválido.");

                Copia? copia = _copiaReository.FindByCondition(p => p.Libro.ISBN == ISBN).FirstOrDefault();

                if (copia == null)
                {
                    throw new ArgumentNullException("No se ha encontrado una copia con ese isbn");
                }
                _copiaReository.Delete(copia);
                _copiaReository.Save();
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

            private bool IsValidPrecioPrestamo(float PrecioPrestamo)
            {
                return PrecioPrestamo > 0;
            }

            #endregion validaciones 
    }
}
