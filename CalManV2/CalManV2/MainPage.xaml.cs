using CalManV2.DataLogic;
using Xamarin.Forms;

namespace CalManV2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        double input;
        Calculate calculate = new Calculate();
        private void Button_Clicked(object sender, System.EventArgs e)
        {
            calculate.SetInput(input);
            Output.Text = calculate.Result();
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            input = System.Convert.ToDouble(Input.Text);
        }
    }
}
