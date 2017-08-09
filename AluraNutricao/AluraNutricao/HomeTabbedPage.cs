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
        public ObservableCollection<Refeicao> refeicoes = new ObservableCollection<Refeicao>();

		public HomeTabbedPage ()
		{
            this.Children.Add(new CadastroRefeicao(refeicoes));
            this.Children.Add(new ListaRefeicoes(refeicoes));
		}
	}
}