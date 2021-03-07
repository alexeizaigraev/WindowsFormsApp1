using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SiteNew : SomePapa
    {
        private static List<string> natasha = MkNatasha();

        public static int MainSite()
        {
            string outFileName = dataOutPath + "OutSite.csv";
            string outFileNamePhp = dataOutPath + "page-departments.php";

            Dictionary<string, string> regimes = FileToDict(4);
            if (exitStatus) goto LabelExit;

            var accessClear = FileToText(dataInPath + "access.csv");
            if (exitStatus) goto LabelExit;

            var accessOld = FileToText(dataInPath + "access_old.csv");
            if (exitStatus) goto LabelExit;

            CopyOneFile(dataInPath + "access.csv", dataInPath + "access_old.csv");
            if (exitStatus) goto LabelExit;

            if (accessClear == accessOld) { infoSmall = "No change !" + infoSmall; }


            string[] headerClear = new string[]
            {
                "Повне найменування відокремленного підрозділу",
                "Адреса відокремленного підрозділу",
                "Дата та номер рішення про створення відокремленого підрозділу",
                "ЄДРПОУ",
                "Режим роботи",
                "Платежі приймаються в Платіжній системі",
                "Платежі виплачуються  в Платіжній системі"
            };

            string[] header = new string[]
            {
                "",
                headerClear[0],
                "",
                headerClear[1],
                "",
                headerClear[2],
                "",
                headerClear[3],
                "",
                headerClear[4],
                "",
                headerClear[5],
                "",
                headerClear[6],
                ""
            };

            string outTextPhp = "";

            List<string[]> outClear = new List<string[]>();
            outClear.Add(headerClear);

            var access = AccessToArr();
            if (exitStatus) goto LabelExit;

            foreach (string[] accessLine in access)
            {
                if (accessLine[0].IndexOf("2(Веб-сайт-ПТКС)") > -1) { continue; }

                string[] line = new string[7]
                {
                    accessLine[0],
                    accessLine[2],
                    accessLine[3],
                    accessLine[1],
                    "ТИМЧАСОВО НЕ ПРАЦЮЄ",
                    "ВПС ЕЛЕКТРУМ, ВПС FLASHPAY",
                    "ВПС ЕЛЕКТРУМ"
                };
                string dep = "";
                if (accessLine[0].IndexOf("№") > -1) { dep = accessLine[0].Split('№')[1]; }
                else { dep = accessLine[0]; }
                if ((dep.Length > 2) && (natasha.IndexOf(dep) > -1))
                {
                    try
                    {
                        string agSign = dep.Substring(0, 3);
                        line[4] = regimes[agSign];
                    }
                    catch { }
                }

                if (dep == "1")
                    line[4] = "ПН-ПТ 09:00-18:00";

                string[] lineTegs = new string[15]
                {
                    "<tr><td>",
                    line[0],
                    "</td><td>",
                    line[1],
                    "</td><td>",
                    line[2],
                    "</td><td>",
                    line[3],
                    "</td><td>",
                    line[4],
                    "</td><td>",
                    line[5],
                    "</td><td>",
                    line[6],
                    "</td></tr>"
                };
                string linePhp = String.Join("", lineTegs);
                outTextPhp += linePhp + "\n";

                outClear.Add(line);
            }
            ArrToFile(outFileName, outClear);
            if (exitStatus) goto LabelExit;

            string textPhp = outTextPhp;
            string text1 = FileToText("Config/SiteText1.txt");
            if (exitStatus) goto LabelExit;

            string text2 = FileToText("Config/SiteText2.txt");
            if (exitStatus) goto LabelExit;

            string fullTextPhp = text1 + textPhp + text2;
            TextToFile(outFileNamePhp, fullTextPhp);
            if (exitStatus) goto LabelExit;

            return 0;

        LabelExit:
            return 1;
        }

        private static List<string[]> AccessToArr()
        {
            List<string[]> a = FileToArr(dataInPath + "access.csv");
            foreach (string[] aa in a) { aa[0] = "ВІДДІЛЕННЯ №" + aa[0]; }

            return a;
        }

        public static bool InNatasha(string dep)
        {
            bool flag = false;
            foreach (string unit in natasha)
            {
                if (dep == unit)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

    }
}