

namespace CourseWebApi.Common.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class LibroDto
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public int AutorId { get; set; }

        public AutorDto Autor { get; set; }
    }
}
