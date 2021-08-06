using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_autósiskola.DataType
{
    class GoogleUser
    {
        public string UserName { get; set; }
        public string Code { get; set; }
        public string sheetAccess { get; set; }
        public GoogleUser(string userName, string code, string url)
        {
            UserName = userName;
            Code = code;

            string[] urlSplit = url.Split('/');
            sheetAccess = urlSplit[5];
        }
    }
}
