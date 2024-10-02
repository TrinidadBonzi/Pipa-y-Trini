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
    public class FormaPagoLogic : IFormaPagoLogic
    {
        private IFormaPagoRepository _formapagoRepository;

        public FormaPagoLogic(IFormaPagoRepository formapagoRepository)
        {
            _formapagoRepository = formapagoRepository;
        }

        public async Task<List<FormaPago>> GetAll()
        {
            return await _formapagoRepository.GetAll();
        }

        public void AltaFormaPago(FormaPago formapagoNueva)
        {
            List<string> camposErroneos = new List<string>();

            if (string.IsNullOrEmpty(formapagoNueva.Descripcion) || !IsValidDescripcion(formapagoNueva.Descripcion))
                camposErroneos.Add("Descripción");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
            }

            FormaPago formapago = new FormaPago();
            formapago.Descripcion = formapagoNueva.Descripcion;


            _formapagoRepository.Create(formapago);
            _formapagoRepository.Save();
        }

        public void ActualizarFormaPago(string descripcion, FormaPago formapagoActualizar)
        {
            List<string> camposErroneos = new List<string>();

            if (string.IsNullOrEmpty(formapagoActualizar.Descripcion) || !IsValidDescripcion(formapagoActualizar.Descripcion))
                camposErroneos.Add("Descripción");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
            }

            if (string.IsNullOrEmpty(descripcion) || !IsValidDescripcion(descripcion))
                throw new ArgumentException("La Descripcion ingresada es inválida.");

            FormaPago? formaPago = _formapagoRepository.FindByCondition(p => p.Descripcion == descripcion).FirstOrDefault();

            if (formaPago == null)
            {
                throw new ArgumentNullException("No se ha encontrado una formaPago con ese descripcion");
            }

            formaPago.Descripcion = formapagoActualizar.Descripcion;


            _formapagoRepository.Create(formaPago);
            _formapagoRepository.Save();
        }

        public void EliminarFormaPago(string descripcion)
        {
            if (string.IsNullOrEmpty(descripcion) || !IsValidDescripcion(descripcion))
                throw new ArgumentException("El documento ingresado es inválido.");

            FormaPago? formaPago = _formapagoRepository.FindByCondition(p => p.Descripcion == descripcion).FirstOrDefault();
            
            if (formaPago == null)
            {
                throw new ArgumentNullException("No se ha encontrado una formaPago con esa descripción");
            }
            _formapagoRepository.Create(formaPago);
            _formapagoRepository.Save();
        }

        #region validaciones
        private bool ContainsInvalidCharacter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '/', '(', ')', '=', '.', ',' };
            return caracteres.Any(c => text.Contains(c));
        }
        private bool IsValidDescripcion(string Descripcion)
        {
            return Descripcion.Length < 17 && Descripcion.All(c => Char.IsNumber(c));
        }

        #endregion validaciones 
    }
}
