using System.Collections.Generic;
using Core.Interfaces;
using Core.Models;

namespace Core.Repositories
{
    public class ConsumerRepository : IConsumerRepository
    {
        public ConsumerModel GetConsumer(int consumerId)
        {
            return new ConsumerModel();
        }

        public List<ConsumerModel> GetAllConsumers()
        {
            return new List<ConsumerModel>();
        }

        public void AddConsumer(ConsumerModel consumer)
        {

        }

        public void UpdateConsumer(ConsumerModel consumer)
        {
            consumer.Email = "newemail@gmail.com";
        }

        public void RemoveConsumer(int consumerId)
        {

        }
    }
}
