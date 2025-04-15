using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string agregarTipoDocumento(TipoDocumento tipo)
        {
            TipoDocumento.agregarTipoDocumento(tipo);
            return "OK";
        }
        [WebMethod]
        public List<TipoDocumento> dameListaTipoDocumentos()
        {
            return TipoDocumento.ObtenerListaTipoDocumentos();
        }
        [WebMethod]
        public string eliminarTipoDoc(int codigo)
        {
            TipoDocumento.eliminarTipoDoc(codigo);
            return "OK";
        }
    }
}
