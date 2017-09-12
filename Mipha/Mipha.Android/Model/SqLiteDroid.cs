using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mipha.Models;
using SQLite;
using System.IO;
using Xamarin.Forms;
using Mipha.Droid;

[assembly: Dependency(typeof(SqLiteDroid))]
namespace Mipha.Droid
{

    public class SqLiteDroid : ISqlite
    {
        public SqLiteDroid() { }
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "Miphadb4.db3";
            string docpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(docpath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}