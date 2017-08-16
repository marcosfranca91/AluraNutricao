using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AluraNutricao.Data
{
    public class RefeicaoDAO 
    {
        private SQLiteConnection conexao;
        private ObservableCollection<Refeicao> lista;
        public ObservableCollection<Refeicao> Lista {
            get{
                if (lista == null)
                {
                    lista = GetAll();
                }
                return lista;
            }
            private set
            {
                lista = value;
            }
        }

        public RefeicaoDAO()
        {

        }

        public RefeicaoDAO(SQLiteConnection con)
        {
            conexao = con;
            conexao.CreateTable<Refeicao>();
        }

        public void Salvar(Refeicao refeicao)
        {
            conexao.Insert(refeicao);
            lista.Add(refeicao);
        }

        public ObservableCollection<Refeicao> GetAll()
        {
           return new ObservableCollection<Refeicao> (conexao.Table<Refeicao>)
        }

        
    }
}
