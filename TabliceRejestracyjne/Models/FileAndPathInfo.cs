using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabliceRejestracyjne.Models
{
    class FileAndPathInfo
    {
        public byte[] FileBytes { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }

        public IInputArray ImageArray { get; set; }
    }
}
