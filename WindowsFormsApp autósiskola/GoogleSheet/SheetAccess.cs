using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;

namespace WindowsFormsApp_autósiskola.GoogleSheet
{
    public class SheetAccess
    {
        public static readonly string UserName = "documentfillersheet@documentfiller-322119.iam.gserviceaccount.com";
        public string UniqueID = "111047218257159267512";
        public string[] Scopes = { SheetsService.Scope.Spreadsheets };
        public string ApplicationName = "DocumentumFiller";
        private SheetsService service;
        public List<string> AllStudent;
        public string SpreadSheetId
        {
            get
            {
                return Properties.Settings.Default.GoogleSheetAccess;
            }
            set
            {
                Properties.Settings.Default.GoogleSheetAccess = value;
                Properties.Settings.Default.Save();
            }
        }
        public string sheetName
        {
            get
            {
                return Properties.Settings.Default.GoogleSheetName;
            }
            set
            {
                Properties.Settings.Default.GoogleSheetName = value;
                Properties.Settings.Default.Save();
            }
        }
        public string URL
        {

            get
            {
                return Properties.Settings.Default.SheetURL;
            }
            set
            {
                Properties.Settings.Default.SheetURL = value;
                Properties.Settings.Default.Save();
            }
        }

        public bool SaveSpreadsheetID(string url)
        {
            try
            {
                GoogleCredential credential;
                using (var stream = new FileStream("GoogleSheet//client_secrets.json", FileMode.Open, FileAccess.Read))
                {
                    credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
                }

                service = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                string[] urlParts = url.Split('/');
                SpreadSheetId = urlParts[urlParts.Length - 2];
                GetAllStudentNames();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<string> GetSheetNames()
        {
            if (!IsValidSheetId())
            {
                return null;
            }
            if (service == null)
            {
                return null;
            }
            var ssRequest = service.Spreadsheets.Get(UniqueID);
            Spreadsheet ss = ssRequest.Execute();
            List<string> sheetList = new List<string>();

            foreach (Sheet sheet in ss.Sheets)
            {
                sheetList.Add(sheet.Properties.Title);
            }

            return sheetList;
        }

        public void GetAllStudentNames()
        {
            if (!IsValidSheetId())
            {
                //return;
            }

            var request = service.Spreadsheets.Get(SpreadSheetId);
            var response = request.Execute();
            try
            {
                string sheetName = response.Sheets[Properties.Settings.Default.ExcelOldal].Properties.Title;
            }
            catch
            {
                string sheetName = response.Sheets[0].Properties.Title;
                Properties.Settings.Default.ExcelOldal = 0;
                Properties.Settings.Default.Save();
            }
            var range = "{" + sheetName + "}!B:B";

            var requestNames = service.Spreadsheets.Values.Get(SpreadSheetId, range);
            var responseNames = requestNames.Execute();
            var values = responseNames.Values;
            List<string> names = new List<string>();
            if(values != null && values.Count > 0)
            {
                foreach(var row in values)
                {
                    names.Add(row[1].ToString());
                }
            }
            AllStudent = names;
        }

        public tanulo GetStudent(string nev)
        {
            if (!IsValidSheetId())
            {
                return null;
            }

            int index;
            try
            {
                index = AllStudent.IndexOf(nev) + 1;
            }
            catch
            {
                return null;
            }
            var range = "{" + sheetName + "}!"+ index +":" + index;
            var request = service.Spreadsheets.Values.Get(SpreadSheetId, range);

            var response = request.Execute();
            var values = response.Values;
            StringBuilder names = new StringBuilder();
            if (values != null && values.Count > 0)
            {
                int count = 0;
                foreach (var cell in values[0])
                {
                    names.Append(cell.ToString() + ";");
                    count++;
                }
            }
            tanulo student = new tanulo(names.ToString());
            return student;
        }

        public tanulo GetStudent(int index)
        {
            if (!IsValidSheetId())
            {
                return null;
            }
            var range = "{" + sheetName + "}!" + index + ":" + index;
            var request = service.Spreadsheets.Values.Get(SpreadSheetId, range);

            var response = request.Execute();
            var values = response.Values;
            StringBuilder names = new StringBuilder();
            if (values != null && values.Count > 0)
            {
                foreach (var cell in values[0])
                {
                    names.Append(cell.ToString() + ";");
                }
            }
            return new tanulo(names.ToString());
        }

        public List<string> GetAllDataTypes(ref string sorszam)
        {
            if (!IsValidSheetId())
            {
                return null;
            }
            var range = "{" + sheetName + "}!1:2";
            var request = service.Spreadsheets.Values.Get(SpreadSheetId, range);

            var response = request.Execute();
            var values = response.Values;
            List<string> dataTypes = new List<string>();

            if (values != null && values.Count > 0)
            {
                sorszam = values[1][0].ToString();

                dataTypes = new List<string>();
                int count = 0;
                foreach (var cell in values[0])
                {
                    
                    dataTypes.Add(cell.ToString());
                    count++;
                }
            }
            return dataTypes;
        }

        public bool IsValidSheetId()
        {
            if(SpreadSheetId == null || SpreadSheetId == "")
            {
                return false;
            }
            try
            {
                var request = service.Spreadsheets.Get(SpreadSheetId);
                //var response = request.Execute();

            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
