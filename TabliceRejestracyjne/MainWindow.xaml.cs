using Emgu.CV;
using Emgu.CV.CvEnum;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TabliceRejestracyjne.Helpers;
using TabliceRejestracyjne.Models;

namespace TabliceRejestracyjne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileForm = new OpenFileDialog();
            if (fileForm.ShowDialog() == true)
            {
                var file = new FileAndPathInfo();
                var plate = new Plate();

                //wczytanie pliku
                file.FileBytes = File.ReadAllBytes(fileForm.FileName);
                file.FilePath= System.IO.Path.GetDirectoryName(fileForm.FileName);
                file.FileName = fileForm.FileName;
              //  file.ImageArray = file.FileBytes.ToArray();

                //rozpoznanie
                var plateRecogn = new PlatesRecognizionHelper("C:\\Users\\Tomek\\TabliceRejestracyjne\\TabliceRejestracyjne\\tessdata\\");


                //plateRecogn.DetectLicensePlate(arr, null, null, null);

                // IInputArray arr = new IInputArray();

                Mat m1 = new Mat(file.FileName, LoadImageType.Unchanged);
                var j = plateRecogn.DetectLicensePlate(m1, plate.LicensePlateImagesList, plate.FilteredLicensePlateImagesList, plate.DetectedLicensePlateRegionList);
            }
        }
    }
}
