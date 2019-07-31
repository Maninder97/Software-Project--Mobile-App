using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SQLite;

namespace MobileApp
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
