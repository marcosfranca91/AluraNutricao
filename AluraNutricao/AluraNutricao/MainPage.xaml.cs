using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AluraNutricao
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public void AtualizaCalorias(Object sender, EventArgs e)
        {
            //Pegar o valor do slider
            double valor = sldCalorias.Value;
            lblCalorias.Text = valor.ToString();
        }

        public void salvaRefeicao(Object sender, EventArgs e)
        {
            string descricao = entDescricao.Text;
            string calorias = sldCalorias.Value.ToString();
            string msg = "A refeição " + descricao + " de " + calorias + " calorias foi salva com sucesso";
            DisplayAlert("Cadastro de Calorias", msg, "OK" );
            Clear();
        }

        public void Clear()
        {
            entDescricao.Text = "";
            sldCalorias.Value = 0;
            
        }
        
    }
}
