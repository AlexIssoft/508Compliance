using System;

namespace Core.Models
{
    public class ConsumerModel
    {
        public int ConsumerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string University { get; set; }
    }
}
