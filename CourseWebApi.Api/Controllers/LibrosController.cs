
namespace CourseWebApi.Api.Controllers
{
    using CourseWebApi.Common.Entities;
    using CourseWebApi.Model.Context;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;


    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public LibrosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<LibroDto>> Get()
        {
            //return context.Libros.Include(x => x.Autor).ToList();
            return Ok();
        }

        [HttpGet("{id}", Name = "ObtenerLibro")]
        public ActionResult<LibroDto> Get(int id)
        {
            //var libro = context.Libros.Include(x => x.Autor).FirstOrDefault(x => x.Id == id);

            //if (libro == null)
            //{
            return NotFound();
            //}

            //return libro;
        }

        [HttpPost]
        public ActionResult Post([FromBody] LibroDto libro)
        {
            //    context.Libros.Add(libro);
            //    context.SaveChanges();
            //    return new CreatedAtRouteResult("ObtenerLibro", new { id = libro.Id }, libro);
            return Ok();
        }

    }
}
