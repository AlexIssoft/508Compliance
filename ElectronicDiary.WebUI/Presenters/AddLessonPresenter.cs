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

            _view.Lessons = lessonRepository.GetAllLessons();
            _view.ConsumerLessons = lessonRepository.GetLessonsByConsumerId(1);
        }
    }
}