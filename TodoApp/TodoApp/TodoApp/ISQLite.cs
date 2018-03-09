using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
