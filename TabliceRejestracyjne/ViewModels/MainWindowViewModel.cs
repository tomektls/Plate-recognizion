using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TabliceRejestracyjne.Models;

namespace TabliceRejestracyjne.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public List<WindowModel> ListBoxItems { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            //PropertyChangedEventHandler handler = PropertyChanged;
            //if (handler != null)
            //{
            //    handler(this, new PropertyChangedEventArgs(propertyName));
            //}
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindowViewModel()
        {
            ListBoxItems = new List<WindowModel>();
            var textbox1 = new TextBox();
            textbox1.Text = "dasdad";
            ListBoxItems.Add(new WindowModel
            { Control = textbox1, Image = null, Name = "name" }
            );
        }
    }
}
