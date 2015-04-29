using System;
using System.Collections.Generic;
using System.Globalization;
using Core.Common;
using Core.Repositories.Interfaces;

namespace Core.Repositories
{

    public class RepositoryLocator : IRepositoryLocator
    {
        private static readonly Dictionary<string, string> DefaultRepositories;

        private readonly Dictionary<string, string> _repositories;

        static RepositoryLocator()
        {
            DefaultRepositories = new Dictionary<string, string>
            {
                {
                    "Core.Interfaces.IConsumerRepository", "Core.Repositories.Fake.FakeConsumerRepository"
                },
                {
                    "Core.Interfaces.ILessonRepository", "Core.Repositories.Fake.FakeLessonRepository"
                },
                {
                    "Core.Interfaces.INoteRepository", "Core.Repositories.Fake.FakeNoteRepository"
                },
            };

            //initialization for real repositories
            //DefaultRepositories = new Dictionary<string, string>
            //{
            //    {
            //        "Core.Interfaces.IConsumerRepository", "Core.Repositories.ConsumerRepository"
            //    },
            //    {
            //        "Core.Interfaces.ILessonRepository", "Core.Repositories.LessonRepository"
            //    },
            //    {
            //        "Core.Interfaces.INoteRepository", "Core.Repositories.NoteRepository"
            //    },
            //};

        }

        public RepositoryLocator()
        {
            _repositories = DefaultRepositories;
        }

        public T GetRepository<T>() where T : IRepository
        {
            return (T)GetRepository(typeof(T));
        }

        public IRepository GetRepository(Type t)
        {
            var typeName = t.FullName;
            Type repositoryType;
            if (_repositories.ContainsKey(typeName))
            {
                repositoryType = ClassFactory.GetClassType(_repositories[typeName]);
            }
            else
            {
                throw new ApplicationException(String.Format(CultureInfo.CurrentCulture, "RepositoryLocator unable to find repository type '{0}'", typeName));
            }

            return (IRepository)ClassFactory.CreateObject(repositoryType);
        }
    }
}
