
namespace CourseWebApi.Api.Controllers
{
    using CourseWebApi.Common.Contracts.ILogic;
    using CourseWebApi.Common.Entities;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

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
        public async Task<MessageResponse<IEnumerable<AutorDto>>> Get()
        {
            MessageResponse<IEnumerable<AutorDto>> response;

            response = await autorLogic.GetAutores();

            if (response.IsError)
            {
                response = new MessageResponse<IEnumerable<AutorDto>>("Ocurrio un error al consultar los autores.");
            }

            return response;
        }

        [HttpGet("{id}", Name = "ObtenerAutor")]
        public ActionResult<AutorDto> Get(int id)
        {
            //var autor = context.Autores.FirstOrDefault(x => x.Id == id);

            //if (autor == null)
            //{
            return NotFound();
            //}

            //return autor;
        }

        [HttpPost]
        public ActionResult Post([FromBody] AutorDto autor)
        {
            //context.Autores.Add(autor);
            //context.SaveChanges();

            //return new CreatedAtRouteResult("ObtenerAutor", new { id = autor.Id }, autor);
            return NotFound();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] AutorDto value)
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
        public ActionResult<AutorDto> Delete(int id)
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
