using Emgu.CV;
using Emgu.CV.CvEnum;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using TabliceRejestracyjne.Helpers;
using TabliceRejestracyjne.Models;

namespace TabliceRejestracyjne
{
    public class ShellViewModel : Caliburn.Micro.Screen, IShell
    {
        private List<WindowModel> views;

        public List<WindowModel> Views
        {
            get { return views; }
            set { views = value; NotifyOfPropertyChange(); }
        }

        private string photoPath;

        public string PhotoPath
        {
            get { return photoPath; }
            set { photoPath = value; NotifyOfPropertyChange(); }
        }


        public void SelectPhoto()
        {
            OpenFileDialog fileForm = new OpenFileDialog();
            if (fileForm.ShowDialog() == true)
            {
                var file = new FileAndPathInfo();
                var plate = new Plate();

                //wczytanie pliku
                file.FileBytes = File.ReadAllBytes(fileForm.FileName);
                file.FilePath = System.IO.Path.GetDirectoryName(fileForm.FileName);
                PhotoPath = file.FileName = fileForm.FileName;
                //  file.ImageArray = file.FileBytes.ToArray();

                //rozpoznanie
                var path =Environment.CurrentDirectory;

                var plateRecogn = new PlatesRecognizionHelper(string.Format(@"{0}{1}", Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\")), @"tessdata\"));


                //plateRecogn.DetectLicensePlate(arr, null, null, null);

                // IInputArray arr = new IInputArray();

                Mat m1 = new Mat(file.FileName, LoadImageType.Unchanged);
                var j = plateRecogn.DetectLicensePlate(m1, plate.LicensePlateImagesList, plate.FilteredLicensePlateImagesList, plate.DetectedLicensePlateRegionList);
            }
        }
    }
}