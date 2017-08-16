using AluraNutricao.Data;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AluraNutricao
{
	public class HomeTabbedPage : TabbedPage
	{
        private SQLiteConnection con = DependencyService.Get<ISqlite>().GetConnection();
        public RefeicaoDAO dao = new RefeicaoDAO(con);
        public ObservableCollection<Refeicao> refeicoes = dao.GetAll();

        public HomeTabbedPage ()
		{
            CadastroRefeicao telaCadastro = new CadastroRefeicao(dao);
            ListaRefeicoes telaLista = new ListaRefeicoes(dao);

            this.Children.Add(telaCadastro);
            this.Children.Add(telaLista);
		}
	}
}