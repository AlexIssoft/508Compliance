using System.Collections.Generic;
using System.Linq;

namespace Core.Repositories.Fake
{
    public class BaseFakeRepository<T> where T : class
    {
        protected Dictionary<int, T> FakeData;

        protected BaseFakeRepository()
        {
            FakeData = new Dictionary<int, T>();
        }

        public T Get(int id)
        {
            return !FakeData.ContainsKey(id) ? null : FakeData[id];
        }

        public List<T> GetAll()
        {
            return FakeData.Values.ToList();
        }

        public T Add(T item)
        {
            var newKey = FakeData.Count == 0 ? 1 : FakeData.Keys.Max() + 1;
            FakeData.Add(newKey, item);
            return item;
        }

        public void Delete(int id)
        {
            FakeData.Remove(id);
        }
    }
}
