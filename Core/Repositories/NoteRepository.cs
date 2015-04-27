using System.Collections.Generic;
using Core.Interfaces;
using Core.Models;

namespace Core.Repositories
{
    public class NoteRepository: INoteRepository
    {
        public NoteModel GetNote(int noteId)
        {
            return new NoteModel();
        }

        public List<NoteModel> GetAllNotes()
        {
            return new List<NoteModel>();
        }

        public void AddNote(NoteModel note)
        {
   
        }

        public void UpdateNote(NoteModel note)
        {
            note.Grade = 10;
        }

        public void RemoveNote(int noteId)
        {
            
        }
    }
}
