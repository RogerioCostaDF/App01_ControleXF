using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarPage : ContentPage
    {
        private List<String> empresasTI = new List<string>();

        public SearchBarPage()
        {
            InitializeComponent();

            
            empresasTI.Add("Microsoft");
            empresasTI.Add("SAP");
            empresasTI.Add("IBM");
            empresasTI.Add("UBER");
            empresasTI.Add("99Taxi");
            empresasTI.Add("Apple");
            empresasTI.Add("Tesla");
            empresasTI.Add("Oracle");
            empresasTI.Add("Adobe");
            empresasTI.Add("Facebook");

            Preencher(empresasTI);

        }

        private void Pesquisar(object sender, TextChangedEventArgs args)
        {
            var resultado = empresasTI.Where(a => a.Contains(args.NewTextValue)).ToList<string>();
            Preencher(resultado);
        }
        
        private void Preencher(List<string> empresasTI)
        {
            ListResult.Children.Clear();

            foreach (var empresa in empresasTI)
            {
                ListResult.Children.Add(new Label { Text = empresa });
            }
        }


        private void Pesquisar(object sender, EventArgs e)
        {
            var resultado = empresasTI.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<string>();
            Preencher(resultado);
        }
    }
}