using System;
using Core.Interfaces;
using Core.Repositories;
using ElectronicDiary.WebUI.ViewInterfaces;

namespace ElectronicDiary.WebUI.Presenters
{
    public class AddLessonPresenter : IBasePresenter
    {
        private readonly IAddLessonView _view;

        public AddLessonPresenter(IAddLessonView view)
        {
            if (view == null)
            {
                throw new ArgumentNullException();
            }
            _view = view;
        }

        public void Init()
        {
            var repositoryLocator = new RepositoryLocator();
            var lessonRepository = repositoryLocator.GetRepository<ILessonRepository>();
            var consumerRepository = repositoryLocator.GetRepository<IConsumerRepository>();

            _view.Lessons = lessonRepository.GetAllLessons();
            _view.ConsumerLessons = consumerRepository.GetConsumer(1).Lessons;
        }
    }
}