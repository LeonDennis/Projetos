using Android.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace teste
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
            contatoListView.ItemsSource = contatos;
            var status = Permissions.RequestAsync<Permissions.ContactsRead>();
            status = Permissions.CheckStatusAsync<Permissions.ContactsRead>();
        }
        List<String> contatos = new List<String>
      {
            "ABC","DEF","GHI","JKL","MNO","PQR","STU","VWX","YZ"
      };
        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var texto = contatoSearchBar.Text;
            contatoListView.ItemsSource = contatos.Where(
                  x => x.ToLower().Contains(texto.ToLower()));
        }

    }
}