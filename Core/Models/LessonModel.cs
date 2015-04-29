using System.Collections.Generic;

namespace Core.Models
{
    public class LessonModel
    {
        public int LessonId { get; set; }
        public string Name { get; set; }
        public List<NoteModel> Notes { get; set; } 
    }
}
