using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppTurismo.Controllers
{
    public class ReservaController : ApiController
    {
        /// <summary>
        /// Api para crear una reserva por parte del usuario
        /// </summary>
        /// <param name="ReservaObject">Objeto que se envía a través de la petición en formato JSON que contendrá los campos para crear la reserva en BD</param>
        /// <returns>Devuelve la nueva reserva creada por el usuario</returns>
        [Route("Reserva")]
        [HttpPost]
        public IHttpActionResult PostReservarActividad([FromBody] IDictionary<string, object> ReservaObject)
        {
            try
            {
                //Reserva res = ReservaObject?.ToObjectNew<Reserva>();

                /*ReservaObject:                 
                 * {
                    "Usuario": usuario_ID,
                    "Actividad": actividad_ID,
                    "FechaReserva": DateTime,
                    }
                */

                //Retorna:

                /*Reserva:                 
                 * {
                    "Id": ID_generado,
                    "Usuario": usuario_ID,
                    "Actividad": actividad_ID,
                    "FechaReserva": DateTime,
                    }
                */

                return Ok();
            }
            catch (Exception exception)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.BadRequest, exception.Message));
            }
        }

        /// <summary>
        /// Api para obtener las reservas a partir del id de un usuario
        /// </summary>
        /// <param name="userId">ID del usuario a filtrar</param>
        /// <returns>Devuelve la reserva filtrada por id</returns>
        [Route("Reserva/{userId}")]
        public IHttpActionResult GetReserva(int userId)
        {
            try
            {
                //Retorna si existe la reserva con usuario = {userId}:

                /*List<Reserva>: [                
                 * {
                    "Id": reserva_ID,
                    "Usuario": userId,
                    "Actividad": {                                    
                                    "Id": ID,
                                    "Nombre": "cadena_de_texto",
                                    "Descripcion": "cadena_de_texto",
                                    "Categoria": valor_int,
                                    "Distancia": valor_int,
                                    "Precio": valor_decimal,
                                    "Localizacion": "cadena_de_texto",
                                    "Galeria":[{
                                                    "Id": ID,
                                                    "Ruta": "cadena_de_texto_indica_ruta_img"
                                                },
                                                {
                                                    "Id": ID,
                                                    "Ruta": "cadena_de_texto_indica_ruta_img"
                                                },etc...                
                                              ],
                                    "Fecha Disponible": DateTime
                                },
                    "FechaReserva": DateTime,
                    },

                    etc...
                ],
                   
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
