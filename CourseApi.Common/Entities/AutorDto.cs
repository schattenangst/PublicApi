using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CourseWebApi.Common.Entities
{
    public class AutorDto
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public List<LibroDto> Libros { get; set; }
    }
}
