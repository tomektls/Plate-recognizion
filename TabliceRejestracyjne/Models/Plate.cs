using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabliceRejestracyjne.Models
{
    class Plate
    {
        #region Values
        private List<IInputOutputArray> licensePlateImagesList;
        private List<IInputOutputArray> filteredLicensePlateImagesList;
        private List<RotatedRect> detectedLicensePlateRegionList;

        #endregion

        public List<IInputOutputArray> LicensePlateImagesList
        {
            get
            {
                if (licensePlateImagesList == null)
                {
                    licensePlateImagesList = new List<IInputOutputArray>();
                }
                return licensePlateImagesList;
            }
            set
            {
                licensePlateImagesList = value;
            }
        }

        public List<IInputOutputArray> FilteredLicensePlateImagesList
        {
            get
            {
                if (filteredLicensePlateImagesList == null)
                {
                    filteredLicensePlateImagesList = new List<IInputOutputArray>();
                }
                return filteredLicensePlateImagesList;
            }
            set
            {
                filteredLicensePlateImagesList = value;
            }
        }


        public List<RotatedRect> DetectedLicensePlateRegionList
        {
            get
            {
                if (detectedLicensePlateRegionList == null)
                {
                    detectedLicensePlateRegionList = new List<RotatedRect>();
                }
                return detectedLicensePlateRegionList;
            }
            set
            {
                detectedLicensePlateRegionList = value;
            }
        }
    }
}
