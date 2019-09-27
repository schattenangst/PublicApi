using CourseWebApi.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWebApi.Common.Contracts.ILogic
{
    public interface IAutorLogic
    {
        Autor GetAutor(int id);

        IEnumerable<Autor> GetAutores();

        IEnumerable<Autor> GetAutoresRango(int limit, int offset);
    }
}
