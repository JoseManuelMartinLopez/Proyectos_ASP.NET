using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoMVC4_Validacion_Data_Annotation.Models
{
    public class Curso_Validar
    {
        [DisplayName("Código del curso")]
        public int codigo_c { get; set; }

        [DisplayName("Nombre del curso")]
        [Required(ErrorMessage = "Nombre del curso es requerido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "No más de 30 caracteres")]
        public string nombre_c { get; set; }

        [DisplayName("Email del Curso")]
        [Required(ErrorMessage = "Email del curso es requerido")]
        [StringLength(50, ErrorMessage = "No más de 50 caracteres")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string correo_c { get; set; }

        [DisplayName("Créditos del curso")]
        [Required(ErrorMessage = "Número de créditos de curso es requerido")]
        [Range (1,6)]
        public int  credito_c { get; set; }
    }
}