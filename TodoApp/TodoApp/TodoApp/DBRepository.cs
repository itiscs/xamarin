using SQLite;
using System.Collections.Generic;
using System.Linq;
using TodoApp.Models;
using Xamarin.Forms;

namespace TodoApp
{
    public class DBRepository
    {
        SQLiteConnection database;
        public DBRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Todo>();
        }
        public IEnumerable<Todo> GetItems()
        {
            return database.Table<Todo>().ToList();
            //return (from i in database.Table<Todo>() select i).ToList();

        }
        public Todo GetItem(int id)
        {
            return database.Get<Todo>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Todo>(id);
        }
        public int SaveItem(Todo item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }

        public override string ToString()
        {
            return database.DatabasePath;
        }
    }
}

