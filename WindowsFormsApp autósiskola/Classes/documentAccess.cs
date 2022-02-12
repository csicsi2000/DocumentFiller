using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_autósiskola.Classes
{
    class DocumentAccess
    {
        public static string Folder = AppDomain.CurrentDomain.BaseDirectory + "DocumentFiles/";
        public static string DocBeiratkozas = Folder + "adatlapBeiratkozáshozSablon.docx";
        public static string DocJelentkezesiLap = Folder + "jelentkezesiLapSablon.docx";
        public static string DocKepzesiIgazolas = Folder + "kepzesiIgazolasSablon.docx";
        public static string OszlopRendezes = Folder + "oszlopElrendezes.csv";
        public static string DocFelnottkepzesiSzerzodes = Folder + "FelnottkepzesiSzerzodes.docx";
    }
}
