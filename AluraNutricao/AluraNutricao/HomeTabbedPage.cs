using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AluraNutricao
{
	public class HomeTabbedPage : TabbedPage
	{
		public HomeTabbedPage ()
		{
            this.Children.Add(new CadastroRefeicao());
            this.Children.Add(new ListaRefeicoes());
		}
	}
}