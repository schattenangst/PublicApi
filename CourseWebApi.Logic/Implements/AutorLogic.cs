
namespace CourseWebApi.Logic.Implements
{
    using CourseWebApi.Common.Contracts.ILogic;
    using CourseWebApi.Common.Contracts.IPersistence;
    using CourseWebApi.Common.Entities;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class AutorLogic : IAutorLogic
    {
        private readonly IAutorPersistence autorPersistence;

        public AutorLogic(IAutorPersistence autorPersistence)
        {
            this.autorPersistence = autorPersistence;
        }

        public async Task<AutorDto> GetAutor(int id)
        {
            return null;
        }

        public async Task<MessageResponse<IEnumerable<AutorDto>>> GetAutores()
        {
            MessageResponse<IEnumerable<AutorDto>> response;

            try
            {
                var autores = await autorPersistence.GetAutores();

                if (!autores.IsError)
                {
                    List<AutorDto> listaAutores = new List<AutorDto>();

                    foreach (var item in autores.Response)
                    {

                        listaAutores.Add(new AutorDto
                        {
                            Id = item.Id,
                            Nombre = item.Nombre
                        });
                    }

                    response = new MessageResponse<IEnumerable<AutorDto>>(listaAutores);
                }
                else
                {
                    response = new MessageResponse<IEnumerable<AutorDto>>(autores.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                response = new MessageResponse<IEnumerable<AutorDto>>(ex.Message);
            }

            return response;
        }

        public async Task<IEnumerable<AutorDto>> GetAutoresRango(int limit, int offset)
        {
            return null;
        }

    }
}
