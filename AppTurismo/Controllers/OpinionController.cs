using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppTurismo.Controllers
{
    public class OpinionController : ApiController
    {
        /// <summary>
        /// Api para crear una opinion por parte del usuario
        /// </summary>
        /// <param name="OpinionObject">Objeto que se envía a través de la petición en formato JSON que contendrá los campos para crear la opinion en BD</param>
        /// <returns>Devuelve la nueva opinion comentada por el usuario</returns>
        [Route("Opinion")]
        [HttpPost]
        public IHttpActionResult PostComentarActividad([FromBody] IDictionary<string, object> OpinionObject)
        {
            try
            {
                //Opinion op = OpinionObject?.ToObjectNew<Opinion>();

                /*OpinionObject:                 
                 * {
                    "Usuario": usuario_ID,
                    "Actividad": actividad_ID,
                    "Comentario": "cadena_de_texto",
                    }
                */

                //Retorna:

                /*Opinion:                 
                 * {
                    "Id": ID_generado,
                    "Usuario": usuario_ID,
                    "Actividad": actividad_ID,
                    "Comentario": "cadena_de_texto",
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
