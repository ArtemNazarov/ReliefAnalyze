using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReliefAnalyze.Logic
{
    public class MapObjects
    {
        private Dictionary<string, OpenCvSharp.Point[][]> objectDictionary;


        public Dictionary<string, OpenCvSharp.Point[][]> getObjectDictionary() {
            return objectDictionary;
        }

        public MapObjects()
        {
            objectDictionary = new Dictionary<string, OpenCvSharp.Point[][]>();
        }
    }
}
