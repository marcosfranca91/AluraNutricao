using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net;
using System.Runtime.CompilerServices;
using AluraNutricao.Data;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_ios))]
namespace AluraNutricao.Data
{
    
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
