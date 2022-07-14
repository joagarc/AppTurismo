using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppTurismo.Controllers
{
    public class ActividadController : ApiController
    {

        /// <summary>
        /// Api para obtener las actividades filtradas por parametros
        /// </summary>
        /// <param name="distancia">distancia que define la actividad</param>
        /// <param name="categoria">categoria de la actividad</param>
        /// <returns>Devuelve una lista de actividades que cumplen los filtros</returns>
        [Route("Actividad/Filtered")]
        public IHttpActionResult GetActividadesFiltrado(int? distancia = null, int? categoria = null)
        {
            try
            {
                //Indicamos los valores distancia y categoria a null, ya que si no se indica ninguno, en el where de la select
                //filtrará por distancia/categoria = null para obtener todas las actividades si no se indica ninguno de los filtros de la llamada.

                //Retorna si existe:

                /*List<Actividad>: [                
                 * {
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

        /// <summary>
        /// Api para obtener el detalle de una actividad
        /// </summary>
        /// <param name="actividadId">ID de la actividad a obtener</param>
        /// <returns>Devuelve la actividad filtrada por id</returns>
        [Route("Actividad/{actividadId}")]
        public IHttpActionResult GetActividadesFiltrado(int actividadId)
        {
            try
            {
                //Retorna si existe la actividad con ID = {actividadId}:

                /*Actividad:                 
                 * {
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
