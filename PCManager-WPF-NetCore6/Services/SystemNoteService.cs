using PCManager_WPF_NetCore6.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCManager_WPF_NetCore6.Services
{
    public class SystemNoteService
    {
        private static SystemNoteService instance = new SystemNoteService();
        public static SystemNoteService Instance => instance;

        public async Task<List<NoteEntity>> getNoteForManagerAsync()
        {
            var ls = mockSampleNotesForManager();
            return ls;
        }

        private List<NoteEntity> mockSampleNotesForManager()
        {
            var ls = new List<NoteEntity>();
            ls.Add(new NoteEntity
            {
                State = NoteEntity.States.Danger,
                Type = NoteEntity.Types.News,
                Content = "New type of <Bold Foreground=\"Red\">COVID</Bold> was discovered!",
            });
            ls.Add(new NoteEntity
            {
                State = NoteEntity.States.Warning,
                Type = NoteEntity.Types.SystemIssue,
                Content = "Drive C was consumed too much recently, and will be full in <Bold Foreground=\"Red\">10</Bold> days!",
            });
            return ls;
        }
    }
}
