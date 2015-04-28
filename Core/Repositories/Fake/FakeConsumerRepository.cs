using System;
using System.Collections.Generic;
using Core.Interfaces;
using Core.Models;

namespace Core.Repositories.Fake
{
    public class FakeConsumerRepository : BaseFakeRepository<ConsumerModel>, IConsumerRepository
    {
        public FakeConsumerRepository()
        {
            FakeData = new Dictionary<int, ConsumerModel>
            {
                {
                    1, new ConsumerModel
                    {
                        BirthDate = DateTime.Now,
                        ConsumerId = 1,
                        Email = "fdsfsdf@tt.by",
                        FirstName = "Name",
                        LastName = "Last",
                        University = "BSUIR"
                    }
                },

                {
                    2, new ConsumerModel
                    {
                        BirthDate = DateTime.Now,
                        ConsumerId = 2,
                        FirstName = "Ivan",
                        LastName = "Tor",
                        University = "BNTU"
                    }
                },
                {
                    3, new ConsumerModel
                    {
                        BirthDate = DateTime.Now,
                        ConsumerId = 3,
                        FirstName = "Michael",
                        LastName = "Tut",
                        University = "BSU"
                    }
                }
            };
        }

        public ConsumerModel GetConsumer(int consumerId)
        {
            return Get(consumerId);
        }

        public List<ConsumerModel> GetAllConsumers()
        {
            return GetAll();
        }

        public void AddConsumer(ConsumerModel consumer)
        {
            Add(consumer);
        }

        public void UpdateConsumer(ConsumerModel consumer)
        {
            FakeData[consumer.ConsumerId] = consumer;
        }

        public void RemoveConsumer(int consumerId)
        {
            Delete(consumerId);
        }
    }
}
