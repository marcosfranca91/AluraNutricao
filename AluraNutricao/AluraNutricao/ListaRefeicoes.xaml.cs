using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AluraNutricao
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaRefeicoes : ContentPage
	{
        public ObservableCollection<Refeicao> Refeicoes { get; set; }

        public ListaRefeicoes (ObservableCollection<Refeicao> refeicoes)
		{
            this.Refeicoes = refeicoes;
            BindingContext = this;
			InitializeComponent ();
		}

        public async void AcaoItem(object sender, ItemTappedEventArgs e)
        {
            Refeicao refeicao = e.Item as Refeicao;
            
            var resposta = await DisplayAlert("Remover Item", "Você tem certeza que deseja remover a refeição " + refeicao.Descricao, "Sim", "Não");

            if (resposta)
            {
                Refeicoes.Remove(refeicao);
                await DisplayAlert("Remover Item", "Refeição removida com sucesso", "Ok");
            }
        }
	}
}