using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class TipoDocumento
    {
        public static List<TipoDocumento> listita_modelo { get; set; } = new List<TipoDocumento>();

        public int codigoDocumento { get; set; }
        public string descripcionDocumento { get; set; }

        public static void agregarTipoDocumento(TipoDocumento tipo)
        {
            listita_modelo.Add(tipo);
        }

        public static List<TipoDocumento> ObtenerListaTipoDocumentos()
        {
            return listita_modelo;
        }

        public static void eliminarTipoDoc(int codigo)
        {
            listita_modelo.RemoveAll(tipo => tipo.codigoDocumento == codigo);
        }
    }
}