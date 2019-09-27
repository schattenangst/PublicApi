namespace CourseWebApi.Persistence.Implement
{
    using CourseWebApi.Common.Contracts.IPersistence;
    using CourseWebApi.Persistence.Implement;

    public class AutorPersistence : IAutorPersistence
    {
        private readonly IAutorPersistence autorPersistence;

        public AutorPersistence(IAutorPersistence autorPersistence)
        {
            this.autorPersistence = autorPersistence;
        }


    }
}
