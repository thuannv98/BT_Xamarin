using System;
using System.Collections.Generic;
using System.Text;

namespace Tuan3
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
