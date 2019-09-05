using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReliefAnalyze.Logic.ColorDetect
{
    public class MapObjectsColors
    {
        private static MapObjectsColors instance;
        public List<Color> PondsColor { get; set; }
        public List<Color> RiversColor { get; set; }
        public List<Color> ForestsColor { get; set; }
        public List<Color> RoadsColor { get; set; }
        public List<Color> SandColor { get; set; }
        public List<Color> HillsColor { get; set; }
        public List<Color> MountainsColor { get; set; }
        public List<Color> PlainColor { get; set; }

        public List<Color> SwampColor { get; set; }
        public List<Color> IceColor { get; set; }
        public List<Color> CultureColor { get; set; }



        protected MapObjectsColors()
        {
            PondsColor = new List<Color>();
            RiversColor = new List<Color>();
            ForestsColor = new List<Color>();
            RoadsColor = new List<Color>();
            SandColor = new List<Color>();
            HillsColor = new List<Color>();
            PlainColor = new List<Color>();
            MountainsColor = new List<Color>();
            SwampColor = new List<Color>();
            IceColor = new List<Color>();
            CultureColor = new List<Color>();
        }

        public static MapObjectsColors getInstance()
        {
            if (instance == null)
                instance = new MapObjectsColors();
            return instance;
        }
        /*
         * "DarkGreen"
         * "SeaGreen"
         * "MediumSeaGreen"
         * "DarkSlateGray"
         * "Gray"
         * "DimGray"
         * "CornflowerBlue"
         * "Navy"
         * "LightSteelBlue"
         * "Khaki"
         * "SandyBrown"
         * "SaddleBrown"
         * "DarkOliveGreen"
         * "OrangeRed"
         * "Khaki"
         * "Maroon"
         * "Peru"
         * "Gold"
         * "Goldenrod"
         * "Tomato"
         * "LightPink"
         * "Red"
         * "Lavender"
         * "Azure"
         * "White"
         * "MintCream"
         * "Sienna"
         * "LightCyan"
         */
        public void SetDefaultColors()
        {
            PondsColor.Clear();
            RiversColor.Clear();
            HillsColor.Clear();
            ForestsColor.Clear();
            PlainColor.Clear();
            RoadsColor.Clear();
            SandColor.Clear();
            MountainsColor.Clear();
            CultureColor.Clear();
            IceColor.Clear();
            PondsColor.AddRange(new Color[] { Color.LightSteelBlue, Color.CornflowerBlue });
            RiversColor.AddRange(new Color[] { Color.Navy });
            HillsColor.AddRange(new Color[] { Color.DimGray, Color.Gray, Color.Khaki });
            ForestsColor.Add(Color.DarkGreen);
            PlainColor.AddRange(new Color[] { Color.DarkSlateGray, Color.SeaGreen, Color.MediumSeaGreen });
            RoadsColor.AddRange(new Color[] { Color.Tomato, Color.LightPink, Color.Red });
            SandColor.AddRange(new Color[] { Color.Gold, Color.Peru});
            MountainsColor.AddRange(new Color[] { Color.DarkOliveGreen, Color.Maroon, Color.SandyBrown, Color.SaddleBrown, Color.OrangeRed, Color.Khaki, Color.Sienna, Color.LightCyan, Color.MintCream, Color.Azure });
            CultureColor.Add(Color.Goldenrod);
            IceColor.Add(Color.Lavender);
            SwampColor.Add(Color.Sienna);
        }
    }
}
