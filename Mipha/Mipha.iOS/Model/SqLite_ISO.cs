using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using SQLite;
using System.IO;
using Mipha.Models;
using Xamarin.Forms;
using Mipha.iOS.Model;

[assembly: Dependency(typeof(SqLite_ISO))]

namespace Mipha.iOS.Model
{
    public class SqLite_ISO: ISqlite
    {
        public SqLite_ISO() { }
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "Miphadb";
            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(docpath, "..", "Library");
            var path = Path.Combine(libraryPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}