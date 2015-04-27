using System.Collections.Generic;
using Core.Models;

namespace Core.Interfaces
{
    public interface INoteRepository
    {
        NoteModel GetNote(int noteId);
        List<NoteModel> GetAllNotes();
        void AddNote(NoteModel note);
        void UpdateNote(NoteModel note);
        void RemoveNote(int noteId);
    }
}
