using System;
using System.Collections.Generic;
using Core.Interfaces;
using Core.Models;

namespace Core.Repositories.Fake
{
    public class FakeNoteRepository: BaseFakeRepository<NoteModel>, INoteRepository
    {
        public FakeNoteRepository()
        {
            FakeData = new Dictionary<int, NoteModel>
            {
                {
                    1, new NoteModel
                    {
                        NoteId = 1,
                        CreationDate = DateTime.Today,
                        Grade = 1
                    }
                },
                {
                    2, new NoteModel
                    {
                        NoteId = 2,
                        CreationDate = DateTime.Today,
                        Grade = 2
                    }
                },
                {
                    3, new NoteModel
                    {
                        NoteId = 3,
                        CreationDate = DateTime.Today,
                        Grade = 3
                    }
                }
            };
        }

        public NoteModel GetNote(int noteId)
        {
           return Get(noteId);
        }

        public List<NoteModel> GetAllNotes()
        {
            return GetAll();
        }

        public void AddNote(NoteModel note)
        {
            Add(note);
        }

        public void UpdateNote(NoteModel note)
        {
            FakeData[note.NoteId] = note;
        }

        public void RemoveNote(int noteId)
        {
            Delete(noteId);
        }
    }
}
