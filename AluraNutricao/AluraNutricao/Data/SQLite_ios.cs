using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net;

namespace AluraNutricao.Data
{
    [assembly: Dependency(typeof(SQLite_ios))]
    class SQLite_ios : ISqlite
    {
        
        public SQLite_ios()
        {

        }
        public SQLiteConnection GetConnection()
        {
            var fileName = "Refeicao.db3";

            var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documents, "..", "Library", fileName);

            return new SQLiteConnection(path);
        }
    }
}
