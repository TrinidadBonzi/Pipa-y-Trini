using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IFormaPagoLogic
    {
        Task<List<FormaPago>> GetAll();

        void AltaFormaPago(FormaPago formapagoNueva);

        void ActualizarFormaPago(string descripcion, FormaPago formapagoActualizar);

        void EliminarFormaPago(string descripcion);
    }
}
