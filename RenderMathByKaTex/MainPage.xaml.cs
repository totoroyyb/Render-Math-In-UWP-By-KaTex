using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RenderMathByKaTex
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public string htmlStr { get; set; }

        public MainPage()
        {
            this.InitializeComponent();           
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await MathWebView.InvokeScriptAsync("LoadFormula", new string[] { FirstFormulaBox.Text });
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            await SecondWebView.InvokeScriptAsync("LoadFormula", new string[] { SecondFormulaBox.Text });
        }

        private async void MathWebView_LoadCompleted(object sender, Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            await MathWebView.InvokeScriptAsync("LoadSample1", null);
        }

        private async void SecondWebView_LoadCompleted(object sender, Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            await SecondWebView.InvokeScriptAsync("LoadSample2", null);
        }
    }
}
