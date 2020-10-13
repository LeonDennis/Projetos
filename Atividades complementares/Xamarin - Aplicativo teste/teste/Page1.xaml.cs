using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace teste
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            float varBase = float.Parse(valBase.Text);
            float varAltura = float.Parse(valAltura.Text);
            float varArea = (varBase * varAltura) / 2;
            DisplayAlert("Cálculo realizado! ", string.Format("O valor da área do triângulo é: {0}.", varArea), "OK");
        }
    }
}