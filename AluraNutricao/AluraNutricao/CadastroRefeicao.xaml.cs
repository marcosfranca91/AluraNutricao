using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AluraNutricao
{
	public partial class CadastroRefeicao : ContentPage
	{
		public CadastroRefeicao()
		{
			InitializeComponent();
		}

        public void atualizaContador(Object sender, EventArgs e)
        {
            String calorias = sldCalorias.Value.ToString();
            lblCalorias.Text = calorias;
        }

        public void SalvaRefeicao(Object sender, EventArgs e)
        {
            string descricao = entDescricao.Text;
            string calorias = sldCalorias.Value.ToString();
            string msg = "A refeição " + descricao + " de " + calorias + " calorias foi salva com sucesso";
            DisplayAlert("Cadastro de refeição", msg, "Ok");
            Clear();
        }

        private void Clear()
        {
            entDescricao.Text = "";
            sldCalorias.Value = 0;
        }
    }
}
