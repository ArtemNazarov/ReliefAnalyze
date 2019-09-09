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
        public List<ColorInfo> PondsColor { get; set; }
        public List<ColorInfo> RiversColor { get; set; }
        public List<ColorInfo> ForestsColor { get; set; }
        public List<ColorInfo> RoadsColor { get; set; }
        public List<ColorInfo> SandColor { get; set; }
        public List<ColorInfo> HillsColor { get; set; }
        public List<ColorInfo> MountainsColor { get; set; }
        public List<ColorInfo> PlainColor { get; set; }
        public List<ColorInfo> SwampColor { get; set; }
        public List<ColorInfo> IceColor { get; set; }
        public List<ColorInfo> CultureColor { get; set; }



        protected MapObjectsColors()
        {
            PondsColor = new List<ColorInfo>();
            RiversColor = new List<ColorInfo>();
            ForestsColor = new List<ColorInfo>();
            RoadsColor = new List<ColorInfo>();
            SandColor = new List<ColorInfo>();
            HillsColor = new List<ColorInfo>();
            PlainColor = new List<ColorInfo>();
            MountainsColor = new List<ColorInfo>();
            SwampColor = new List<ColorInfo>();
            IceColor = new List<ColorInfo>();
            CultureColor = new List<ColorInfo>();
        }

        public static MapObjectsColors GetInstance()
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
            PondsColor.AddRange(new ColorInfo[] {
                new ColorInfo {NearColor="LightSteelBlue", Color= Color.LightSteelBlue },
                new ColorInfo {NearColor="CornflowerBlue", Color=Color.CornflowerBlue }
            });
            RiversColor.AddRange(new ColorInfo[] {
                new ColorInfo { Color = Color.Navy, NearColor = "Navy" }
            });
            HillsColor.AddRange(new ColorInfo[] {
                new ColorInfo {NearColor="DimGray", Color = Color.DimGray },
                new ColorInfo {NearColor="Gray", Color = Color.Gray },
                //new ColorInfo {NearColor="Khaki", Color = Color.Khaki }
            });
            ForestsColor.Add(new ColorInfo {NearColor="DarkGreen" ,Color = Color.DarkGreen });
            PlainColor.AddRange(new ColorInfo[] {
                new ColorInfo {NearColor="DarkSlateGray",Color = Color.DarkSlateGray },
                new ColorInfo {NearColor="SeaGreen",Color = Color.SeaGreen },
                new ColorInfo {NearColor="MediumSeaGreen",Color = Color.MediumSeaGreen },
                new ColorInfo {NearColor="Khaki", Color = Color.Khaki }

            });
            RoadsColor.AddRange(new ColorInfo[] {
                new ColorInfo {NearColor="Tomato",Color=Color.Tomato },
                new ColorInfo {NearColor="LightPink",Color=Color.LightPink },
                new ColorInfo {NearColor="Red",Color=Color.Red}
            });
            SandColor.AddRange(new ColorInfo[] {
                new ColorInfo {NearColor="Gold",Color=Color.Gold },
                new ColorInfo {NearColor="Peru",Color=Color.Peru }
            });
            MountainsColor.AddRange(new ColorInfo[] {
                new ColorInfo {NearColor = "DarkOliveGreen", Color=Color.DarkOliveGreen },
                new ColorInfo {NearColor = "Maroon", Color=Color.Maroon},
                new ColorInfo {NearColor = "SandyBrown", Color=Color.SandyBrown},
                new ColorInfo {NearColor = "SaddleBrown", Color=Color.SaddleBrown},
                new ColorInfo {NearColor = "OrangeRed", Color=Color.OrangeRed},
                new ColorInfo {NearColor = "Khaki", Color=Color.Khaki},
                new ColorInfo {NearColor = "Sienna", Color=Color.Sienna},
                new ColorInfo {NearColor = "LightCyan", Color=Color.LightCyan},
                new ColorInfo {NearColor = "MintCream", Color=Color.MintCream},
                new ColorInfo {NearColor = "Azure", Color=Color.Azure }
            });
            CultureColor.Add(new ColorInfo() {NearColor= "Goldenrod", Color = Color.Goldenrod });
            IceColor.Add(new ColorInfo {NearColor= "Lavender", Color = Color.Lavender });
            SwampColor.Add(new ColorInfo {NearColor= "Sienna", Color = Color.Sienna });
        }
    }
}
