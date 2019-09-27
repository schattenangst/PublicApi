
namespace CourseWebApi.Logic.Implements
{
    using CourseWebApi.Common.Contracts.ILogic;
    using CourseWebApi.Common.Contracts.IPersistence;
    using CourseWebApi.Common.Entities;
    using System.Collections.Generic;

    public class AutorLogic : IAutorLogic
    {
        private readonly IAutorPersistence autorPersistence;

        public AutorLogic(IAutorPersistence autorPersistence)
        {
            this.autorPersistence = autorPersistence;
        }

        public IEnumerable<Autor> GetAutors()
        {
            return null;
        }

        public IEnumerable<Autor> GetAutorRango()
        {
            return null;
        }

        public Autor GetAutor()
        {
            return null;
        }
    }
}
