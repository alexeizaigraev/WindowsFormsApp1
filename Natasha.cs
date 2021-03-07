using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WindowsFormsApp1
{
    class Natasha : SomePapa
    {
        public static int MainNatasha()
        {
            outLine = "";
            outText = "";

            string fOutName = "OutNatasha.csv";
            var lines = MkNatasha();
            if (exitStatus) goto LabelExit;

            var names = MkComonHash(1);
            if (exitStatus) goto LabelExit;

            Dictionary<string, string> data = new Dictionary<string, string>();
            foreach (string item in lines)
            {
                try
                {
                    if ((item != "") && (item.Length > 6))
                    {
                        data[item] = "";
                    }
                }
                catch { }


            }


            SortedDictionary<string, int> myDict = new SortedDictionary<string, int>();
            foreach (string item in data.Keys)
            {
                string key = item.Substring(0, 3);
                if (myDict.ContainsKey(key))
                    myDict[key] += 1;
                else
                    myDict[key] = 1;
            }

            int sum = 0;
            foreach (var key in myDict.Keys)
            {
                sum += myDict[key];
                string name = "_";
                if (names.ContainsKey(key)) { name = names[key]; }

                outText += key + ";" + name + ";" + String.Format("{0}", myDict[key]) + "\n";
            }
            outText += "_____\n";
            outText += "sum= " + String.Format("{0}", sum) + "\n";

            //pGreen(outText);

            //TextToFile(dataOutPath + fOutName, outText);
            //OpenNote(dataOutPath + fOutName);
            
            string oFname = dataPath + "Количество отделений/Отделения-" + DateNowLine() + ".csv";
            //pDarkYellow("\n\t Отчёт?\t\t Да [Enter] ->");


            //TextToFile(dataOutPath + fOutName, outText);
            TextToFile(oFname, outText);
            if (exitStatus) goto LabelExit;

            OpenNote(dataOutPath + fOutName);
            if (exitStatus) goto LabelExit;


            return 0;

        LabelExit:
            return 1;
        }

    }
}
