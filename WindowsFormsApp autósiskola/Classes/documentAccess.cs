using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_autósiskola.Classes
{
    class documentAccess
    {
        public static string folder = AppDomain.CurrentDomain.BaseDirectory + "DocumentFiles/";
        public static string DocBeiratkozas = folder + "adatlapBeiratkozáshozSablon.docx";
        public static string DocJelentkezesiLap = folder + "jelentkezesiLapSablon.docx";
        public static string DocKepzesiIgazolas = folder + "kepzesiIgazolasSablon.docx";
        public static string oszlopRendezes = folder + "oszlopElrendezes.csv";
        public static string DocFelnottkepzesiSzerzodes = folder + "FelnottkepzesiSzerzodes.docx";
    }
}
