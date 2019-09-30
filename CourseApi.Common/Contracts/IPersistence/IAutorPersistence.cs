
namespace CourseWebApi.Common.Contracts.IPersistence
{
    using CourseWebApi.Common.Entities;
    using CourseWebApi.Model.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAutorPersistence : IBasePersistence<Autor>
    {
        Task<MessageResponse<IEnumerable<Autor>>> GetAutores();
    }
}
