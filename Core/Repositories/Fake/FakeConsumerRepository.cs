﻿using System;
using System.Collections.Generic;
using Core.Interfaces;
using Core.Models;

namespace Core.Repositories.Fake
{
    public class FakeConsumerRepository : BaseFakeRepository<ConsumerModel>, IConsumerRepository
    {
        public FakeConsumerRepository()
        {
            FakeData = new Dictionary<long, ConsumerModel>
            {
                {
                    1, new ConsumerModel
                    {
                        BirthDate = DateTime.Now,
                        ConsumerId = 1,
                        Email = "fdsfsdf@tt.by",
                        FirstName = "Name",
                        LastName = "Last",
                        University = "BSUIR",
                        Lessons = new List<LessonModel>
                        {
                           new LessonModel
                                {
                                    LessonId = 1,
                                    Name = "History"
                                }
                        }
                    }
                },

                {
                    2, new ConsumerModel
                    {
                        BirthDate = DateTime.Now,
                        ConsumerId = 2,
                        FirstName = "Ivan",
                        LastName = "Tor",
                        University = "BNTU",
                         Lessons = new List<LessonModel>
                        {
                           new LessonModel
                                {
                                    LessonId = 3,
                                    Name = "Mathematics"
                                }
                        }
                    }
                },
                {
                    3, new ConsumerModel
                    {
                        BirthDate = DateTime.Now,
                        ConsumerId = 3,
                        FirstName = "Michael",
                        LastName = "Tut",
                        University = "BSU",
                       Lessons = new List<LessonModel>
                        {
                           new LessonModel
                                {
                                    LessonId = 2,
                                    Name = "Biology"
                                }
                        }
                       
                    }
                }
            };
        }

        public ConsumerModel GetConsumer(int consumerId)
        {
            return Get(consumerId);
        }

        public ConsumerModel GetConsumerByUserId(Guid userId)
        {
            return new ConsumerModel
            {
                BirthDate = DateTime.Now,
                ConsumerId = 1,
                Email = "fdsfsdf@tt.by",
                FirstName = "Name",
                LastName = "Last",
                University = "BSUIR"
            };
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
