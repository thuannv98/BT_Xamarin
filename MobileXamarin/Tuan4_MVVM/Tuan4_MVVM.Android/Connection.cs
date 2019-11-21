using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using Tuan4_MVVM.Droid;
using Tuan4_MVVM.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(Connection))]

namespace Tuan4_MVVM.Droid
{
    class Connection : InterfaceDbConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "qlhoa.db";
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }
    }
}