using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace AluraNutricao.Data
{
    public interface ISqlite
    {
        SQLiteConnection GetConnection();
    }
}
