using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReliefAnalyze.Logic
{
    public class ImageFile
    {
        private static ImageFile _instance;

        public Image Image { get; set; }

        public FileInfo FileInfo { get; set; }

        public static ImageFile GetInstance()
        {
            if (_instance == null)
                _instance = new ImageFile();
            return _instance;
        }

        public string FileNameShortWithoutExtension()
        {
            if (FileInfo != null)
            {
                var shortName = FileInfo.Name;
                var shortWoExtension = shortName.Substring(0, shortName.IndexOf('.'));
                return shortWoExtension;
            }
            return "Error. FileInfo is null";
        }

        public string FileNameWithoutExtension()
        {
            if (FileInfo != null)
            {
                var shortName = FileInfo.Name;
                var shortWoExtension = shortName.Substring(0, shortName.IndexOf('.'));
                var fullWoExtension = FileInfo.DirectoryName + '\\' + shortWoExtension;
                return fullWoExtension;
            }
            return "Error. FileInfo is null";
        }

    }
}
