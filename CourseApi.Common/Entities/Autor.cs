using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CourseWebApi.Common.Entities
{
    public class Autor
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public List<Libro> Libros { get; set; }
    }
}
