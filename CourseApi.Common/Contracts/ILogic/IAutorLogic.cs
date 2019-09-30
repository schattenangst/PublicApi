using CourseWebApi.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseWebApi.Common.Contracts.ILogic
{
    public interface IAutorLogic
    {
        Task<AutorDto> GetAutor(int id);

        Task<MessageResponse<IEnumerable<AutorDto>>> GetAutores();

        Task<IEnumerable<AutorDto>> GetAutoresRango(int limit, int offset);
    }
}
