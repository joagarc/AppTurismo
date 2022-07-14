

namespace AppTurismo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class UsuarioRegistro
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El email es obligatorio")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El password es obligatorio")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
