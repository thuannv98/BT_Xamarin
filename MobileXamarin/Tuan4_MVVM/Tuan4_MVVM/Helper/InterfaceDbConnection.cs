using System;
using System.Collections.Generic;
using System.Text;

namespace Tuan4_MVVM.Helper
{
    public interface InterfaceDbConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
