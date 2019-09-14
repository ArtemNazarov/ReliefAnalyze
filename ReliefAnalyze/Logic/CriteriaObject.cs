using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReliefAnalyze.Logic
{
    public class CriteriaObject
    {
        private static CriteriaObject _instance;
        public Dictionary<string, Dictionary<string, int>> CriteriaDict { get; set; }

        public static CriteriaObject GetInstance()
        {
            if (_instance == null)
                _instance = new CriteriaObject();
            return _instance;
        }

        public CriteriaObject()
        {
            CriteriaDict = new Dictionary<string, Dictionary<string, int>>();
            CriteriaDict.Add("Новостройка", new Dictionary<string, int>());
            CriteriaDict.Add("Коттедж", new Dictionary<string, int>());
            CriteriaDict.Add("Охотничий дом", new Dictionary<string, int>());
            CriteriaDict.Add("Дом в горах", new Dictionary<string, int>());
            CriteriaDict.Add("Загородный дом", new Dictionary<string, int>());
            CriteriaDict.Add("Порт", new Dictionary<string, int>());
            foreach (var elem in CriteriaDict)
            {
                elem.Value.Add("Ponds", 0);
                elem.Value.Add("Rivers", 0);
                elem.Value.Add("Forests", 0);
                elem.Value.Add("Roads", 0);
                elem.Value.Add("Sand", 0);
                elem.Value.Add("Hills", 0);
                elem.Value.Add("Plain", 0);
                elem.Value.Add("Mountains", 0);
                elem.Value.Add("Swamp", 0);
                elem.Value.Add("Ice", 0);
                elem.Value.Add("Culture", 0);
            }
            CriteriaDict["Новостройка"]["Ponds"] = -2;
            CriteriaDict["Новостройка"]["Rivers"] = -1;
            CriteriaDict["Новостройка"]["Forests"] = -1;
            CriteriaDict["Новостройка"]["Sand"] = -1;
            CriteriaDict["Новостройка"]["Swamp"] = -1;
            CriteriaDict["Новостройка"]["Roads"] = 2;
            CriteriaDict["Новостройка"]["Plain"] = 1;
            CriteriaDict["Новостройка"]["Ice"] = -1;
            CriteriaDict["Новостройка"]["Mountains"] = -1;

            CriteriaDict["Коттедж"]["Ponds"] = -1;
            CriteriaDict["Коттедж"]["Rivers"] = 1;
            CriteriaDict["Коттедж"]["Sand"] = -1;
            CriteriaDict["Коттедж"]["Swamp"] = -2;
            CriteriaDict["Коттедж"]["Plain"] = 1;
            CriteriaDict["Коттедж"]["Roads"] = 1;
            CriteriaDict["Коттедж"]["Ice"] = -1;
            CriteriaDict["Коттедж"]["Culture"] = 1;
            //CriteriaDict["Коттедж"]["Mountains"] = -1;

            CriteriaDict["Загородный дом"]["Ponds"] = 1;
            CriteriaDict["Загородный дом"]["Rivers"] = 1;
            CriteriaDict["Загородный дом"]["Roads"] = 1;
            CriteriaDict["Загородный дом"]["Forests"] = 1;
            CriteriaDict["Загородный дом"]["Sand"] = -2;
            CriteriaDict["Загородный дом"]["Swamp"] = -2;
            CriteriaDict["Загородный дом"]["Plain"] = 1;
            CriteriaDict["Загородный дом"]["Culture"] = 1;
            CriteriaDict["Загородный дом"]["Ice"] = -1;
            CriteriaDict["Загородный дом"]["Mountains"] = -1;


            CriteriaDict["Порт"]["Ponds"] = 2;
            CriteriaDict["Порт"]["Rivers"] = 1;
            //CriteriaDict["Порт"]["Forests"] = 0;
            CriteriaDict["Порт"]["Sand"] = -1;
            CriteriaDict["Порт"]["Swamp"] = -1;
            CriteriaDict["Порт"]["Roads"] = 1;
            CriteriaDict["Порт"]["Plain"] = 1;
            CriteriaDict["Порт"]["Ice"] = -1;
            CriteriaDict["Порт"]["Mountains"] = -1;

            CriteriaDict["Дом в горах"]["Sand"] = -2;
            CriteriaDict["Дом в горах"]["Swamp"] = -1;
            CriteriaDict["Дом в горах"]["Roads"] = 1;
            CriteriaDict["Дом в горах"]["Plain"] = -1;
            CriteriaDict["Дом в горах"]["Hills"] = 1;
            CriteriaDict["Дом в горах"]["Ice"] = 1;
            CriteriaDict["Дом в горах"]["Mountains"] = 2;


            CriteriaDict["Охотничий дом"]["Sand"] = -1;
            CriteriaDict["Охотничий дом"]["Swamp"] = -1;
            CriteriaDict["Охотничий дом"]["Roads"] = -1;
            CriteriaDict["Охотничий дом"]["Plain"] = 1;
            CriteriaDict["Охотничий дом"]["Hills"] = 1;
            CriteriaDict["Охотничий дом"]["Culture"] = 2;
            CriteriaDict["Охотничий дом"]["Forests"] = 1;
            CriteriaDict["Охотничий дом"]["Mountains"] = 1;
        }

        public string CalculateAnalyze(Dictionary<string, bool> objectsPresence, bool point = false)
        {
            var analyze = new StringBuilder();
            foreach (var criteria in CriteriaDict)
            {
                var onlyPresence = objectsPresence.Where(obj => obj.Value).Select(obj => obj.Key).ToArray();
                var priorities = new List<int>();
                foreach (var presenceMapObject in onlyPresence)
                {
                    var objectsPriorityDict = criteria.Value;
                    priorities.Add(objectsPriorityDict[presenceMapObject]);
                }
                var countSum = 0;
                foreach (var item in priorities)
                {
                    countSum += item > 1 ? item : 1; 
                }
                double totalSum = 0;
                foreach (var item in priorities)
                {
                    double s = (double)item / countSum;
                    totalSum += (double)item / countSum;
                }
                totalSum = totalSum >= 0 ? totalSum : 0;
                double percent = totalSum * 100;
                var percentRound = Convert.ToInt32(percent);
                if (point)
                {
                    analyze.AppendLine($"Успешность постройки в данной точке {criteria.Key}: {percentRound}%");

                }
                else
                {
                    analyze.AppendLine($"Успешность постройки в данной области {criteria.Key}: {percentRound}%");
                }

            }
            return analyze.ToString();
        }
    }
}
