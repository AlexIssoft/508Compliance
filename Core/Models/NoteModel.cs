using System;

namespace Core.Models
{
    public class NoteModel
    {
        public int NoteId { get; set; }
        public int ConsumerId { get; set; }
        public int LessonId { get; set; }
        public int Grade { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
