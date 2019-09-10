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

        public IDictionary<string, List<ColorInfo>> ColorsDict;



        protected MapObjectsColors()
        {
            ColorsDict = new Dictionary<string, List<ColorInfo>>();
            ColorsDict.Add("Ponds", new List<ColorInfo>());
            ColorsDict.Add("Rivers", new List<ColorInfo>());
            ColorsDict.Add("Forests", new List<ColorInfo>());
            ColorsDict.Add("Roads", new List<ColorInfo>());
            ColorsDict.Add("Sand", new List<ColorInfo>());
            ColorsDict.Add("Hills", new List<ColorInfo>());
            ColorsDict.Add("Plain", new List<ColorInfo>());
            ColorsDict.Add("Mountains", new List<ColorInfo>());
            ColorsDict.Add("Swamp", new List<ColorInfo>());
            ColorsDict.Add("Ice", new List<ColorInfo>());
            ColorsDict.Add("Culture", new List<ColorInfo>());


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
            foreach (var elem in ColorsDict)
            {
                ColorsDict[elem.Key].Clear();
            }

            ColorsDict["Ponds"].AddRange(new ColorInfo[] {
                new ColorInfo {NearColor="LightSteelBlue", Color= Color.LightSteelBlue },
                new ColorInfo {NearColor="CornflowerBlue", Color=Color.CornflowerBlue }
            });
            ColorsDict["Rivers"].AddRange(new ColorInfo[] {
                new ColorInfo { Color = Color.Navy, NearColor = "Navy" }
            });
            ColorsDict["Hills"].AddRange(new ColorInfo[] {
                new ColorInfo {NearColor="DimGray", Color = Color.DimGray },
                new ColorInfo {NearColor="Gray", Color = Color.Gray },
                //new ColorInfo {NearColor="Khaki", Color = Color.Khaki }
            });
            ColorsDict["Forests"].Add(new ColorInfo { NearColor = "DarkGreen", Color = Color.DarkGreen });
            ColorsDict["Plain"].AddRange(new ColorInfo[] {
                new ColorInfo {NearColor="DarkSlateGray",Color = Color.DarkSlateGray },
                new ColorInfo {NearColor="SeaGreen",Color = Color.SeaGreen },
                new ColorInfo {NearColor="MediumSeaGreen",Color = Color.MediumSeaGreen },
                new ColorInfo {NearColor="Khaki", Color = Color.Khaki },
                new ColorInfo {NearColor="Yellow", Color = Color.Yellow},
                new ColorInfo {NearColor="GreenYellow", Color = Color.GreenYellow},
                new ColorInfo {NearColor="YellowGreen", Color = Color.YellowGreen},
                new ColorInfo {NearColor="LightGreen", Color = Color.LightGreen},
                new ColorInfo {NearColor="OliveDrab", Color = Color.OliveDrab},
                new ColorInfo {NearColor = "DarkOliveGreen", Color=Color.DarkOliveGreen }
            });
            ColorsDict["Roads"].AddRange(new ColorInfo[] {
                new ColorInfo {NearColor="Tomato",Color=Color.Tomato },
                new ColorInfo {NearColor="LightPink",Color=Color.LightPink },
                new ColorInfo {NearColor="Red",Color=Color.Red}
            });
            ColorsDict["Sand"].AddRange(new ColorInfo[] {
                new ColorInfo {NearColor="Gold",Color=Color.Gold },
                new ColorInfo {NearColor="Peru",Color=Color.Peru }
            });
            ColorsDict["Mountains"].AddRange(new ColorInfo[] {
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
            ColorsDict["Culture"].Add(new ColorInfo() { NearColor = "Goldenrod", Color = Color.Goldenrod });
            ColorsDict["Ice"].Add(new ColorInfo { NearColor = "Lavender", Color = Color.Lavender });
            ColorsDict["Swamp"].Add(new ColorInfo { NearColor = "Sienna", Color = Color.Sienna });
        }
    }
}
