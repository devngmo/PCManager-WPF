using PCManager_WPF_NetCore6.Domain.Entities;
using PCManager_WPF_NetCore6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace PCManager_WPF_NetCore6.AppLayer.Adapters
{
    public class NoteForManagerAdapter
    {
        internal void LoadTo(StackPanel container)
        {
            fetchNoteToContainer(SystemNoteService.Instance.getNoteForManagerAsync(), container);
        }

        private void fetchNoteToContainer(Task<List<NoteEntity>> task, StackPanel container)
        {
            container.Children.Clear();
            foreach (var note  in task.Result)
            {
                container.Children.Add(createNoteView(note));
            }
        }

        private UIElement createNoteView(NoteEntity note)
        {
            string xaml = $"<TextBlock xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\">{note.Content}</TextBlock>";
            return XamlReader.Parse(xaml) as TextBlock;
        }
    }
}
