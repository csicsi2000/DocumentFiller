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
        public string SpreadSheetId;
        public string ApplicationName = "DocumentumFiller";
        private SheetsService service;
        public List<string> AllStudent;
        public string sheetAccess
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

        public bool SaveSpreadsheetID(string url)
        {
            try
            {
                GoogleCredential credential;
                using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
                {
                    credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
                }

                service = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                string[] urlParts = url.Split('/');
                SpreadSheetId = urlParts[urlParts.Length - 1];
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
            if(service == null)
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
            var range = "{" + sheetName + "}!B:B";
            var request = service.Spreadsheets.Values.Get(SpreadSheetId, range);

            var response = request.Execute();
            var values = response.Values;
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
                foreach (var cell in values[index])
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
            var range = "{" + sheetName + "}!" + index + ":" + index;
            var request = service.Spreadsheets.Values.Get(SpreadSheetId, range);

            var response = request.Execute();
            var values = response.Values;
            StringBuilder names = new StringBuilder();
            if (values != null && values.Count > 0)
            {
                int count = 0;
                foreach (var cell in values[index])
                {
                    names.Append(cell.ToString() + ";");
                    count++;
                }
            }
            return new tanulo(names.ToString());
        }
    }
}
