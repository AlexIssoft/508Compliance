using System.Collections.Generic;
using Core.Models;
using Core.Repositories.Interfaces;

namespace Core.Interfaces
{
    public interface IConsumerRepository : IRepository
    {
        ConsumerModel GetConsumer(int consumerId);
        List<ConsumerModel> GetAllConsumers(); 
        void AddConsumer(ConsumerModel consumer);
        void UpdateConsumer(ConsumerModel consumer);
        void RemoveConsumer(int consumerId);
    }
}
