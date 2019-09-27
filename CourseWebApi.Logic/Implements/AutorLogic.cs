
namespace CourseWebApi.Logic.Implements
{
    using CourseWebApi.Common.Contracts.ILogic;
    using CourseWebApi.Common.Entities;
    using System.Collections.Generic;

    public class AutorLogic : IAutorLogic
    {
        //private readonly IAutorPersistence autorPersistence;

        public AutorLogic() //IAutorPersistence autorPersistence)
        {
            //  this.autorPersistence = autorPersistence;
        }
        public Autor GetAutor(int id)
        {
            return null;
        }

        public IEnumerable<Autor> GetAutores()
        {
            //var autores = autorPersistence.

            return null;
        }

        public IEnumerable<Autor> GetAutoresRango(int limit, int offset)
        {
            return null;
        }

    }
}
