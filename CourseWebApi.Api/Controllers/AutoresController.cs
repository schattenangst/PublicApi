
namespace CourseWebApi.Api.Controllers
{
    using CourseWebApi.Common.Contracts.ILogic;
    using CourseWebApi.Common.Entities;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private readonly IAutorLogic autorLogic;

        public AutoresController(IAutorLogic autorLogic)
        {
            this.autorLogic = autorLogic;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Autor>> Get()
        {
            return Ok();
            //return context.Autores.ToList();
        }

        [HttpGet("{id}", Name = "ObtenerAutor")]
        public ActionResult<Autor> Get(int id)
        {
            //var autor = context.Autores.FirstOrDefault(x => x.Id == id);

            //if (autor == null)
            //{
            return NotFound();
            //}

            //return autor;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {
            //context.Autores.Add(autor);
            //context.SaveChanges();

            //return new CreatedAtRouteResult("ObtenerAutor", new { id = autor.Id }, autor);
            return NotFound();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Autor value)
        {
            //if (id != value.Id)
            //{
            return BadRequest();
            //}

            //context.Entry(value).State = EntityState.Modified;
            //context.SaveChanges();
            //return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Autor> Delete(int id)
        {
            //var autor = context.Autores.FirstOrDefault(x => x.Id == id);

            //if (autor == null)
            //{
            return NotFound();
            //}

            //context.Autores.Remove(autor);
            //context.SaveChanges();
            //return autor;
        }
    }
}
