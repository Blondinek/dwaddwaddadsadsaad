using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> AllNotes { get; set; }
        public string Note;

        public MainPage()
        {
            AllNotes = new ObservableCollection<string>();
            InitializeComponent();
        }
        public void SaveNote(object sender, EventArgs e) 
        {
            AllNotes.Add(NoteText.Text);
            NoteText.Text = String.Empty;
        }
        public void DelNote(object sender, EventArgs e)
        {
            if (NoteList.SelectedItems != null)
            {
                foreach (var item in NoteList.SelectedItems)
                {
                    AllNotes.Remove((string)item);
                }
            }
            
        }
    }
}
