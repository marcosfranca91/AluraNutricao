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

        public void AtualizaCalorias(Object sender, EventArgs e)
        {
            //Pegar o valor do slider
            double valor = sldCalorias.Value;
            lblCalorias.Text = valor.ToString();
        }

        public void SalvaRefeicao(Object sender, EventArgs e)
        {
            string descricao = entDescricao.Text;
            string calorias = sldCalorias.Value.ToString();
            string msg = "A refeição " + descricao + " de " + calorias + " calorias foi salva com sucesso";
            DisplayAlert("Cadastro de Calorias", msg, "OK" );
            Clear();
        }

        public void MostraLista(Object sender,EventArgs e)
        {
            ListaRefeicoes tela = new ListaRefeicoes();
            Navigation.PushAsync(tela);
        }

        public void Clear()
        {
            entDescricao.Text = "";
            sldCalorias.Value = 0;
        }
        
    }
}
