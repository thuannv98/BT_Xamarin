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
using SQLite;
using System.IO;
using Tuan3.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(Connection))]

namespace Tuan3.Droid
{
    class Connection : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "qlhoa.db";
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }
    }
}