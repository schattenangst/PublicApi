namespace CourseWebApi.Persistence.Implement
{
    using CourseWebApi.Common.Contracts.IPersistence;
    using CourseWebApi.Common.Entities;
    using CourseWebApi.Model.Context;
    using CourseWebApi.Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class AutorPersistence : BasePersistence<Autor>, IAutorPersistence
    {
        public AutorPersistence(IRepositoryContext context) : base(context)
        {
        }

        public async Task<MessageResponse<IEnumerable<Autor>>> GetAutores()
        {
            MessageResponse<IEnumerable<Autor>> response;

            try
            {
                var autores = await this.FindAllAsync();

                response = new MessageResponse<IEnumerable<Autor>>(autores);
            }
            catch (Exception ex)
            {
                response = new MessageResponse<IEnumerable<Autor>>(ex.Message);
            }

            return response;
        }
    }
}
