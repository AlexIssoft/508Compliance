using System;

namespace Core.Repositories.Interfaces
{
    public interface IRepositoryLocator
    {
        T GetRepository<T>() where T : IRepository;
        IRepository GetRepository(Type t);
    }
}