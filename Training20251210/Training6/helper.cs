using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training6.models;

namespace Training6
{
    public static class helper
    {
        public static User user { get; set; }
        public static ItemDatabaseContext db = new ItemDatabaseContext();

        public static HttpClient client = new HttpClient();

        //public static void showMessage(string message)
        //{
        //    MessageBox.Show(message);
        //}
    }
}
