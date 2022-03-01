using PCManager_WPF_NetCore6.AppLayer.Adapters;
using PCManager_WPF_NetCore6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PCManager_WPF_NetCore6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NoteForManagerAdapter nfmAdapter = new NoteForManagerAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        void onWindowLoaded(object sender, RoutedEventArgs e)
        {
            nfmAdapter.LoadTo(NotesForManagerViewContainer);
        }

        void showAutomationTaskList(object sender, RoutedEventArgs e)
        {
            AutomationTaskListWindow w = new AutomationTaskListWindow();
            w.ShowDialog();
        }
    }
}
