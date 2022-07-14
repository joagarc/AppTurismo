using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppTurismo.Models;

namespace AppTurismo.Controllers
{
    public class RegistroController : Controller
    {
        [HttpGet]
        public ActionResult RegistroUsuario()
        {
            UsuarioRegistro usr = new UsuarioRegistro();
            return View(usr);
        }

        /// <summary>
        /// API que registra un nuevo usuario añadiendo el registro en BD
        /// </summary>
        /// <param name="usr">objeto UsuarioRegistro que contiene los campos a insertar en BD</param>
        /// <returns>Resultado de registrar el usuario</returns>
        [HttpPost]
        public ActionResult RegistroUsuario(UsuarioRegistro usr)
        {
            try
            {

                using (TURISMOEntities model = new TURISMOEntities())
                {
                    if (model.UsuarioRegistroes.Any(usu => usu.Email == usr.Email))
                    {
                        ViewBag.EmailDuplicado = "El email ya ha sido registrado";
                        return View("RegistroUsuario", usr);
                    }

                    model.UsuarioRegistroes.Add(usr);
                    model.SaveChanges();
                }
                ModelState.Clear();

                ViewBag.ResultOK = "Usuario registrado correctamente";

                return View("RegistroUsuario", new UsuarioRegistro());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }

    }
}