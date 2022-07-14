using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppTurismo.Controllers
{
    public class UsuarioController : ApiController
    {
        /// <summary>
        /// Api para modificar el perfil del usuario
        /// </summary>
        /// <param name="UsuarioObject">Objeto que se envía a través de la petición en formato JSON que contendrá los campos para modificar el perfil en BD</param>
        /// <returns>Devuelve el perfil modificado por el usuario</returns>
        [Route("Usuario/Perfil")]
        [HttpPut]
        public IHttpActionResult PutPerfilUsuario([FromBody] IDictionary<string, object> UsuarioObject)
        {
            try
            {
                //Usuario user = UsuarioObject?.ToObjectNew<Usuario>();

                /*UsuarioObject:                 
                 * {
                    "Usuario": usuario_ID,
                    "Email": usuario_email,
                    "Password": usuario_password_nuevo,
                    }
                */

                //Retorna:

                /*Usuario:                 
                 * {
                    "Usuario": usuario_ID,
                    "Email": usuario_email,
                    "Password": usuario_password_modificado,
                    }
                */

                return Ok();
            }
            catch (Exception exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.BadRequest, exception.Message));
            }
        }
    }
}
