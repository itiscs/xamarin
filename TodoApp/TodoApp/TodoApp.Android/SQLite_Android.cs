using System;
using System.IO;
using Xamarin.Forms;
using TodoApp.Droid;

[assembly: Dependency(typeof(SQLite_Android))]
namespace TodoApp.Droid
{
    class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }
    }
}